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
            this.SuspendLayout();
            // 
            // problemName
            // 
            this.problemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemName.Location = new System.Drawing.Point(12, 2);
            this.problemName.Multiline = true;
            this.problemName.Name = "problemName";
            this.problemName.Size = new System.Drawing.Size(178, 80);
            this.problemName.TabIndex = 0;
            this.problemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // questionBox
            // 
            this.questionBox.Enabled = false;
            this.questionBox.Location = new System.Drawing.Point(12, 88);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(178, 350);
            this.questionBox.TabIndex = 1;
            // 
            // compilerComboBox1
            // 
            this.compilerComboBox1.FormattingEnabled = true;
            this.compilerComboBox1.Location = new System.Drawing.Point(667, 12);
            this.compilerComboBox1.Name = "compilerComboBox1";
            this.compilerComboBox1.Size = new System.Drawing.Size(121, 21);
            this.compilerComboBox1.TabIndex = 2;
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(212, 49);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(576, 201);
            this.codeBox.TabIndex = 3;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(212, 328);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(576, 110);
            this.outputBox.TabIndex = 4;
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(686, 277);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 5;
            this.compileButton.Text = "Compile Code";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.compilerComboBox1);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.problemName);
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
    }
}