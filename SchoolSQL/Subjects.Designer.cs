namespace SchoolSQL
{
    partial class Subjects
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
            SGridView = new DataGridView();
            SSearchBTN = new Button();
            SDeleteBTN = new Button();
            TReturnBTN = new Button();
            SUpdateBTN = new Button();
            SInsertBTN = new Button();
            label6 = new Label();
            label2 = new Label();
            SSearchText = new TextBox();
            SNameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SGridView).BeginInit();
            SuspendLayout();
            // 
            // SGridView
            // 
            SGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SGridView.Location = new Point(21, 266);
            SGridView.Name = "SGridView";
            SGridView.Size = new Size(437, 198);
            SGridView.TabIndex = 36;
            // 
            // SSearchBTN
            // 
            SSearchBTN.Location = new Point(325, 220);
            SSearchBTN.Name = "SSearchBTN";
            SSearchBTN.Size = new Size(133, 40);
            SSearchBTN.TabIndex = 35;
            SSearchBTN.Text = "Search";
            SSearchBTN.UseVisualStyleBackColor = true;
            // 
            // SDeleteBTN
            // 
            SDeleteBTN.Location = new Point(325, 166);
            SDeleteBTN.Name = "SDeleteBTN";
            SDeleteBTN.Size = new Size(133, 40);
            SDeleteBTN.TabIndex = 34;
            SDeleteBTN.Text = "Delete";
            SDeleteBTN.UseVisualStyleBackColor = true;
            // 
            // TReturnBTN
            // 
            TReturnBTN.Location = new Point(186, 479);
            TReturnBTN.Name = "TReturnBTN";
            TReturnBTN.Size = new Size(133, 40);
            TReturnBTN.TabIndex = 33;
            TReturnBTN.Text = "Return";
            TReturnBTN.UseVisualStyleBackColor = true;
            // 
            // SUpdateBTN
            // 
            SUpdateBTN.Location = new Point(186, 166);
            SUpdateBTN.Name = "SUpdateBTN";
            SUpdateBTN.Size = new Size(133, 40);
            SUpdateBTN.TabIndex = 32;
            SUpdateBTN.Text = "Update";
            SUpdateBTN.UseVisualStyleBackColor = true;
            // 
            // SInsertBTN
            // 
            SInsertBTN.Location = new Point(47, 166);
            SInsertBTN.Name = "SInsertBTN";
            SInsertBTN.Size = new Size(133, 40);
            SInsertBTN.TabIndex = 31;
            SInsertBTN.Text = "Insert";
            SInsertBTN.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 230);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 30;
            label6.Text = "search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 28);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 27;
            label2.Text = "Subject Name";
            // 
            // SSearchText
            // 
            SSearchText.Location = new Point(103, 230);
            SSearchText.Name = "SSearchText";
            SSearchText.Size = new Size(216, 23);
            SSearchText.TabIndex = 24;
            // 
            // SNameText
            // 
            SNameText.Location = new Point(103, 28);
            SNameText.Name = "SNameText";
            SNameText.Size = new Size(355, 23);
            SNameText.TabIndex = 25;
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SGridView);
            Controls.Add(SSearchBTN);
            Controls.Add(SDeleteBTN);
            Controls.Add(TReturnBTN);
            Controls.Add(SUpdateBTN);
            Controls.Add(SInsertBTN);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(SSearchText);
            Controls.Add(SNameText);
            Name = "Subjects";
            Size = new Size(492, 529);
            ((System.ComponentModel.ISupportInitialize)SGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SGridView;
        private Button SSearchBTN;
        private Button SDeleteBTN;
        private Button TReturnBTN;
        private Button SUpdateBTN;
        private Button SInsertBTN;
        private Label label6;
        private Label label2;
        private TextBox SSearchText;
        private TextBox SNameText;
    }
}
