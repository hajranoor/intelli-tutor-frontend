using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.compilerClasses;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace intelli_tutor_frontend
{
    public partial class QuestionForm : Form
    {
        private problemModel problem;
        private List<testCaseModel> testcaseList;
        public QuestionForm(problemModel problem)
        {
            InitializeComponent();
            this.problem = problem;
        }

        string path;

        

        


        string json = @"
        [
            {
                ""input_value1"": [""int m =1;"",""int n =2;""],
                ""input_value2"": ""World"",
                ""expected_output"": 3
            },
            {
                ""input_value1"": [""int m =3;"",""int n =4;""],
                ""input_value2"": 7,
                ""expected_output"": 7
            },
            {
                ""input_value1"": [""int m =5;"",""int n =6;""],
                ""input_value2"": [4, 5, 6],
                ""expected_output"": 5
            }
        ]";


        private async void QuestionForm_Load(object sender, EventArgs e)
        {
            //TestCasesApi testCasesApi = new TestCasesApi();
            //testcaseList = await testCasesApi.getAllTestCasesData(problem.problem_id);
            //this.problemName.Text = problem.problem_name;
            //this.questionBox.Text = problem.description;
            //int count = 1;
            //foreach (var item in testcaseList)
            //{
            //questionBox.Text += "Test Case " + count + " : ";
            //count++;
            //questionBox.Text += "Input : ";
            //foreach (var item1 in item.input_data)

            //{
            //questionBox.Text += item1;
            //}
            //questionBox.Text += "Output : " + item.output_data;
            //}

            //MessageBox.Show(problem.description);



            



            Console.WriteLine("this is path");

            string applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Application is running from: " + applicationDirectory);

            string compilersPath = "compilersFolder";
            path = Path.Combine(Application.StartupPath, compilersPath);
            Console.WriteLine("this is path" + path);

            string[] CompilersName = Directory.GetDirectories(path);
            foreach (string compiler in CompilersName)
            {
                string displayName = Path.GetFileName(compiler);
                compilerComboBox1.Items.Add(displayName);
            }
            //codeBox.Text = "#include <iostream>\r\n\r\nint main() {\r\n\r\n}\r\n";  //from backend
            //codeBox.Text = "#include bgfbtreabb\r\n\r\n// Function to calculate factorial\r\nunsigned long long calculateFactorial(int n) {\r\n    if (n <= 1) {\r\n        return 1; // Base case: factorial of 0 and 1 is 1\r\n    } else {\r\n        return n * calculateFactorial(n - 1); // Recursive case\r\n    }\r\n}\r\n\r\n\r\nint main() {\r\n    \r\n    if (num < 0) {\r\n        std::cout << \"Factorial is not defined for negative numbers.\" << std::endl;\r\n    } else {\r\n        unsigned long long factorial = calculateFactorial();\r\n        std::cout << \"Factorial of \" << num << \" is \" << factorial << std::endl;\r\n    }\r\n\r\n    return 0;\r\n}\r\n\r\n\r\n\r\n";
            //ghghgghghghghghghghgyFunction(int param1, double param2) {\r\n        std::cout << param1 + param2<< std::endl;\r\n\r\n}\r\n\r\nint main() {\r\n    myFunction()\r\n    return 0;\r\n}\r\n";
            codeBox.Text = "#include<iostream>\r\nusing namespace std;\r\nint main(int a, int b){\r\n}";





        }

        private async void compileButton_Click(object sender, EventArgs e)
        {
            if (compilerComboBox1.Text == "python")
            {
                string codeText = codeBox.Text;
                pythonClass pythonObj = new pythonClass(path, codeText);
                string returnValue = pythonObj.CompileCode(codeText);
                outputBox.Text = returnValue;
            }

            if (compilerComboBox1.Text == "java")
            {
                string codeText = codeBox.Text;
                javaClass javaClassObj = new javaClass(path, codeText);
                //string returnValue = javaClassObj.CompileCode(codeText);
                string startercode = "public class java {\r\n    public static void main(String[] args) {\r\n        int n = 5;\r\n    }\r\n}\r\n";
                string trigger  = @"^\s*int\s+main\s*\(\s*\)\s*{[^{}]*\s*}";
                string returnValue2 = javaClassObj.compileType1(startercode, codeText, trigger);


                //Console.WriteLine("this is response" + returnValue);
                outputBox.Text = returnValue2;
            }






















            if (compilerComboBox1.Text == "c++")
            {
                JArray jsonArray = JArray.Parse(json);  //from backend
                string removingPattern = @"int\s+n\s*=\s*\d+\s*;|int\s+m\s*=\s*\d+\s*;";  //from backend
                //string startercode = "#include <iostream>\r\n\r\nint main() {\r\n\r\n}\r\n";  //from backend
                //string trigger = @"^\s*int\s+main\s*\(\s*\)\s*{";   //from backend


                //string trigger = @"(unsigned long long calculateFactorial\([\w\s,=]+\) \{)";  //new
                //string trigger = @"void\s+myFunction\(int\s+\w+,\s+double\s+\w+\)";
                //string startercode = "#include <iostream>\r\n\r\n// Function to calculate factorial\r\nunsigned long long calculateFactorial(int n = 0) {\r\n    if (n <= 1) {\r\n        return 1; // Base case: factorial of 0 and 1 is 1\r\n    } else {\r\n        return n * calculateFactorial(n - 1); // Recursive case\r\n    }\r\n}\r\n\r\n\r\nint main() {\r\n    \r\n    if (num < 0) {\r\n        std::cout << \"Factorial is not defined for negative numbers.\" << std::endl;\r\n    } else {\r\n        unsigned long long factorial = calculateFactorial();\r\n        std::cout << \"Factorial of \" << num << \" is \" << factorial << std::endl;\r\n    }\r\n\r\n    return 0;\r\n}\r\n\r\n\r\n\r\n"; //new
                //string trigger = @"(main\\([\\w\\s,]+)";
                string trigger = @"(main\([\w\s,]+)\)";

                string startercode = "void myFunction(int param1, double param2) {\r\n        std::cout << param1 + param2<< std::endl;\r\n\r\n}\r\n\r\nint main() {\r\n    myFunction()\r\n    return 0;\r\n}\r\n";



                string codeText = codeBox.Text;
                cppClass cppClassObj = new cppClass(path, codeText);
                //cppClassObj.CompileCode(codeText);
                cppClassObj.compileType1(startercode, codeText, trigger, jsonArray, removingPattern);
            }




























            if (compilerComboBox1.Text == "c#")
            {
                string codeText = codeBox.Text;
                cSharpClass csharpObj = new cSharpClass(path, codeText);
                string returnValue = csharpObj.CompileCode(codeText);
                string startercode = "public class java {\r\n    public static void main(String[] args) {\r\n        int n = 5;\r\n    }\r\n}\r\n";
                //string trigger = @"^\s*int\s+n\s*=\s*5\s*;";
                string trigger = "int n = 5;";

                string returnValue2 = csharpObj.compileType1(startercode , codeText, trigger);
                outputBox.Text = returnValue2;

            }

            

        }
    }
}
