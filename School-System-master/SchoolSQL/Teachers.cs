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
    public partial class Teachers : UserControl
    {
        /* Creat a list of teachers to present the result of any operation occures on teachersDataAccess calss */
        List<Teacher> teachers = new List<Teacher>();

        public Teachers()
        {
            InitializeComponent();

            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Get the rsult of all avilable teachers */
            teachers = teachersDataAccess.AvilableTeachers();

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }


        /******** Return button ********/
        private void TReturnBTN_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();

            TSearchText.Clear();

            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Get the rsult of all avilable teachers */
            teachers = teachersDataAccess.AvilableTeachers();

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }


        /******** Search button ********/
        private void TSearchBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Get resurch result data */
            teachers = teachersDataAccess.GetTeachers(TSearchText.Text);

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }

        /******** Inser button ********/
        private void TInsertBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Insert new Teacher */
            teachersDataAccess.InsertTeacher(TFirstText.Text, TLastText.Text, TAgeText.Text, TSubjectIDText.Text);

            /* Get the rsult of all avilable teachers */
            teachers = teachersDataAccess.AvilableTeachers();

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }

        /******** Delete button ********/
        private void TDeleteBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Delete a teacher */
            teachersDataAccess.DeleteTeachers(TGridView.CurrentRow.Cells[0].Value.ToString());

            /* Get the rsult of all avilable teachers */
            teachers = teachersDataAccess.AvilableTeachers();

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }

        /******** Update button ********/
        private void TUpdateBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance of teachers Data Access */
            TeachersDataAccess teachersDataAccess = new TeachersDataAccess();

            /* Updata teacher info */
            teachersDataAccess.UpdateTeacherInfo(TGridView.CurrentRow.Cells[0].Value.ToString(), TFirstText.Text, TLastText.Text, TAgeText.Text, TSubjectIDText.Text);

            /* Get the rsult of all avilable teachers */
            teachers = teachersDataAccess.AvilableTeachers();

            /* Show the result on the grid view */
            TGridView.DataSource = teachers;
        }

        private void TGridView_SelectionChanged(object sender, EventArgs e)
        {
            TFirstText.Text = TGridView.CurrentRow.Cells[1].Value.ToString();
            TLastText.Text = TGridView.CurrentRow.Cells[2].Value.ToString();
            TAgeText.Text = TGridView.CurrentRow.Cells[3].Value.ToString();
            TSubjectIDText.Text = TGridView.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
