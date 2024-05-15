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
            MMTeachersBTN = new Button();
            MMStudentsBTN = new Button();
            MMSubjectsBTN = new Button();
            MainLable = new Label();
            MMRelationBTN = new Button();
            MMExitBTN = new Button();
            teachers1 = new Teachers();
            students1 = new Students();
            subjects1 = new Subjects();
            relations1 = new Relations();
            SuspendLayout();
            // 
            // MMTeachersBTN
            // 
            MMTeachersBTN.Location = new Point(222, 143);
            MMTeachersBTN.Name = "MMTeachersBTN";
            MMTeachersBTN.Size = new Size(190, 41);
            MMTeachersBTN.TabIndex = 0;
            MMTeachersBTN.Text = "Teachers";
            MMTeachersBTN.UseVisualStyleBackColor = true;
            MMTeachersBTN.UseWaitCursor = true;
            MMTeachersBTN.Click += MMTeachersBTN_Click;
            // 
            // MMStudentsBTN
            // 
            MMStudentsBTN.Location = new Point(222, 205);
            MMStudentsBTN.Name = "MMStudentsBTN";
            MMStudentsBTN.Size = new Size(190, 41);
            MMStudentsBTN.TabIndex = 0;
            MMStudentsBTN.Text = "Students";
            MMStudentsBTN.UseVisualStyleBackColor = true;
            MMStudentsBTN.UseWaitCursor = true;
            MMStudentsBTN.Click += MMStudentsBTN_Click;
            // 
            // MMSubjectsBTN
            // 
            MMSubjectsBTN.Location = new Point(222, 266);
            MMSubjectsBTN.Name = "MMSubjectsBTN";
            MMSubjectsBTN.Size = new Size(190, 41);
            MMSubjectsBTN.TabIndex = 0;
            MMSubjectsBTN.Text = "Subjects";
            MMSubjectsBTN.UseVisualStyleBackColor = true;
            MMSubjectsBTN.UseWaitCursor = true;
            MMSubjectsBTN.Click += MMSubjectsBTN_Click;
            // 
            // MainLable
            // 
            MainLable.AutoSize = true;
            MainLable.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainLable.Location = new Point(205, 45);
            MainLable.Name = "MainLable";
            MainLable.Size = new Size(226, 54);
            MainLable.TabIndex = 1;
            MainLable.Text = "Main Menu";
            MainLable.TextAlign = ContentAlignment.TopCenter;
            MainLable.UseWaitCursor = true;
            // 
            // MMRelationBTN
            // 
            MMRelationBTN.Location = new Point(222, 331);
            MMRelationBTN.Name = "MMRelationBTN";
            MMRelationBTN.Size = new Size(190, 41);
            MMRelationBTN.TabIndex = 0;
            MMRelationBTN.Text = "Relations";
            MMRelationBTN.UseVisualStyleBackColor = true;
            MMRelationBTN.UseWaitCursor = true;
            MMRelationBTN.Click += MMRelationBTN_Click;
            // 
            // MMExitBTN
            // 
            MMExitBTN.Location = new Point(222, 432);
            MMExitBTN.Name = "MMExitBTN";
            MMExitBTN.Size = new Size(190, 41);
            MMExitBTN.TabIndex = 0;
            MMExitBTN.Text = "Exit";
            MMExitBTN.UseVisualStyleBackColor = true;
            MMExitBTN.UseWaitCursor = true;
            MMExitBTN.Click += MMExitBTN_Click;
            // 
            // teachers1
            // 
            teachers1.Location = new Point(58, 2);
            teachers1.Name = "teachers1";
            teachers1.Size = new Size(509, 536);
            teachers1.TabIndex = 2;
            teachers1.UseWaitCursor = true;
            // 
            // students1
            // 
            students1.Location = new Point(86, 12);
            students1.Name = "students1";
            students1.Size = new Size(469, 518);
            students1.TabIndex = 3;
            students1.UseWaitCursor = true;
            // 
            // subjects1
            // 
            subjects1.Location = new Point(70, 12);
            subjects1.Name = "subjects1";
            subjects1.Size = new Size(497, 528);
            subjects1.TabIndex = 4;
            subjects1.UseWaitCursor = true;
            // 
            // relations1
            // 
            relations1.Location = new Point(58, 13);
            relations1.Name = "relations1";
            relations1.Size = new Size(485, 527);
            relations1.TabIndex = 5;
            relations1.UseWaitCursor = true;
            // 
            // SystemMM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 550);
            Controls.Add(relations1);
            Controls.Add(subjects1);
            Controls.Add(students1);
            Controls.Add(teachers1);
            Controls.Add(MainLable);
            Controls.Add(MMExitBTN);
            Controls.Add(MMRelationBTN);
            Controls.Add(MMSubjectsBTN);
            Controls.Add(MMStudentsBTN);
            Controls.Add(MMTeachersBTN);
            Name = "SystemMM";
            Text = "SystemMM";
            UseWaitCursor = true;
            Load += SystemMM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MMTeachersBTN;
        private Button MMStudentsBTN;
        private Button MMSubjectsBTN;
        private Label MainLable;
        private Button MMRelationBTN;
        private Button MMExitBTN;
        private Teachers teachers1;
        private Students students1;
        private Subjects subjects1;
        private Relations relations1;
    }
}
