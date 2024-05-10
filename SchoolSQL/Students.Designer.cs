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
            STFirstText = new TextBox();
            STLastText = new TextBox();
            STAgeText = new TextBox();
            STGenderText = new TextBox();
            STSearchText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            STInsertBTN = new Button();
            STUpdateBTN = new Button();
            STDeleteBTN = new Button();
            STSearchBTN = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            STReturnBTN = new Button();
            STYearText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // STFirstText
            // 
            STFirstText.Location = new Point(118, 24);
            STFirstText.Name = "STFirstText";
            STFirstText.Size = new Size(355, 23);
            STFirstText.TabIndex = 0;
            // 
            // STLastText
            // 
            STLastText.Location = new Point(118, 53);
            STLastText.Name = "STLastText";
            STLastText.Size = new Size(355, 23);
            STLastText.TabIndex = 0;
            // 
            // STAgeText
            // 
            STAgeText.Location = new Point(118, 82);
            STAgeText.Name = "STAgeText";
            STAgeText.Size = new Size(355, 23);
            STAgeText.TabIndex = 0;
            // 
            // STGenderText
            // 
            STGenderText.Location = new Point(118, 111);
            STGenderText.Name = "STGenderText";
            STGenderText.Size = new Size(355, 23);
            STGenderText.TabIndex = 0;
            STGenderText.TextChanged += STGenderText_TextChanged;
            // 
            // STSearchText
            // 
            STSearchText.Location = new Point(118, 229);
            STSearchText.Name = "STSearchText";
            STSearchText.Size = new Size(216, 23);
            STSearchText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 82);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 111);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 1;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 140);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Year of Study";
            // 
            // STInsertBTN
            // 
            STInsertBTN.Location = new Point(62, 165);
            STInsertBTN.Name = "STInsertBTN";
            STInsertBTN.Size = new Size(133, 40);
            STInsertBTN.TabIndex = 2;
            STInsertBTN.Text = "Insert";
            STInsertBTN.UseVisualStyleBackColor = true;
            // 
            // STUpdateBTN
            // 
            STUpdateBTN.Location = new Point(201, 165);
            STUpdateBTN.Name = "STUpdateBTN";
            STUpdateBTN.Size = new Size(133, 40);
            STUpdateBTN.TabIndex = 2;
            STUpdateBTN.Text = "Update";
            STUpdateBTN.UseVisualStyleBackColor = true;
            // 
            // STDeleteBTN
            // 
            STDeleteBTN.Location = new Point(340, 165);
            STDeleteBTN.Name = "STDeleteBTN";
            STDeleteBTN.Size = new Size(133, 40);
            STDeleteBTN.TabIndex = 2;
            STDeleteBTN.Text = "Delete";
            STDeleteBTN.UseVisualStyleBackColor = true;
            // 
            // STSearchBTN
            // 
            STSearchBTN.Location = new Point(340, 219);
            STSearchBTN.Name = "STSearchBTN";
            STSearchBTN.Size = new Size(133, 40);
            STSearchBTN.TabIndex = 2;
            STSearchBTN.Text = "Search";
            STSearchBTN.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 229);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 1;
            label6.Text = "search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(437, 198);
            dataGridView1.TabIndex = 3;
            // 
            // STReturnBTN
            // 
            STReturnBTN.Location = new Point(201, 478);
            STReturnBTN.Name = "STReturnBTN";
            STReturnBTN.Size = new Size(133, 40);
            STReturnBTN.TabIndex = 2;
            STReturnBTN.Text = "Return";
            STReturnBTN.UseVisualStyleBackColor = true;
            // 
            // STYearText
            // 
            STYearText.Location = new Point(118, 140);
            STYearText.Name = "STYearText";
            STYearText.Size = new Size(355, 23);
            STYearText.TabIndex = 0;
            STYearText.TextChanged += STGenderText_TextChanged;
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
            Size = new Size(529, 538);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox STFirstText;
        private TextBox STLastText;
        private TextBox STAgeText;
        private TextBox STGenderText;
        private TextBox STSearchText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button STInsertBTN;
        private Button STUpdateBTN;
        private Button STDeleteBTN;
        private Button STSearchBTN;
        private Label label6;
        private DataGridView dataGridView1;
        private Button STReturnBTN;
        private TextBox STYearText;
    }
}
