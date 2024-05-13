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
        /* Creat a list of students to present the result of any operation occure in studentsDataAccess calss */
        List<Student> students = new List<Student>();

        public Students()
        {
            InitializeComponent();
            STGridView.DataSource = students;
        }


        private void STSearchBTN_Click(object sender, EventArgs e)
        {
            /* Creat ana instance of studentsDataAccess */
            StudentsDataAccess studentsDataAccess = new StudentsDataAccess();

            /* Get the search result and recive it in an list of students */
            students = studentsDataAccess.GetStudents(STSearchText.Text);

            STGridView.DataSource = students;
        }

        private void STReturnBTN_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();
        }
    }
}
