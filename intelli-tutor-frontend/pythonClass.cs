using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    internal class pythonClass : compilerInterface
    {
        string pythonScriptPath;
        string pythonPath;
        string pythonCode;
        public pythonClass(string foldername, string codeText) 
        {
            string compilerPath = "python\\Python311\\python.exe";
            pythonPath = Path.Combine(foldername, compilerPath);
            Console.WriteLine(pythonPath);
            string filepath = "files\\python.py";
            string codePath = Path.Combine(Application.StartupPath, filepath);
            using (StreamWriter sw = new StreamWriter(codePath))
            {
                sw.WriteLine(codeText);
            }

            pythonScriptPath = codePath;


        }

        public string CompileCode()
        {
            try
            {
                pythonCode = File.ReadAllText(pythonScriptPath);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();


                using (StreamWriter standardInput = process.StandardInput)
                {
                    if (standardInput.BaseStream.CanWrite)
                    {
                        standardInput.WriteLine(pythonCode);
                    }
                }

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine("Python Output:");
                    Console.WriteLine(output);
                    return output;

                }

                else
                {
                    Console.WriteLine("Python Error:");
                    Console.WriteLine(error);
                    return error;

                }


                //Console.WriteLine("Python Output:");
                //Console.WriteLine(output);

                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine("Python Error:");
                    Console.WriteLine(error);
                }

                //process.WaitForExit();
                process.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return ex.Message;
            }



        }

    }
}
