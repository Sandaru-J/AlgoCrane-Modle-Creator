using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDA_Application.Shared
{
    internal class CliSwitch
    {
        string csv_path;
        public string Switch(string command, string path)
        {
            csv_path = path;
            string output;
            switch (command)
            {
                case "time":
                    output = DateTime.Now.ToString();
                    break;
                case "head":
                    output = scriptReader(1);
                    break;
                case "tail":
                    output = scriptReader(2);
                    break;
                case "shape":
                    output = scriptReader(3);
                    break;
                case "cols":
                    output = scriptReader(4);
                    break;
                case "col_d":
                    output = scriptReader(5);
                    break;
                default:
                    output = "Invalid command. Please try again.";
                    break;
            }
            return output;
        }

        public string scriptReader(int flag)
        {
            if(csv_path == null)
            {
                string error="No data set Selected.";
                return error;
            }
            // console.WriteLine("Hello World!");
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\cliSwitch.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";

            string check_string = "testing 1";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\" " +
                              $"\"{csv_path}\" " +
                              $"\"{check_string}\"" +
                              $"\"{flag}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();
                return output;
            }
        }
    }
}
