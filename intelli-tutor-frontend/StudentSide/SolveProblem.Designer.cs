namespace intelli_tutor_frontend.StudentSide
{
    partial class SolveProblem
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
            this.components = new System.ComponentModel.Container();
            this.sidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.barIcon = new System.Windows.Forms.PictureBox();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.runProgram = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectLanguage = new System.Windows.Forms.ComboBox();
            this.resetCode = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.codeEditor = new ScintillaNET.Scintilla();
            this.sidePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barIcon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetCode)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.sidePanel.Controls.Add(this.questionBox, 0, 1);
            this.sidePanel.Controls.Add(this.tableLayoutPanel1);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.RowCount = 2;
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidePanel.Size = new System.Drawing.Size(420, 750);
            this.sidePanel.TabIndex = 1;
            // 
            // questionBox
            // 
            this.questionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.questionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionBox.Location = new System.Drawing.Point(8, 114);
            this.questionBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(404, 629);
            this.questionBox.TabIndex = 9;
            this.questionBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.barIcon, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 107);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barIcon
            // 
            this.barIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barIcon.Location = new System.Drawing.Point(339, 2);
            this.barIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barIcon.Name = "barIcon";
            this.barIcon.Size = new System.Drawing.Size(78, 103);
            this.barIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barIcon.TabIndex = 2;
            this.barIcon.TabStop = false;
            this.barIcon.Click += new System.EventHandler(this.barIcon_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.runProgram, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(897, 100);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(150, 100);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runProgram
            // 
            this.runProgram.BackColor = System.Drawing.Color.Lavender;
            this.runProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.runProgram.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runProgram.Location = new System.Drawing.Point(702, 20);
            this.runProgram.Margin = new System.Windows.Forms.Padding(20, 20, 40, 20);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(155, 60);
            this.runProgram.TabIndex = 4;
            this.runProgram.Text = "Run ";
            this.runProgram.UseVisualStyleBackColor = false;
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectLanguage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.resetCode, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 107);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(137, 107);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectLanguage
            // 
            this.selectLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectLanguage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLanguage.ItemHeight = 36;
            this.selectLanguage.Location = new System.Drawing.Point(531, 37);
            this.selectLanguage.Margin = new System.Windows.Forms.Padding(4, 37, 53, 4);
            this.selectLanguage.Name = "selectLanguage";
            this.selectLanguage.Size = new System.Drawing.Size(319, 44);
            this.selectLanguage.TabIndex = 3;
            // 
            // resetCode
            // 
            this.resetCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetCode.Location = new System.Drawing.Point(392, 4);
            this.resetCode.Margin = new System.Windows.Forms.Padding(4);
            this.resetCode.Name = "resetCode";
            this.resetCode.Size = new System.Drawing.Size(108, 99);
            this.resetCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resetCode.TabIndex = 4;
            this.resetCode.TabStop = false;
            this.resetCode.Click += new System.EventHandler(this.resetCode_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 903F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.tableLayoutPanel2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.mainPanel.Controls.Add(this.outputBox, 0, 3);
            this.mainPanel.Controls.Add(this.codeEditor, 0, 1);
            this.mainPanel.Location = new System.Drawing.Point(427, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainPanel.Size = new System.Drawing.Size(903, 750);
            this.mainPanel.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputBox.Location = new System.Drawing.Point(8, 542);
            this.outputBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(887, 201);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // codeEditor
            // 
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.Lexer = ScintillaNET.Lexer.Cpp;
            this.codeEditor.Location = new System.Drawing.Point(8, 114);
            this.codeEditor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(887, 307);
            this.codeEditor.TabIndex = 8;
            this.codeEditor.Text = "scintilla1";
            this.codeEditor.TextChanged += new System.EventHandler(this.codeEditor_TextChanged);
            // 
            // SolveProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1331, 746);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1346, 713);
            this.Name = "SolveProblem";
            this.Text = "SolveProblem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SolveProblem_Load);
            this.sidePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barIcon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetCode)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sidePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox barIcon;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button runProgram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox questionBox;
        private System.Windows.Forms.ComboBox selectLanguage;
        private System.Windows.Forms.PictureBox resetCode;
        private ScintillaNET.Scintilla codeEditor;
    }
}