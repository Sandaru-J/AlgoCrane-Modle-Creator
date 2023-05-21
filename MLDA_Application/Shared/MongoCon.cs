using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows;
using System.IO;

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

        public List<DataFile> DgvData()
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

            var projection = Builders<BsonDocument>.Projection.Include("_id").Include("name").Include("path").Include("project");

            // Retrieve the documents in the collection with the name and path fields
            var documents = collection.Find(new BsonDocument()).Project(projection).ToList();

            // Convert the documents to a list of DataFile objects
            var dataFiles = documents.Select(d => new DataFile
            {
                d_id = d["_id"].ToString(),
                Name = d["name"].AsString,
                Path = d["path"].AsString,
                Project = d["project"].AsString,
            }).ToList();

            return dataFiles;
        }

        public List<DataFile> DgvModel()
        {
            // Create a MongoDB client
            var connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net";
            var client = new MongoClient(connectionString);

            // Get a database reference
            var databaseName = "MLDA";
            var database = client.GetDatabase(databaseName);

            // Get a collection reference
            var collectionName = "ModelFiles";
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var projection = Builders<BsonDocument>.Projection.Include("project_name").Include("model_name");

            // Retrieve the documents in the collection with the name and path fields
            var documents = collection.Find(new BsonDocument()).Project(projection).ToList();

            // Convert the documents to a list of DataFile objects
            var modelFiles = documents.Select(d => new DataFile
            {
                Pname = d["project_name"].AsString,
                Mname = d["model_name"].AsString,
            }).ToList();

            return modelFiles;
        }

        public void UploadCsv(string pname, string name, string path, string link)
        {
            try
            {
                var document = new BsonDocument
            {
                {"name", name},
                {"project", pname},
                {"path", path},
                {"link", link}
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

                MessageBox.Show("Model uploaded to MongoDB successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to upload model to MongoDB. {ex.Message}");
            }
        }
        public void UploadModelFile(string Pname, string Mname, string path)
        {
            try
            {
                // MongoDB connection details
                string connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net"; // Replace with your MongoDB connection string
                string dbName = "MLDA"; // Replace with your database name
                string collectionName = "ModelFiles"; // Replace with your collection name

                // Create a MongoClient to connect to MongoDB
                var mongoClient = new MongoClient(connectionString);

                // Get the database and collection
                var database = mongoClient.GetDatabase(dbName);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                // Load the model file into a byte array
                byte[] modelBytes = File.ReadAllBytes(path); // Replace with your model file path

                // Create a BsonDocument to hold the model data
                var modelData = new BsonDocument
                {
                    {"project_name", Pname },
                    { "model_name", Mname }, // Replace with a name for your model
                    { "model_file", new BsonBinaryData(modelBytes) }
                };

                // Insert the model data into MongoDB
                collection.InsertOne(modelData);

                MessageBox.Show("Model uploaded to MongoDB successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload model to MongoDB. {ex.Message}");
            }
        }
        public void DownloadModelFile(string mName)
        {
            string connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net"; // Replace with your MongoDB connection string
            string dbName = "MLDA"; // Replace with your database name
            string collectionName = "ModelFiles"; // Replace with your collection name

            // Create a MongoClient to connect to MongoDB
            var mongoClient = new MongoClient(connectionString);

            // Get the database and collection
            var database = mongoClient.GetDatabase(dbName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Define a filter to specify the document that contains the model file
            var filter = Builders<BsonDocument>.Filter.Eq("model_name", mName); // Replace "modelName" with the appropriate field and value that identifies the document containing the model file

            // Retrieve the document containing the model file
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                // Extract the model data from the retrieved document
                byte[] modelBytes = document["model_file"].AsByteArray;

                // Save the model data to a local file in the "Downloads" folder
                string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", $"{mName}.joblib");
                File.WriteAllBytes(savePath, modelBytes);
                MessageBox.Show($"Model file '{mName}' has been successfully downloaded and saved to '{savePath}'.", "Succesfully Downloaded");
            }
            else
            {
                MessageBox.Show($"Model file '{mName}' not found in MongoDB.", "Failed");
            }
        }
        public void DltDF(string documentId)
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

            // Define a filter to specify the document to be deleted
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));

            // Delete the document
            var result = collection.DeleteOne(filter);
            //Console.WriteLine("in mongo: " + documentId);
            // Check if the document was successfully deleted
            if (result.DeletedCount > 0)
            {
                MessageBox.Show($"Document with ID '{documentId}' has been successfully deleted.", "Sucessfully Deleted");
            }
            else
            {
                MessageBox.Show($"Document with ID '{documentId}' not found or failed to delete.", "Delete Failed");
            }
        }

        public void UpdDf(string id, string pName, string dfName, string path, string link)
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

            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));

            // Define the update operation
            var update = Builders<BsonDocument>.Update.Set("project", pName)
                                                        .Set("name", dfName)
                                                       .Set("path", path)
                                                       .Set("link", link);

            // Update the document in the collection
            var updateResult = collection.UpdateOne(filter, update);

            // Check if the update was successful
            if (updateResult.ModifiedCount > 0)
            {
                MessageBox.Show("Document updated successfully.", "Updated");
            }
            else
            {
                MessageBox.Show("Document not found or update failed.", "Updating Failed");
            }
        }
        public void DltModel(string mName)
        {
            // Create a MongoDB client
            var connectionString = "mongodb+srv://SiteUser:nAxKdh83uoIeaWFc@cluster0.h9ytvqs.mongodb.net";
            var client = new MongoClient(connectionString);

            // Get a database reference
            var databaseName = "MLDA";
            var database = client.GetDatabase(databaseName);

            // Get a collection reference
            var collectionName = "ModelFiles";
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Define a filter to specify the document to be deleted
            var filter = Builders<BsonDocument>.Filter.Eq("model_name", mName);

            // Delete the document
            var result = collection.DeleteOne(filter);
            //Console.WriteLine("in mongo: " + documentId);
            // Check if the document was successfully deleted
            if (result.DeletedCount > 0)
            {
                MessageBox.Show($"Document with ID '{mName}' has been successfully deleted.", "Sucessfully Deleted");
            }
            else
            {
                MessageBox.Show($"Document with ID '{mName}' not found or failed to delete.", "Delete Failed");
            }
        }
    }
    public class DataFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Project { get; set; }
        public string Pname { get; set; }
        public string Mname { get; set; }
        public string d_id { get; set; }
        public string link { get; set; }
    }

}
