using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    internal class javaClass : compilerInterface
    {
        string FolderPath;
        string combinedPath;
        string classpath;
        string javaCompilerPath;
        string javaFilePath;
        string filePath;

        public javaClass(string folderPath, string codeText)
        {
            string additionalPath = "java\\jdk-20\\bin\\javac.exe";
            javaCompilerPath = Path.Combine(folderPath, additionalPath);
            string filepath = "files\\java.java";
            string codePath = Path.Combine(Application.StartupPath, filepath);
            using (StreamWriter sw = new StreamWriter(codePath))
            {
                sw.WriteLine(codeText);
            }
            javaFilePath = codePath;
            classpath = Path.GetDirectoryName(codePath);
            filePath = Path.Combine(Application.StartupPath, "outputFiles\\output.txt");
            Console.WriteLine(javaCompilerPath);
            Console.WriteLine(javaFilePath);
            Console.WriteLine(filePath);
            Console.WriteLine(classpath);

        }

        public string CompileCode(string code)
        {
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = javaCompilerPath;
            compileProcess.StartInfo.Arguments = javaFilePath;
            compileProcess.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(javaCompilerPath); // Set the working directory
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;


            compileProcess.Start();


            string compileOutput = compileProcess.StandardOutput.ReadToEnd();
            string errorOutput = compileProcess.StandardError.ReadToEnd();


            compileProcess.WaitForExit();

            if (compileProcess.ExitCode == 0)
            {
                Console.WriteLine("Java file compiled successfully.");


                string className = System.IO.Path.GetFileNameWithoutExtension(javaFilePath);
                Console.WriteLine("Java :\n" + className);
                Process runProcess = new Process();
                runProcess.StartInfo.FileName = "java";
                runProcess.StartInfo.Arguments = "-cp " + classpath + " " + className;
                runProcess.StartInfo.UseShellExecute = false;
                runProcess.StartInfo.RedirectStandardOutput = true;

                runProcess.Start();


                string runOutput = runProcess.StandardOutput.ReadToEnd();

                runProcess.WaitForExit();

                Console.WriteLine("Java program output:\n" + runOutput);

                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(runOutput);
                }
                return runOutput;
            }
            else
            {

                Console.WriteLine("Java file compilation failed.");
                Console.WriteLine("error output:\n" + errorOutput);
                return errorOutput;
            }


        }

        public string compileType1(string startercode, string codeText, string trigger)
        {

            string textAppend = "haahahaha";
            string TextAppend2 = "lalalalala";
            try
            {
                File.WriteAllText(javaFilePath, startercode);
                //File.AppendAllText(InputFilePath, TextAppend2);
                Console.WriteLine("text appended successfully");
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending text: " + e.Message);


            }

            appendInFile(trigger, codeText);
            string returnval = CompileCode("hahaah");
            Console.WriteLine("this is return value");
            Console.WriteLine(returnval);
            return returnval;
        }

        public void appendInFile(string trigger, string codeToBeInserted)
        {
            try
            {
                string[] lines = File.ReadAllLines(javaFilePath);
                string pattern = @"^\s*int\s+n\s*=\s*5\s*;";
                Regex regex = new Regex(trigger);




                //int index = Array.IndexOf(lines, trigger);
                int index = Array.FindIndex(lines, line => regex.IsMatch(line));


                if (index != -1)
                {
                    lines[index] += Environment.NewLine + codeToBeInserted;

                    File.WriteAllLines(javaFilePath, lines);
                    //File.AppendAllText(javaFilePath, "hahaahha");


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


    }
}
