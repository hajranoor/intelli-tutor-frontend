using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
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


        public string CompileCode(string code)
        {
            string returnValue;
            try
            {
                using (StreamWriter writer = new StreamWriter(InputFilePath))
                {
                    writer.Write(code);
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

        public string compileType1(string startercode, string codeText , string trigger)
        {

            string textAppend = "haahahaha";
            string TextAppend2 = "lalalalala";
            try
            {
                File.WriteAllText(InputFilePath, startercode);
                //File.AppendAllText(InputFilePath, TextAppend2);
                Console.WriteLine("text appended successfully");
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending text: " + e.Message);


            }

            appendInFile(trigger , codeText);
            string returnval = CompileCode2();
            Console.WriteLine("this is return value");
            Console.WriteLine(returnval);
            return ("hahaah");
        }

        public void appendInFile(string trigger, string codeToBeInserted)
        {
            try
            {
                string[] lines = File.ReadAllLines(InputFilePath);
                string pattern = @"^\s*int\s+n\s*=\s*5\s*;";
                Regex regex = new Regex(trigger);


                

                //int index = Array.IndexOf(lines, "int n = 5;");
                int index = Array.FindIndex(lines, line => regex.IsMatch(line));


                if (index != -1)
                {
                    lines[index] += Environment.NewLine + codeToBeInserted;

                    File.WriteAllLines(InputFilePath, lines);

                    Console.WriteLine("Code appended successfully.");

                }

                else
                {
                    Console.WriteLine($"{trigger} not found");
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending code: " + e.Message);
            }



        }

        public string CompileCode2()
        {
            string returnValue;
            try
            {

                string[] lines = File.ReadAllLines(InputFilePath);
                Console.WriteLine("this is lienss");
                foreach (string line in lines)
                {
                    Console.WriteLine(line + "\n");
                }
                Console.WriteLine(lines);





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


                //if (process.ExitCode == 0)
                //{
                    ProcessStartInfo executionStartInfo = new ProcessStartInfo
                    {
                        FileName = "output.exe",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,

                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process executionProcess = new Process { StartInfo = executionStartInfo };
                    executionProcess.Start();

                    string outputFromExecution = executionProcess.StandardOutput.ReadToEnd();
                    string errorfrom = executionProcess.StandardOutput.ReadToEnd();


                    executionProcess.WaitForExit();

                    Console.WriteLine("output: ");
                    Console.WriteLine(outputFromExecution);

                    Console.WriteLine("error: ");
                    Console.WriteLine(errorfrom);



                    return outputFromExecution;


                //}

                //else
                //{
                    //Console.WriteLine("haahaha");
                    Console.WriteLine("Compilation Error:");
                    Console.WriteLine(errorOutput);

                    //return errorOutput;
                    //return "Compilation error occured";


                //}

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
