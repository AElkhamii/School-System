namespace SchoolSQL
{
    partial class Relations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RStudentBTN = new Button();
            RTeacherBTN = new Button();
            RSubjectBTN = new Button();
            RAverageBTN = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RStudentBTN
            // 
            RStudentBTN.Location = new Point(314, 5);
            RStudentBTN.Name = "RStudentBTN";
            RStudentBTN.Size = new Size(129, 39);
            RStudentBTN.TabIndex = 0;
            RStudentBTN.Text = "Search By Student";
            RStudentBTN.UseVisualStyleBackColor = true;
            // 
            // RTeacherBTN
            // 
            RTeacherBTN.Location = new Point(314, 50);
            RTeacherBTN.Name = "RTeacherBTN";
            RTeacherBTN.Size = new Size(129, 39);
            RTeacherBTN.TabIndex = 0;
            RTeacherBTN.Text = "Search By Teacher";
            RTeacherBTN.UseVisualStyleBackColor = true;
            // 
            // RSubjectBTN
            // 
            RSubjectBTN.Location = new Point(314, 95);
            RSubjectBTN.Name = "RSubjectBTN";
            RSubjectBTN.Size = new Size(129, 39);
            RSubjectBTN.TabIndex = 0;
            RSubjectBTN.Text = "Search By Subject";
            RSubjectBTN.UseVisualStyleBackColor = true;
            // 
            // RAverageBTN
            // 
            RAverageBTN.Location = new Point(314, 140);
            RAverageBTN.Name = "RAverageBTN";
            RAverageBTN.Size = new Size(129, 39);
            RAverageBTN.TabIndex = 0;
            RAverageBTN.Text = "Average";
            RAverageBTN.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(165, 460);
            button5.Name = "button5";
            button5.Size = new Size(129, 39);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 263);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(14, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 36);
            textBox1.TabIndex = 2;
            // 
            // Relations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(RAverageBTN);
            Controls.Add(RSubjectBTN);
            Controls.Add(RTeacherBTN);
            Controls.Add(RStudentBTN);
            Name = "Relations";
            Size = new Size(458, 510);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RStudentBTN;
        private Button RTeacherBTN;
        private Button RSubjectBTN;
        private Button RAverageBTN;
        private Button button5;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}
