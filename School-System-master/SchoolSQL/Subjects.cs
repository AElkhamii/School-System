using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSQL
{
    public partial class Subjects : UserControl
    {
        List<Subject> subjects = new List<Subject>();

        public Subjects()
        {
            InitializeComponent();

            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Get all avilable data in the table */
            subjects = subjectsDataAcess.AvilableSubjects();

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;

        }

        /******** Return button ********/
        private void TReturnBTN_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();

            SSearchText.Clear();

            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Get all avilable data in the table */
            subjects = subjectsDataAcess.AvilableSubjects();

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;
        }

        /******** Search button ********/
        private void SSearchBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Get resurch result data */
            subjects = subjectsDataAcess.GetSubjects(SSearchText.Text);

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;
        }

        /******** Insert button ********/
        private void SInsertBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Insert New Subject */
            subjectsDataAcess.InsertSubject(SNameText.Text);

            /* Get all avilable data in the table */
            subjects = subjectsDataAcess.AvilableSubjects();

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;

            /* Clear text content */
            SNameText.Clear();
        }

        /******** Delete button ********/
        private void SDeleteBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Delete Selected Subject from grid view Subject */
            subjectsDataAcess.DeleteSubject(SGridView.CurrentRow.Cells[0].Value.ToString());

            /* Get all avilable data in the table */
            subjects = subjectsDataAcess.AvilableSubjects();

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;

            /* Clear text content */
            SNameText.Clear();
        }

        private void SUpdateBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of Subject Data Access */
            SubjectsDataAcess subjectsDataAcess = new SubjectsDataAcess();

            /* Delete Selected Subject from grid view Subject */
            subjectsDataAcess.UpdateSubjectInfo(SGridView.CurrentRow.Cells[0].Value.ToString(), SNameText.Text);

            /* Get all avilable data in the table */
            subjects = subjectsDataAcess.AvilableSubjects();

            /* Show the data on the grid view */
            SGridView.DataSource = subjects;

            /* Clear text content */
            SNameText.Clear();
        }
    }
}
