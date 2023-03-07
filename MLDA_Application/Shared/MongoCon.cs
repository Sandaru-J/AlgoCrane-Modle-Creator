using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MLDA_Application.Shared
{
    internal class MongoCon
    {
        public void dbconnection()
        {
            //mongodb + srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net/?retryWrites=true&w=majority

            // Create a MongoDB client
            var connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net";
            var client = new MongoClient(connectionString);

            // Get a database reference
            var databaseName = "MLDA";
            var database = client.GetDatabase(databaseName);

            // Get a collection reference
            var collectionName = "DataFiles";
            var collection = database.GetCollection<BsonDocument>(collectionName);

            try
            {
                var databaseNames = client.ListDatabaseNames().ToList();
                Console.WriteLine("Connection Suceed");
            }
            catch (Exception x)
            {
                Console.WriteLine($"Connection Failed.{x.Message}");
            }
        }

        public bool insertCsv(string name, string path)
        {
            var document = new BsonDocument
            {
                {"name", name},
                {"project", "MLDA"},
                {"path", path}
            };

            // Create a MongoDB client
            var connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net";
            var client = new MongoClient(connectionString);
            // Get a database reference
            var databaseName = "MLDA";
            var database = client.GetDatabase(databaseName);
            // Get a collection reference
            var collectionName = "DataFiles";
            var collection = database.GetCollection<BsonDocument>(collectionName);

            collection.InsertOne(document);
            Console.WriteLine("File inserted succesfully");

            return true;
        }
        public List<string> dataList()
        {
            // Create a MongoDB client
            var connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net";
            var client = new MongoClient(connectionString);

            // Get a database reference
            var databaseName = "MLDA";
            var database = client.GetDatabase(databaseName);

            // Get a collection reference
            var collectionName = "DataFiles";
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var projection = Builders<BsonDocument>.Projection.Include("name");

            // Retrieve the documents in the collection with only the names field
            var documents = collection.Find(new BsonDocument()).Project(projection).ToList();

            // Extract the names from the documents
            var names = documents.Select(d => d["name"].AsString).ToList();
            Console.WriteLine(names);
            return names;
        }

    }
}
