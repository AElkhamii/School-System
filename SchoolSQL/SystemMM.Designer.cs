namespace SchoolSQL
{
    partial class SystemMM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TeachersBTN = new Button();
            StudentsBTN = new Button();
            SubjectsBTN = new Button();
            MainLable = new Label();
            SuspendLayout();
            // 
            // TeachersBTN
            // 
            TeachersBTN.Location = new Point(225, 202);
            TeachersBTN.Name = "TeachersBTN";
            TeachersBTN.Size = new Size(190, 41);
            TeachersBTN.TabIndex = 0;
            TeachersBTN.Text = "Teachers";
            TeachersBTN.UseVisualStyleBackColor = true;
            TeachersBTN.UseWaitCursor = true;
            // 
            // StudentsBTN
            // 
            StudentsBTN.Location = new Point(225, 264);
            StudentsBTN.Name = "StudentsBTN";
            StudentsBTN.Size = new Size(190, 41);
            StudentsBTN.TabIndex = 0;
            StudentsBTN.Text = "Students";
            StudentsBTN.UseVisualStyleBackColor = true;
            StudentsBTN.UseWaitCursor = true;
            // 
            // SubjectsBTN
            // 
            SubjectsBTN.Location = new Point(225, 325);
            SubjectsBTN.Name = "SubjectsBTN";
            SubjectsBTN.Size = new Size(190, 41);
            SubjectsBTN.TabIndex = 0;
            SubjectsBTN.Text = "Subjects";
            SubjectsBTN.UseVisualStyleBackColor = true;
            SubjectsBTN.UseWaitCursor = true;
            // 
            // MainLable
            // 
            MainLable.AutoSize = true;
            MainLable.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainLable.Location = new Point(209, 104);
            MainLable.Name = "MainLable";
            MainLable.Size = new Size(226, 54);
            MainLable.TabIndex = 1;
            MainLable.Text = "Main Menu";
            MainLable.TextAlign = ContentAlignment.TopCenter;
            MainLable.UseWaitCursor = true;
            // 
            // SystemMM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 550);
            Controls.Add(MainLable);
            Controls.Add(SubjectsBTN);
            Controls.Add(StudentsBTN);
            Controls.Add(TeachersBTN);
            Name = "SystemMM";
            Text = "SystemMM";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TeachersBTN;
        private Button StudentsBTN;
        private Button SubjectsBTN;
        private Label MainLable;
    }
}
