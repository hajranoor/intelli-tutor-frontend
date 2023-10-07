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
        public QuestionForm()
        {
            InitializeComponent();
        }

        string path;

        private void QuestionForm_Load(object sender, EventArgs e)
        {
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
                string returnValue = pythonObj.CompileCode();
                outputBox.Text = returnValue;
            }

            if (compilerComboBox1.Text == "java")
            {
                string codeText = codeBox.Text;
                javaClass javaClassObj = new javaClass(path, codeText);
                string returnValue = javaClassObj.CompileCode();
                Console.WriteLine("this is response" + returnValue);
                outputBox.Text = returnValue;

            }

            if (compilerComboBox1.Text == "c#")
            {
                string codeText = codeBox.Text;
                cSharpClass csharpObj = new cSharpClass(path, codeText);
                string returnValue = csharpObj.CompileCode();
                outputBox.Text = returnValue;

            }

            

        }
    }
}
