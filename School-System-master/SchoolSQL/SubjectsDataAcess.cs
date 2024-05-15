using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class SubjectsDataAcess
    {
        /* Method to return all avilable Subjects */
        public List<Subject> AvilableSubjects()
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Ask the SchoolSystemDB for a query to get back all avilable subject data type and set the result to a list of subject (.ToList()) to return with the result list that will be displaied on gridview  */
                return connection.Query<Subject>("SELECT * FROM Subjects").ToList();
            }
        }


        /* Method to return the search value from Subject table */
        public List<Subject> GetSubjects(string SearchValue)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Ask the SchoolSystemDB for a query to get a data back subject data type and set the result to a list of subject (.ToList()) to return with the result list that will be displaied on gridview  */
                return connection.Query<Subject>($"SELECT * FROM Subjects WHERE (SubjectName LIKE '%{SearchValue}%') OR SubjectID LIKE '%{SearchValue}%'").ToList();
            }
        }


        /* Method to insert a new subject into the table */
        public void InsertSubject(string subjectName)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Get the values that inserted in the text box for the first and last name, age , gender, and year of study to insert this new subject into the subjects table*/
                //connection.Query<Subject>($"INSERT INTO Subjects (SubjectName) VALUES('{subjectName}');");
                connection.Execute($"INSERT INTO Subjects(SubjectName) VALUES('{subjectName}');");
            }
        }


        /* Method to delete a subject from subjects table */
        public void DeleteSubject(string subjectID)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Delete the row that the user selected from the subject grid view */
                connection.Execute($"DELETE FROM Subjects WHERE SubjectID = {Int32.Parse(subjectID)}");
            }
        }


        /* Method to update subject info */
        public void UpdateSubjectInfo(string subjectID, string subjectName)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Update selected row values */
                connection.Execute($"UPDATE Subjects SET SubjectName = '{subjectName}' WHERE SubjectID = {Int32.Parse(subjectID)}");
            }
        }

    }
}
