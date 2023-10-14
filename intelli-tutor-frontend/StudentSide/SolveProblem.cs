﻿using FontAwesome.Sharp;
using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.compilerClasses;
using intelli_tutor_frontend.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class SolveProblem : Form
    {
        private problemModel problem;
        private List<testCaseModel> testcaseList;

        private bool isSidebarCollapsed = false;
        private int sidebarStep = 20;
        private int originalSidebarWidth;
        private int originalMainPanelWidth;
        //private Dictionary<Control, int> originalControlLeftPositions = new Dictionary<Control, int>();
        public SolveProblem(problemModel problem)
        {
            InitializeComponent();
            loadIcons();
            this.problem = problem;
            originalSidebarWidth = sidePanel.Width;
            originalMainPanelWidth = mainPanel.Width;
            selectLanguage.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }

        private void loadCompilers()
        {
            string path = Path.Combine(Application.StartupPath, "compilersFolder");

            string[] CompilersName = Directory.GetDirectories(path);
            foreach (string compiler in CompilersName)
            {
                string displayName = Path.GetFileName(compiler);
                selectLanguage.Items.Add(displayName);
            }
        }

        private void loadStarterCode()
        {
            this.codeEditor.Text = "";
            this.codeEditor.Text = problem.startercode;
        }

        private async void SolveProblem_Load(object sender, EventArgs e)
        {
            loadCompilers();
            loadStarterCode();
            TestCasesApi testCasesApi = new TestCasesApi();
            testcaseList = await testCasesApi.getAllTestCasesData(problem.problem_id);

            questionBox.SelectionStart = questionBox.TextLength;
            questionBox.SelectionFont = new Font(questionBox.Font.FontFamily, 18, FontStyle.Bold);
            questionBox.AppendText(problem.problem_name + "\n");

            questionBox.SelectionFont = questionBox.Font;
            questionBox.AppendText(problem.description + "\n" + "\n" + "");

            int count = 1;
            foreach (var item in testcaseList)
            {
                questionBox.SelectionFont = new Font(questionBox.Font.FontFamily, 16, FontStyle.Bold);
                questionBox.AppendText("Test Case " + count + ": " + "\n" + "\n");

                questionBox.SelectionFont = new Font(questionBox.Font.FontFamily, 12, FontStyle.Bold);
                questionBox.AppendText("Input Data: ");

                questionBox.SelectionFont = questionBox.Font;
                foreach (var item1 in item.input_data)
                {
                    questionBox.AppendText(item1 + ", ");
                }
                questionBox.AppendText("\n");

                questionBox.SelectionFont = new Font(questionBox.Font.FontFamily, 12, FontStyle.Bold);
                questionBox.AppendText("Output Data: ");

                questionBox.SelectionFont = questionBox.Font;
                questionBox.AppendText(item.output_data + "\n" + "\n");

                count++;
            }

            questionBox.SelectAll();
            questionBox.SelectionBackColor = questionBox.BackColor;
            questionBox.SelectionIndent = 10;
            questionBox.SelectionRightIndent = 10;
            questionBox.SelectionStart = 0;
            questionBox.DeselectAll();
            questionBox.WordWrap = true;
        }

        public void loadIcons()
        {
            this.barIcon.Image = IconChar.Bars.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.resetCode.Image = IconChar.ArrowRightRotate.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barIcon_Click(object sender, EventArgs e)
        {
            this.sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarCollapsed)
            {
                if (sidePanel.Width < originalSidebarWidth)
                {
                    sidePanel.Width += sidebarStep;


                    tableLayoutPanel1.Controls.Clear();
                    tableLayoutPanel1.BackColor = Color.DarkSlateBlue;
                    tableLayoutPanel1.ColumnCount = 2;
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
                    tableLayoutPanel1.Controls.Add(this.barIcon, 1, 0);
                    tableLayoutPanel1.RowCount = 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tableLayoutPanel1.TabIndex = 0;
                    tableLayoutPanel1.Width += sidebarStep;

                    mainPanel.Width -= sidebarStep;
                    mainPanel.Location = new Point(mainPanel.Location.X + sidebarStep, mainPanel.Location.Y);
                }
                else
                {
                    sideBarTimer.Stop();
                    isSidebarCollapsed = false;
                }
            }
            else
            {
                if (sidePanel.Width > 100)
                {
                    sidePanel.Width -= sidebarStep;
                    mainPanel.Width += sidebarStep;

                    mainPanel.Location = new Point(mainPanel.Location.X - sidebarStep, mainPanel.Location.Y);
                }
                else
                {
                    sideBarTimer.Stop();
                    isSidebarCollapsed = true;


                }
                if (sidePanel.Width <= 100)
                {
                    tableLayoutPanel1.Controls.Clear();
                    tableLayoutPanel1.RowCount = 1;
                    tableLayoutPanel1.ColumnCount = 1;
                    tableLayoutPanel1.Controls.Add(this.barIcon);
                    tableLayoutPanel1.Width = 100;
                }
            }

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codeEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetCode_Click(object sender, EventArgs e)
        {
            loadStarterCode();
        }

        private void runProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button has been clicked");
            string path = Path.Combine(Application.StartupPath, "compilersFolder");
            //string studentCode1 = codeEditor.Text;

            //cppClass cppclassObj = new cppClass(path, studentCode1);
            //string returnval = cppclassObj.CompileCode();
            //MessageBox.Show(returnval , "this is return val");

            if (selectLanguage.Text == "c++")
            {
                 
                foreach (testCaseModel tc in testcaseList)
                {
                    string studentCode = codeEditor.Text;
                    MessageBox.Show(studentCode, path);
                    MessageBox.Show(tc.input_data[0]);
                    cppClass cppClassObj = new cppClass(path, studentCode);
                    //bool result = cppClassObj.runCode(studentCode, problem.regex, tc.input_data, tc.output_data);
                    //if (result == true)
                    //{
                    // MessageBox.Show("test case passed.");
                    // }
                   string responseStr = cppClassObj.compileWithTestCases(studentCode, problem.regex, tc.input_data, tc.output_data);

                    var jsonArray = JsonConvert.DeserializeObject<dynamic[]>(responseStr);

                    var toShow = jsonArray[0].ToString();
                    //string yourOutputValue = (string)toShow["YourOutput"];
                    //MessageBox.Show(yourOutputValue);
                }
            }
        }
    }
}