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
                string trigger  = @"^\s*int\s+n\s*=\s*5\s*;";
                string returnValue2 = javaClassObj.compileType1(startercode, codeText, trigger);


                //Console.WriteLine("this is response" + returnValue);
                outputBox.Text = returnValue2;
            }

            if (compilerComboBox1.Text == "c++")
            {
                string codeText = codeBox.Text;
                cppClass cppClassObj = new cppClass();
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
