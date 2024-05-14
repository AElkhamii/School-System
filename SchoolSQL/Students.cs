using System;
using System.Buffers;
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
    public partial class Students : UserControl
    {
        /* Creat a list of students to present the result of any operation occures on studentsDataAccess calss */
        List<Student> students = new List<Student>();


        public Students()
        {
            InitializeComponent();
            /* Initiate student grid view with empty table of students */
            STGridView.DataSource = students;
        }



        /*********** Insert button ***********/
        private void STInsertBTN_Click(object sender, EventArgs e)
        {
            /* Creat ana instance of studentsDataAccess */
            StudentsDataAccess studentsDataAccess = new StudentsDataAccess();

            /* Insert new student */
            studentsDataAccess.InsertStudent(STFirstText.Text, STLastText.Text, STAgeText.Text, STGenderText.Text, STYearText.Text);

            STFirstText.Clear();
            STLastText.Clear();
            STAgeText.Clear();
            STGenderText.Clear();
            STYearText.Clear();
        }



        /*********** Delete button ***********/
        private void STDeleteBTN_Click(object sender, EventArgs e)
        {
            /* Creat ana instance of studentsDataAccess */
            StudentsDataAccess studentsDataAccess = new StudentsDataAccess();

            /* Delete Student From the table */
            studentsDataAccess.DeleteStudent(STGridView.CurrentRow.Cells[0].Value.ToString());

            /* Show the search result on Studnt Grid view */
            STGridView.DataSource = students;
        }



        /*********** Update button ***********/
        private void STUpdateBTN_Click(object sender, EventArgs e)
        {
            /* Creat ana instance of studentsDataAccess */
            StudentsDataAccess studentsDataAccess = new StudentsDataAccess();

            /* Update student INFO */
            studentsDataAccess.UpdateStudentInfo(STGridView.CurrentRow.Cells[0].Value.ToString(), STFirstText.Text, STLastText.Text, STAgeText.Text, STGenderText.Text, STYearText.Text);

            /* Show the search result on Studnt Grid view */
            STGridView.DataSource = students;
        }



        /*********** Search Button ***********/
        private void STSearchBTN_Click(object sender, EventArgs e)
        {
            /* Creat ana instance of studentsDataAccess */
            StudentsDataAccess studentsDataAccess = new StudentsDataAccess();

            /* Get the search result and recive it in an list of students */
            students = studentsDataAccess.GetStudents(STSearchText.Text);

            /* Show the search result on Studnt Grid view */
            STGridView.DataSource = students;
        }



        /*********** Return button ***********/
        private void STReturnBTN_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();
            STSearchText.Clear();
            STGridView.DataSource = students;

        }



        private void STGridView_SelectionChanged(object sender, EventArgs e)
        {
            STFirstText.Text = STGridView.CurrentRow.Cells[1].Value.ToString();
            STLastText.Text = STGridView.CurrentRow.Cells[2].Value.ToString();
            STAgeText.Text = STGridView.CurrentRow.Cells[3].Value.ToString();
            STGenderText.Text = STGridView.CurrentRow.Cells[4].Value.ToString();
            STYearText.Text = STGridView.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
