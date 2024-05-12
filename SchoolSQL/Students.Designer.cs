namespace SchoolSQL
{
    partial class Students
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
            dataGridView1 = new DataGridView();
            STSearchBTN = new Button();
            STDeleteBTN = new Button();
            STReturnBTN = new Button();
            STUpdateBTN = new Button();
            STInsertBTN = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            STSearchText = new TextBox();
            STYearText = new TextBox();
            STGenderText = new TextBox();
            STAgeText = new TextBox();
            STLastText = new TextBox();
            STFirstText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(437, 198);
            dataGridView1.TabIndex = 21;
            // 
            // STSearchBTN
            // 
            STSearchBTN.Location = new Point(317, 217);
            STSearchBTN.Name = "STSearchBTN";
            STSearchBTN.Size = new Size(133, 40);
            STSearchBTN.TabIndex = 20;
            STSearchBTN.Text = "Search";
            STSearchBTN.UseVisualStyleBackColor = true;
            // 
            // STDeleteBTN
            // 
            STDeleteBTN.Location = new Point(317, 163);
            STDeleteBTN.Name = "STDeleteBTN";
            STDeleteBTN.Size = new Size(133, 40);
            STDeleteBTN.TabIndex = 19;
            STDeleteBTN.Text = "Delete";
            STDeleteBTN.UseVisualStyleBackColor = true;
            // 
            // STReturnBTN
            // 
            STReturnBTN.Location = new Point(178, 467);
            STReturnBTN.Name = "STReturnBTN";
            STReturnBTN.Size = new Size(133, 40);
            STReturnBTN.TabIndex = 18;
            STReturnBTN.Text = "Return";
            STReturnBTN.UseVisualStyleBackColor = true;
            STReturnBTN.Click += STReturnBTN_Click;
            // 
            // STUpdateBTN
            // 
            STUpdateBTN.Location = new Point(178, 163);
            STUpdateBTN.Name = "STUpdateBTN";
            STUpdateBTN.Size = new Size(133, 40);
            STUpdateBTN.TabIndex = 17;
            STUpdateBTN.Text = "Update";
            STUpdateBTN.UseVisualStyleBackColor = true;
            // 
            // STInsertBTN
            // 
            STInsertBTN.Location = new Point(39, 163);
            STInsertBTN.Name = "STInsertBTN";
            STInsertBTN.Size = new Size(133, 40);
            STInsertBTN.TabIndex = 16;
            STInsertBTN.Text = "Insert";
            STInsertBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 138);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 14;
            label5.Text = "Year of Study";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 227);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 109);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 80);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // STSearchText
            // 
            STSearchText.Location = new Point(95, 227);
            STSearchText.Name = "STSearchText";
            STSearchText.Size = new Size(216, 23);
            STSearchText.TabIndex = 8;
            // 
            // STYearText
            // 
            STYearText.Location = new Point(95, 138);
            STYearText.Name = "STYearText";
            STYearText.Size = new Size(355, 23);
            STYearText.TabIndex = 7;
            // 
            // STGenderText
            // 
            STGenderText.Location = new Point(95, 109);
            STGenderText.Name = "STGenderText";
            STGenderText.Size = new Size(355, 23);
            STGenderText.TabIndex = 6;
            // 
            // STAgeText
            // 
            STAgeText.Location = new Point(95, 80);
            STAgeText.Name = "STAgeText";
            STAgeText.Size = new Size(355, 23);
            STAgeText.TabIndex = 5;
            // 
            // STLastText
            // 
            STLastText.Location = new Point(95, 51);
            STLastText.Name = "STLastText";
            STLastText.Size = new Size(355, 23);
            STLastText.TabIndex = 9;
            // 
            // STFirstText
            // 
            STFirstText.Location = new Point(95, 22);
            STFirstText.Name = "STFirstText";
            STFirstText.Size = new Size(355, 23);
            STFirstText.TabIndex = 4;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(STSearchBTN);
            Controls.Add(STDeleteBTN);
            Controls.Add(STReturnBTN);
            Controls.Add(STUpdateBTN);
            Controls.Add(STInsertBTN);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(STSearchText);
            Controls.Add(STYearText);
            Controls.Add(STGenderText);
            Controls.Add(STAgeText);
            Controls.Add(STLastText);
            Controls.Add(STFirstText);
            Name = "Students";
            Size = new Size(472, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button STSearchBTN;
        private Button STDeleteBTN;
        private Button STReturnBTN;
        private Button STUpdateBTN;
        private Button STInsertBTN;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox STSearchText;
        private TextBox STYearText;
        private TextBox STGenderText;
        private TextBox STAgeText;
        private TextBox STLastText;
        private TextBox STFirstText;
    }
}
