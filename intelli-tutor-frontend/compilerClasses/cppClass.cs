using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace intelli_tutor_frontend.compilerClasses
{
    internal class cppClass
    {
        string filePath;
        string path;
        string outputFile;
        string compilerPath;
        public cppClass(string folderPath, string codeText) 
        {
            //using (StreamWriter sw = new StreamWriter(codePath))
            //{
                //sw.WriteLine(codeText);
            //}
            Console.WriteLine("yes, u got called");

            filePath = Path.Combine(Application.StartupPath, "files\\cplus.cpp");
             path = Path.GetDirectoryName(filePath);
             outputFile = Path.Combine(Application.StartupPath, "outputFiles\\output.txt");
             compilerPath = Path.Combine(folderPath, "c++\\MinGW\\bin\\g++.exe");
            using (StreamWriter sw =  new StreamWriter(filePath))
            {
                sw.WriteLine(codeText);
            }
            Console.WriteLine(filePath);
            Console.WriteLine(path);
            Console.WriteLine(outputFile);
            Console.WriteLine(compilerPath);
        }

        public string CompileCode(string code)
        {
            string command = "g++";
            string outputExePath = Path.Combine(Application.StartupPath, "output.exe");

            //string arguments = $"\"{filePath}\" -o \"{path}\\output.exe\"";
            string arguments = $"\"{filePath}\" -o \"{outputExePath}\"";


            ProcessStartInfo processInfo = new ProcessStartInfo(command, arguments);

            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = compilerPath;
            compileProcess.StartInfo = processInfo;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;
            compileProcess.Start();
            compileProcess.WaitForExit();

            string compilationOutput = compileProcess.StandardOutput.ReadToEnd();
            MessageBox.Show("this is compilation output", compilationOutput);

            string compilationErrors = compileProcess.StandardError.ReadToEnd();
            MessageBox.Show("this is compilation errors", compilationErrors);


            if (compileProcess.ExitCode == 0)
            {
                Process executeProcess = new Process();
                executeProcess.StartInfo.FileName = "output.exe";
                executeProcess.StartInfo.UseShellExecute = false;
                executeProcess.StartInfo.RedirectStandardInput = true;
                executeProcess.StartInfo.RedirectStandardOutput = true;
                executeProcess.Start();

      
                executeProcess.StandardInput.Flush();
                executeProcess.StandardInput.Close();

                string output = executeProcess.StandardOutput.ReadToEnd();
                executeProcess.WaitForExit();
                MessageBox.Show(output);
                File.WriteAllText(outputFile, output);
                return output;
            }
            else
            {
                File.WriteAllText(outputFile, compilationErrors);
                MessageBox.Show(compilationErrors);
                return compilationErrors;

            }

            //if (File.Exists(outputExePath))
            //{
                //File.Delete(outputExePath);
            //}


        }


        public void compileType1(string startercode, string codeText , string trigger, JArray jsonArray, string removingPattern)
        {
            try
            {
                File.WriteAllText(filePath, startercode);
                MessageBox.Show("starter code appended");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while appending", e.Message);
            }

            appendInFile(trigger, codeText);
            testCases(jsonArray, trigger, removingPattern);



        }

        public void appendInFile(string trigger, string codeToBeInserted)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                Regex regex = new Regex(trigger);

                int index = Array.FindIndex(lines, line => regex.IsMatch(line));

                if (index != -1)
                {
                    lines[index] += Environment.NewLine + codeToBeInserted;
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("codetobeinserted appended");
                }
                else
                {
                    Console.WriteLine("error");
                    MessageBox.Show("regex not found");

                }
            }
            catch(IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void testCases(JArray jsonArray, string trigger, string removingPattern)
        {
            foreach (JObject item in jsonArray)
            {
                JArray inputArray = item.Value<JArray>("input_value1");

                foreach (var value in inputArray)
                {
                    string[] lines = File.ReadAllLines(filePath);
                    Regex regex = new Regex(trigger);

                    int index = Array.FindIndex(lines, line => regex.IsMatch(line));

                    if (index != -1)
                    {
                        lines[index] += Environment.NewLine + value;
                        File.WriteAllLines(filePath, lines);
                        System.Windows.MessageBox.Show("testcase appended");
                    }
                    else
                    {
                        MessageBox.Show("test case not added");
                    }


                    //now send code for compilation and bring result
                }
                string returnValue = CompileCode("hahaah");
                int expectedOutput = item.Value<int>("expected_output");
                //MessageBox.Show(expectedOutput);

                int returnval = int.Parse(returnValue);

                if (returnval == expectedOutput)
                {
                    MessageBox.Show("test case passed");
                }
                else
                {
                    MessageBox.Show("test case failed");
                }


                string pattern = @"int\s+n\s*=\s*\d+\s*;|int\s+m\s*=\s*\d+\s*;";
                string fileContent = File.ReadAllText(filePath);

                string replacedContent = Regex.Replace(fileContent, removingPattern, string.Empty, RegexOptions.Multiline);
                File.WriteAllText(filePath, replacedContent);





            }
        }
    }
}
