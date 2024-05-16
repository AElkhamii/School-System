using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSQL
{
    public partial class Relations : UserControl
    {

        public Relations()
        {
            InitializeComponent();

            /* Creat an instance from RelationsDataAccess */
            RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

            /* Get all avilable relation data and present the result on the grid view */
            RGridView.DataSource = relationsDataAcess.GetAllAvilableRelations();
        }


        /* Returen button */
        private void Button5_Click(object sender, EventArgs e)
        {
            /* Return to the main menue */
            this.Hide();

            RSearchText.Clear();

            /* Creat an instance from RelationsDataAccess */
            RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

            /* Get all avilable relation data and present the result on the grid view */
            RGridView.DataSource = relationsDataAcess.GetAllAvilableRelations();
        }

        /* Search by student Button */
        private void RStudentBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance from RelationsDataAccess */
            RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

            /* Get all avilable relation data that related to selected student and present the result on the grid view */
            RGridView.DataSource = relationsDataAcess.SearchByStudent(RSearchText.Text);
        }

        /* Search by teacher Button */
        private void RTeacherBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance from RelationsDataAccess */
            RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

            /* Get all avilable relation data that related to selected Teacher and present the result on the grid view */
            RGridView.DataSource = relationsDataAcess.SearchByTeacher(RSearchText.Text);
        }

        /* Search by subject Button */
        private void RSubjectBTN_Click(object sender, EventArgs e)
        {
            /* Creat an instance from RelationsDataAccess */
            RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

            /* Get all avilable relation data that related to selected Teacher and present the result on the grid view */
            RGridView.DataSource = relationsDataAcess.SearchBySubject(RSearchText.Text);
        }

        /* Calculate average degree */
        private void RAverageBTN_Click(object sender, EventArgs e)
        {
            try
            {
                /* Creat an instance from RelationsDataAccess */
                RelationsDataAccess relationsDataAcess = new RelationsDataAccess();

                /* Calculate average degree for selected student */
                RGridView.DataSource = relationsDataAcess.CalculateAverage(RSearchText.Text);
            }
            catch
            {
                MessageBox.Show("Enter only an ID number");
            }
        }
    }
}
