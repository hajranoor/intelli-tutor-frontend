using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    internal class cSharpClass : compilerInterface
    {
        string InputFilePath;
        string combinedPath;
        string codeText;

        public cSharpClass(string path, string codetext)
        {
            string compilerPath = "c#\\Microsoft.NET\\Framework64\\v4.0.30319\\csc.exe";
            string filepath = "files\\csharp.cs";
            InputFilePath = Path.Combine(Application.StartupPath, filepath);
            combinedPath = Path.Combine(path, compilerPath);
            Console.WriteLine(combinedPath);
            Console.WriteLine(InputFilePath);
            codeText = codetext;
        }

        public string CompileCode()
        {
            string returnValue;
            try
            {
                using (StreamWriter writer = new StreamWriter(InputFilePath))
                {
                    writer.Write(codeText);
                }

                string filePath = Path.Combine(Application.StartupPath, "outputFiles");
                string command = $"{combinedPath} /out:output.exe {InputFilePath}";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = $"/C \"{command}\""
                };

                Process process = new Process { StartInfo = startInfo };
                process.Start();


                string output = process.StandardOutput.ReadToEnd();
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();


                if (process.ExitCode == 0)
                {
                    ProcessStartInfo executionStartInfo = new ProcessStartInfo
                    {
                        FileName = "output.exe",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process executionProcess = new Process { StartInfo = executionStartInfo };
                    executionProcess.Start();

                    string outputFromExecution = executionProcess.StandardOutput.ReadToEnd();

                    executionProcess.WaitForExit();

                    Console.WriteLine("output: ");
                    Console.WriteLine(outputFromExecution);

                    

                    return outputFromExecution;


                }

                else
                {
                    //Console.WriteLine("haahaha");
                    Console.WriteLine("Compilation Error:");
                    Console.WriteLine(errorOutput);

                    //return errorOutput;
                    return "Compilation error occured";


                }

                //return "haahah";




                // You can choose to save the error output to a file as well, if needed.
                // File.WriteAllText(errorFilePath, errorOutputFromExecution);


            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return ex.Message;
            }


        }




    }
}
