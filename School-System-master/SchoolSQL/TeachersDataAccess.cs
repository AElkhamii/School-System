using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class TeachersDataAccess
    {
        /* Method to return all avilable Teachers */
        public List<Teacher> AvilableTeachers()
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Ask the SchoolSystemDB for a query to get back all avilable Teacher data type and set the result to a list of teacher (.ToList()) to return with the result list that will be displaied on gridview  */
                return connection.Query<Teacher>($"SELECT * FROM Teachers ").ToList();
            }
        }


        /* Method to return the search value from Teacher table */
        public List<Teacher> GetTeachers(string SearchValue)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Ask the SchoolSystemDB for a query to get a data back teacher data type and set the result to a list of teacher (.ToList()) to return with the result list that will be displaied on gridview  */
                return connection.Query<Teacher>($"SELECT * FROM Teachers WHERE (FirstName LIKE '%{SearchValue}%' OR LastName LIKE '%{SearchValue}%' OR TeacherID LIKE '%{SearchValue}%' OR TeachSubjectID_FK LIKE '%{SearchValue}%')").ToList();
            }
        }

        /* Method to insert a new Teacher into the table */
        public void InsertTeacher(string firstName, string lastName, string age, string teachSubjectID_FK)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Get the values that inserted in the text box for the first and last name, age , subjectID, to insert this new Teacher into the teachers table*/
                //connection.Query<Teachers>($"INSERT INTO Teachers(FirstName,LastName,Age,Gender,YearOfStudy) VALUES('{firstName}','{lastName}',{Int32.Parse(age)},{Int32.Parse(teachSubjectID_FK)});");
                connection.Execute($"INSERT INTO Teachers(FirstName,LastName,Age,TeachSubjectID_FK) VALUES('{firstName}','{lastName}',{Int32.Parse(age)},'{Int32.Parse(teachSubjectID_FK)}');");
            }
        }

        /* Method to delete a teacher from teachers table */
        public void DeleteTeachers(string teacherID)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Delete the row that the user selected from the teacher grid view */
                connection.Execute($"DELETE FROM Teachers WHERE TeacherID = {Int32.Parse(teacherID)}");
            }
        }

        /* Method to update teacher info */
        public void UpdateTeacherInfo(string teacherID, string firstName, string lastName, string age, string teachSubjectID_FK)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Update selected row values */
                connection.Execute($"UPDATE Teachers SET FirstName = '{firstName}', LastName = '{lastName}', Age = {Int32.Parse(age)}, TeachSubjectID_FK = {Int32.Parse(teachSubjectID_FK)} WHERE TeacherID = {Int32.Parse(teacherID)}");
            }
        }
    }
}
