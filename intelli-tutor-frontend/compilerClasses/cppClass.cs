using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using intelli_tutor_frontend.Model;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using intelli_tutor_frontend.StudentSide;


namespace intelli_tutor_frontend.compilerClasses
{
    internal class cppClass
    {
        string filePath;
        string path;
        string outputFile;
        string compilerPath;
        bool isError = false;

        public cppClass(string folderPath, string codeText) 
        {
            //using (StreamWriter sw = new StreamWriter(codePath))
            //{
                //sw.WriteLine(codeText);
            //}
            Console.WriteLine("yes, u got called");

            filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "files\\cplus.cpp");
             path = Path.GetDirectoryName(filePath);
             outputFile = Path.Combine(System.Windows.Forms.Application.StartupPath, "outputFiles\\output.txt");
             compilerPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "compilersFolder\\c++\\MinGW\\bin\\g++.exe");
            using (StreamWriter sw =  new StreamWriter(filePath))
            {
                sw.WriteLine(codeText);
            }
            Console.WriteLine(filePath);
            Console.WriteLine(path);
            Console.WriteLine(outputFile);
            Console.WriteLine(compilerPath);
        }

        public string CompileCode()
        {
            string command = "g++";
            string outputExePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "output.exe");

            //string arguments = $"\"{filePath}\" -o \"{path}\\output.exe\"";
            string arguments = $"\"{filePath}\" -o \"{outputExePath}\"";
            compilerPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "compilersFolder\\c++\\MinGW\\bin\\g++.exe");

            ProcessStartInfo processInfo = new ProcessStartInfo(compilerPath, arguments);

            Process compileProcess = new Process();
            //System.Windows.Forms.MessageBox.Show(compileProcess.StartInfo.FileName);
            compileProcess.StartInfo = processInfo;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.CreateNoWindow = true;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;
            compileProcess.Start();
            compileProcess.WaitForExit();
            string compilationOutput = compileProcess.StandardOutput.ReadToEnd();
            //System.Windows.Forms.MessageBox.Show(compilationOutput, "this is compilation output");

            string compilationErrors = compileProcess.StandardError.ReadToEnd();
            //System.Windows.Forms.MessageBox.Show("this is compilation errors", compilationErrors);


            if (compileProcess.ExitCode == 0)
            {
                Process executeProcess = new Process();
                executeProcess.StartInfo.FileName = "output.exe";
                executeProcess.StartInfo.UseShellExecute = false;
                executeProcess.StartInfo.CreateNoWindow = true;
                executeProcess.StartInfo.RedirectStandardInput = true;
                executeProcess.StartInfo.RedirectStandardOutput = true;
                executeProcess.Start();

                executeProcess.StandardInput.Flush();
                executeProcess.StandardInput.Close();

                string output = executeProcess.StandardOutput.ReadToEnd();
                executeProcess.WaitForExit();
                //System.Windows.Forms.MessageBox.Show(output, "this is standard output");
                File.WriteAllText(outputFile, output);
                return output;
            }
            else
            {
                File.WriteAllText(outputFile, compilationErrors);
                //System.Windows.Forms.MessageBox.Show(compilationErrors);
                isError = true;
                return compilationErrors;

            }

            //if (File.Exists(outputExePath))
            //{
                //File.Delete(outputExePath);
            //}


        }

        public bool runCode(string studentCode, string regexPattern, string[] testCaseInput, string testCaseOutput)
        {
            //Match m = Regex.Match("void myFunction(int n, string m, float val, Array data){\\n      Console.WriteLine(n + m);\\n}", @"(myFunction\([\w\s,]+)\)");
            string escapedPatternString = @regexPattern;
            
            Match m = Regex.Match(studentCode,escapedPatternString);

            if (m.Success)
            {
                //System.Windows.Forms.MessageBox.Show("Pattern matched: " + m.Value);
                Console.WriteLine();
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Pattern did not match.");
                Console.WriteLine();
            }
            string studentCodeWithInputs = Regex.Replace(studentCode, regexPattern, match => replaceInputData(match, testCaseInput));
            //System.Windows.Forms.MessageBox.Show(studentCodeWithInputs);
            try
            {
                File.WriteAllText(filePath, studentCodeWithInputs);
                //System.Windows.Forms.MessageBox.Show("starter code appended");
                string output = CompileCode();

                if(output == testCaseOutput)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while appending", e.Message);
            }
            return false;

        }

        public string replaceInputData(Match match, string[] inputData)
        {
            //System.Windows.Forms.MessageBox.Show("yes called");

            string parametersText = match.Groups[1].Value;
            string[] parameters = parametersText.Split(',');

            string[] modifiedParameters = new string[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                string param = parameters[i].Trim();
                modifiedParameters[i] = $"{param} = {inputData[i]}";
            }

            return $"{string.Join(", ", modifiedParameters)}";
        }



        //working code starts here

        public string AddEquals(Match match, string[] inputData)
        {
            string parametersText = match.Groups[1].Value;
            string[] parameters = parametersText.Split(',');

            string[] modifiedParameters = new string[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                string param = parameters[i].Trim();
                modifiedParameters[i] = $"{param} = {inputData[i]}";
            }

            return $"{string.Join(", ", modifiedParameters)})";
        }

        string inputString = "#include <iostream>\r\n\r\nint add(int a, int b) {\r\n            std::cout << a + b<< std::endl;\r\n\r\n}\r\n\r\nint main() {\r\n    add();\r\n    return 0;\r\n}";


        public bool compileWithTestCases(string code, string regexPattern, string[] inputData, string[] output , RichTextBox outputBox, int testCaseCount)
        {
            string responseString = "";
            try
            {
                outputBox.SelectionStart = outputBox.TextLength;

                //File.WriteAllText(filePath, code);
                //string fileContent = File.ReadAllText(filePath);
                string outputString = Regex.Replace(code, regexPattern, match => AddEquals(match, inputData));
                File.WriteAllText(filePath, outputString);

                string compilationOutput = CompileCode();
                if (isError)
                {
                    outputBox.Text = "";
                    outputBox.AppendText(compilationOutput);
                    return false;
                }
                //System.Windows.MessageBox.Show(compilationOutput, "OUTPUT");
                //System.Windows.MessageBox.Show("this is output from db", output);
                
                if(compilationOutput == null || compilationOutput == "")
                {
                    return false;
                }
                string[] splitCompilationOutput = compilationOutput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if(splitCompilationOutput.Length == output.Length)
                {
                    int finalOutputCount = 0;
                    string printExpectedOutput = "";
                    string printOutput = "";
                    //System.Windows.Forms.MessageBox.Show("yes called");
                    for (int i = 0;i< splitCompilationOutput.Length; i++)
                    {
                        printOutput += splitCompilationOutput[i] + ", ";
                        printExpectedOutput += output[i] + ", ";

                        int intCompilationResult;
                        int intOutputResult;
                        if (int.TryParse(splitCompilationOutput[i], out intCompilationResult) && int.TryParse(output[i], out intOutputResult))
                        {
                            if (intCompilationResult == intOutputResult)
                            {
                                outputBox.SelectionColor = System.Drawing.Color.Black;
                                outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                //outputBox.AppendText("Test Case " + testCaseCount + ": ");
                                //outputBox.SelectionColor = System.Drawing.Color.Green;
                                //outputBox.AppendText("(Passed)" + "\n" + "\n");




                                ////System.Windows.MessageBox.Show("test case passed");
                                //var responseArray1 = new[]
                                //{new {YourOutput = compilationOutput , responseBool = "true" }};
                                //responseString = JsonConvert.SerializeObject(responseArray1);


                                string responseBool = "true";
                                //string[] responseArray = { compilationOutput, output[i], responseBool };
                                finalOutputCount++;
                            }
                            else
                            {
                                //outputBox.SelectionStart = outputBox.TextLength;
                                ////outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                ////outputBox.AppendText("Test Case " + testCaseCount + ": (Failed)" + "\n");

                                //outputBox.SelectionColor = System.Drawing.Color.Black;
                                //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                //outputBox.AppendText("Test Case " + testCaseCount + ": ");
                                //outputBox.SelectionColor = System.Drawing.Color.Red;
                                //outputBox.AppendText("(Failed)" + "\n" + "\n");

                                ////System.Windows.MessageBox.Show("test case failed");
                                //var responseArray1 = new[]
                                //{new {YourOutput = compilationOutput , responseBool = "false" }};
                                //responseString = JsonConvert.SerializeObject(responseArray1);

                                string responseBool = "false";
                                //string[] responseArray = { compilationOutput, output[i], responseBool };
                                //return responseArray;
                            }
                            //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                            //outputBox.AppendText("Expected Output : " + output[i] + "\n");
                            //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                            //outputBox.AppendText("Output : " + splitCompilationOutput[i] + "\n" + "\n");
                            //outputBox.SelectAll();
                            //outputBox.SelectionBackColor = outputBox.BackColor;
                            //outputBox.SelectionIndent = 10;
                            //outputBox.SelectionRightIndent = 10;
                            //outputBox.SelectionStart = 0;
                            //outputBox.DeselectAll();
                            //outputBox.WordWrap = true;
                            //return true;
                            //return responseArray
                        }
                        else if (splitCompilationOutput[i] is string && output[i] is string){
                            if (splitCompilationOutput[i] == output[i])
                            {
                                //outputBox.SelectionColor = System.Drawing.Color.Black;
                                //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                //outputBox.AppendText("Test Case " + testCaseCount + ": ");
                                //outputBox.SelectionColor = System.Drawing.Color.Green;
                                //outputBox.AppendText("(Passed)" + "\n" + "\n");




                                ////System.Windows.MessageBox.Show("test case passed");
                                //var responseArray1 = new[]
                                //{new {YourOutput = compilationOutput , responseBool = "true" }};
                                //responseString = JsonConvert.SerializeObject(responseArray1);


                                //string responseBool = "true";
                                //string[] responseArray = { compilationOutput, output[i], responseBool };
                                finalOutputCount++;

                            }
                            else
                            {
                                //outputBox.SelectionStart = outputBox.TextLength;
                                ////outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                ////outputBox.AppendText("Test Case " + testCaseCount + ": (Failed)" + "\n");

                                //outputBox.SelectionColor = System.Drawing.Color.Black;
                                //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                                //outputBox.AppendText("Test Case " + testCaseCount + ": ");
                                //outputBox.SelectionColor = System.Drawing.Color.Red;
                                //outputBox.AppendText("(Failed)" + "\n" + "\n");

                                ////System.Windows.MessageBox.Show("test case failed");
                                //var responseArray1 = new[]
                                //{new {YourOutput = compilationOutput , responseBool = "false" }};
                                //responseString = JsonConvert.SerializeObject(responseArray1);

                                string responseBool = "false";
                                //string[] responseArray = { compilationOutput, output[i], responseBool };
                                //return responseArray;
                            }
                            
                            //return responseArray
                        }
                    }
                    //System.Windows.Forms.MessageBox.Show(finalOutputCount + ":" + splitCompilationOutput.Length);

                    if (finalOutputCount == splitCompilationOutput.Length)
                    {
                        outputBox.SelectionColor = System.Drawing.Color.Black;
                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Test Case " + testCaseCount + ": ");
                        outputBox.SelectionColor = System.Drawing.Color.Green;
                        outputBox.AppendText("(Passed)" + "\n" + "\n");

                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Expected Output : " + printExpectedOutput + "\n");
                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Output : " + printOutput + "\n" + "\n");
                        outputBox.SelectAll();
                        outputBox.SelectionBackColor = outputBox.BackColor;
                        outputBox.SelectionIndent = 10;
                        outputBox.SelectionRightIndent = 10;
                        outputBox.SelectionStart = 0;
                        outputBox.DeselectAll();
                        outputBox.WordWrap = true;
                        return true;
                    }
                    else
                    {
                        outputBox.SelectionStart = outputBox.TextLength;
                        //outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                        //outputBox.AppendText("Test Case " + testCaseCount + ": (Failed)" + "\n");

                        outputBox.SelectionColor = System.Drawing.Color.Black;
                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Test Case " + testCaseCount + ": ");
                        outputBox.SelectionColor = System.Drawing.Color.Red;
                        outputBox.AppendText("(Failed)" + "\n" + "\n");
                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Expected Output : " + printExpectedOutput + "\n");
                        outputBox.SelectionFont = new System.Drawing.Font(outputBox.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
                        outputBox.AppendText("Output : " + printOutput + "\n" + "\n");
                        outputBox.SelectAll();
                        outputBox.SelectionBackColor = outputBox.BackColor;
                        outputBox.SelectionIndent = 10;
                        outputBox.SelectionRightIndent = 10;
                        outputBox.SelectionStart = 0;
                        outputBox.DeselectAll();
                        outputBox.WordWrap = true;
                        return true; // to run other test case any one is failed
                    }
                }
                else
                {
                    string data = "";
                    //for(int j = 0; j<= splitCompilationOutput.Length; j++)
                    //{
                    //    data += splitCompilationOutput[j] + " : ";
                    //}

                    //System.Windows.MessageBox.Show(compilationOutput + " <> " + data + " <> " + splitCompilationOutput.Length.ToString() );
                    outputBox.AppendText("The outputs are not complete");
                    return false; // stop matching he output if the number of putput is not same 
                }
                //if (int.Parse(compilationOutput) == int.Parse(output))
                
                return false;
                    
            }
            catch (IOException e)
            {
                Console.WriteLine("exception occured", e.Message);
                string responseBool = "exception occured";
                var responseArray1 = new[]
                    {new {YourOutput = "inner system exception occured" , responseBool = "exception" }};
                responseString = JsonConvert.SerializeObject(responseArray1);

                string[] responseArray = {responseBool};
                return false;

                //return responseArray;
            }
        }

        //working code ends here







        public void compileType1(string startercode, string codeText , string trigger, JArray jsonArray, string removingPattern)
        {
            try
            {
                File.WriteAllText(filePath, codeText);
                //System.Windows.MessageBox.Show("starter code appended");
                File.WriteAllText(filePath, startercode);
                //System.Windows.Forms.MessageBox.Show("starter code appended");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while appending", e.Message);
            }

            //appendInFile(trigger, codeText);
            //testCases(jsonArray, trigger, removingPattern);
            appendInFile2(trigger, jsonArray);
            
        }

        public string AddEquals2(Match match, string[] inputData)
        {
            //System.Windows.Forms.MessageBox.Show("yes called");

            string parametersText = match.Groups[1].Value;
            string[] parameters = parametersText.Split(',');

            string[] modifiedParameters = new string[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                string param = parameters[i].Trim();
                modifiedParameters[i] = $"{param} = {inputData[i]}";
            }

            return $"{string.Join(", ", modifiedParameters)})";
        }



        public void appendInFile2(string trigger, JArray jsonArray)
        {


            string fileContent = File.ReadAllText(filePath);

            string regexPattern = @"unsigned\s+long\s+long\s+calculateFactorial\(int\s+n\s*=\s*0\s*\)";
            string[] inputData = new string[] { "2", "3" };
            int expectedOutput = 5;

            string outputString = Regex.Replace(fileContent, trigger, match => AddEquals(match, inputData));
            File.WriteAllText(filePath, outputString);

            string returnVal = CompileCode();
            int retval = int.Parse(returnVal);

            if (retval == expectedOutput)
            {
                //System.Windows.MessageBox.Show("test case passed");
            }
            else
            {
                //System.Windows.MessageBox.Show("test case failed");
            }

            //System.Windows.MessageBox.Show(outputString);

            //string inputString = "#include <iostream>\r\n\r\nvoid myFunction(int param1, double param2) {\r\n    // Function implementation here\r\n}\r\n\r\nint main() {\r\n    // Main program logic\r\n    return 0;\r\n}";
            //string inputString = "double multiply(double num1, double num2, double num3) {\r\n";











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
                    //System.Windows.Forms.MessageBox.Show("codetobeinserted appended");
                }
                else
                {
                    Console.WriteLine("error");
                    //System.Windows.Forms.MessageBox.Show("regex not found");

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
                        //System.Windows.MessageBox.Show("testcase appended");
                    }
                    else
                    {   
                        //System.Windows.Forms.MessageBox.Show("test case not added");
                    }


                    //now send code for compilation and bring result
                }
                string returnValue = CompileCode();
                int expectedOutput = item.Value<int>("expected_output");
                //MessageBox.Show(expectedOutput);

                int returnval = int.Parse(returnValue);

                if (returnval == expectedOutput)
                {
                    //System.Windows.MessageBox.Show("test case passed");
                } 
                
                else
                {
                    //System.Windows.Forms.MessageBox.Show("test case failed");
                }


                string pattern = @"int\s+n\s*=\s*\d+\s*;|int\s+m\s*=\s*\d+\s*;";
                string fileContent = File.ReadAllText(filePath);

                string replacedContent = Regex.Replace(fileContent, removingPattern, string.Empty, RegexOptions.Multiline);
                File.WriteAllText(filePath, replacedContent);





            }
        }
    }
}
