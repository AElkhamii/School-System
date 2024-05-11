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
            TGridView = new DataGridView();
            RAverageBTN = new Button();
            RSearchByTeacherBTN = new Button();
            TReturnBTN = new Button();
            RSearchBySubjectBTN = new Button();
            RSearchByStudentBTN = new Button();
            RSearchText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TGridView).BeginInit();
            SuspendLayout();
            // 
            // TGridView
            // 
            TGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TGridView.Location = new Point(3, 207);
            TGridView.Name = "TGridView";
            TGridView.Size = new Size(479, 267);
            TGridView.TabIndex = 37;
            // 
            // RAverageBTN
            // 
            RAverageBTN.Location = new Point(315, 152);
            RAverageBTN.Name = "RAverageBTN";
            RAverageBTN.Size = new Size(133, 40);
            RAverageBTN.TabIndex = 36;
            RAverageBTN.Text = "Average";
            RAverageBTN.UseVisualStyleBackColor = true;
            // 
            // RSearchByTeacherBTN
            // 
            RSearchByTeacherBTN.Location = new Point(315, 108);
            RSearchByTeacherBTN.Name = "RSearchByTeacherBTN";
            RSearchByTeacherBTN.Size = new Size(133, 40);
            RSearchByTeacherBTN.TabIndex = 35;
            RSearchByTeacherBTN.Text = "Search By Teacher";
            RSearchByTeacherBTN.UseVisualStyleBackColor = true;
            // 
            // TReturnBTN
            // 
            TReturnBTN.Location = new Point(176, 480);
            TReturnBTN.Name = "TReturnBTN";
            TReturnBTN.Size = new Size(133, 40);
            TReturnBTN.TabIndex = 34;
            TReturnBTN.Text = "Return";
            TReturnBTN.UseVisualStyleBackColor = true;
            // 
            // RSearchBySubjectBTN
            // 
            RSearchBySubjectBTN.Location = new Point(315, 66);
            RSearchBySubjectBTN.Name = "RSearchBySubjectBTN";
            RSearchBySubjectBTN.Size = new Size(133, 40);
            RSearchBySubjectBTN.TabIndex = 33;
            RSearchBySubjectBTN.Text = "Search By Subject";
            RSearchBySubjectBTN.UseVisualStyleBackColor = true;
            // 
            // RSearchByStudentBTN
            // 
            RSearchByStudentBTN.Location = new Point(315, 24);
            RSearchByStudentBTN.Name = "RSearchByStudentBTN";
            RSearchByStudentBTN.Size = new Size(133, 40);
            RSearchByStudentBTN.TabIndex = 32;
            RSearchByStudentBTN.Text = "Search By Student";
            RSearchByStudentBTN.UseVisualStyleBackColor = true;
            // 
            // RSearchText
            // 
            RSearchText.Font = new Font("Segoe UI", 16F);
            RSearchText.Location = new Point(3, 91);
            RSearchText.Name = "RSearchText";
            RSearchText.Size = new Size(306, 36);
            RSearchText.TabIndex = 26;
            // 
            // Relations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TGridView);
            Controls.Add(RAverageBTN);
            Controls.Add(RSearchByTeacherBTN);
            Controls.Add(TReturnBTN);
            Controls.Add(RSearchBySubjectBTN);
            Controls.Add(RSearchByStudentBTN);
            Controls.Add(RSearchText);
            Name = "Relations";
            Size = new Size(485, 541);
            ((System.ComponentModel.ISupportInitialize)TGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TGridView;
        private Button RAverageBTN;
        private Button RSearchByTeacherBTN;
        private Button TReturnBTN;
        private Button RSearchBySubjectBTN;
        private Button RSearchByStudentBTN;
        private Label label6;
        private TextBox TSearchText;
        private TextBox TSubjectIDText;
        private TextBox TAgeText;
        private TextBox RSearchText;
        private TextBox TFirstText;
    }
}
