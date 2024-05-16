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
            RReturnBTN = new Button();
            RGridView = new DataGridView();
            RSearchText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RGridView).BeginInit();
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
            RStudentBTN.Click += RStudentBTN_Click;
            // 
            // RTeacherBTN
            // 
            RTeacherBTN.Location = new Point(314, 50);
            RTeacherBTN.Name = "RTeacherBTN";
            RTeacherBTN.Size = new Size(129, 39);
            RTeacherBTN.TabIndex = 0;
            RTeacherBTN.Text = "Search By Teacher";
            RTeacherBTN.UseVisualStyleBackColor = true;
            RTeacherBTN.Click += RTeacherBTN_Click;
            // 
            // RSubjectBTN
            // 
            RSubjectBTN.Location = new Point(314, 95);
            RSubjectBTN.Name = "RSubjectBTN";
            RSubjectBTN.Size = new Size(129, 39);
            RSubjectBTN.TabIndex = 0;
            RSubjectBTN.Text = "Search By Subject";
            RSubjectBTN.UseVisualStyleBackColor = true;
            RSubjectBTN.Click += RSubjectBTN_Click;
            // 
            // RAverageBTN
            // 
            RAverageBTN.Location = new Point(314, 140);
            RAverageBTN.Name = "RAverageBTN";
            RAverageBTN.Size = new Size(129, 39);
            RAverageBTN.TabIndex = 0;
            RAverageBTN.Text = "Average";
            RAverageBTN.UseVisualStyleBackColor = true;
            RAverageBTN.Click += RAverageBTN_Click;
            // 
            // RReturnBTN
            // 
            RReturnBTN.Location = new Point(165, 460);
            RReturnBTN.Name = "RReturnBTN";
            RReturnBTN.Size = new Size(129, 39);
            RReturnBTN.TabIndex = 0;
            RReturnBTN.Text = "Return";
            RReturnBTN.UseVisualStyleBackColor = true;
            RReturnBTN.Click += Button5_Click;
            // 
            // RGridView
            // 
            RGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RGridView.Location = new Point(3, 191);
            RGridView.Name = "RGridView";
            RGridView.Size = new Size(452, 263);
            RGridView.TabIndex = 1;
            // 
            // RSearchText
            // 
            RSearchText.Font = new Font("Segoe UI", 16F);
            RSearchText.Location = new Point(14, 73);
            RSearchText.Name = "RSearchText";
            RSearchText.Size = new Size(294, 36);
            RSearchText.TabIndex = 2;
            // 
            // Relations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RSearchText);
            Controls.Add(RGridView);
            Controls.Add(RReturnBTN);
            Controls.Add(RAverageBTN);
            Controls.Add(RSubjectBTN);
            Controls.Add(RTeacherBTN);
            Controls.Add(RStudentBTN);
            Name = "Relations";
            Size = new Size(458, 510);
            ((System.ComponentModel.ISupportInitialize)RGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RStudentBTN;
        private Button RTeacherBTN;
        private Button RSubjectBTN;
        private Button RAverageBTN;
        private Button RReturnBTN;
        private DataGridView RGridView;
        private TextBox RSearchText;
    }
}
