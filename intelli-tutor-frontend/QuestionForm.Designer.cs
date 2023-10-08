namespace intelli_tutor_frontend
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.problemName = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.compilerComboBox1 = new System.Windows.Forms.ComboBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.SuspendLayout();
            // 
            // problemName
            // 
            this.problemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemName.Location = new System.Drawing.Point(16, 2);
            this.problemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.problemName.Multiline = true;
            this.problemName.Name = "problemName";
            this.problemName.Size = new System.Drawing.Size(236, 98);
            this.problemName.TabIndex = 0;
            this.problemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // questionBox
            // 
            this.questionBox.Enabled = false;
            this.questionBox.Location = new System.Drawing.Point(16, 108);
            this.questionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(236, 430);
            this.questionBox.TabIndex = 1;
            // 
            // compilerComboBox1
            // 
            this.compilerComboBox1.FormattingEnabled = true;
            this.compilerComboBox1.Location = new System.Drawing.Point(889, 15);
            this.compilerComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compilerComboBox1.Name = "compilerComboBox1";
            this.compilerComboBox1.Size = new System.Drawing.Size(160, 24);
            this.compilerComboBox1.TabIndex = 2;
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(283, 60);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(767, 246);
            this.codeBox.TabIndex = 3;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(283, 404);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(767, 134);
            this.outputBox.TabIndex = 4;
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(915, 341);
            this.compileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(100, 28);
            this.compileButton.TabIndex = 5;
            this.compileButton.Text = "Compile Code";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.compilerComboBox1);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.problemName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox problemName;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.ComboBox compilerComboBox1;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button compileButton;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
    }
}