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
    }
}
