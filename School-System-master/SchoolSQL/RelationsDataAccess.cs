using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class RelationsDataAccess
    {

        /* To creat SQL connection string
           1- DataSource = Servername
           2- Initial Catalog = Database Name
           3- Integrated Security
           4- Username
           5- Password
        */
        static string SqlConnectionString = "Data Source=DESKTOP-QUE8LQH;Initial Catalog=SchoolSystemDB;Integrated Security=True;";

        /* Method to show all avilable rleations in the Data base */
        public DataTable GetAllAvilableRelations()
        {
            /* Creat a data tabe to contain the output query result */
            DataTable dataTable = new DataTable();

            /* Querry to view all avilable data */
            string query = @"SELECT Students.StudentID, Students.FirstName AS [Student], 
                             Takes.SubjectID_FK AS [SubjectID], Subjects.SubjectName, Takes.Grade,
                             Teachers.TeacherID,Teachers.FirstName AS [Teacher]
                             From Students
                             JOIN Takes ON Students.StudentID = Takes.StudentID_FK
                             JOIN Subjects ON Subjects.SubjectID = Takes.SubjectID_FK
                             JOIN Teachers ON Subjects.SubjectID = Teachers.TeachSubjectID_FK";

            /* Connect to the srver */
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                /* Open connection to execute querry */
                connection.Open();
                /* Execute the querry */
                SqlCommand cmd = new SqlCommand(query, connection);

                /* Fill dataTable with the result of the querry by using SqlDataAdapter */
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            /* Return the result */
            return dataTable;
        }

        /* Method to return the result of search by student in relation table */
        public DataTable SearchByStudent(string studentSearch)
        {
            /* Creat a data tabe to contain the output query result */
            DataTable dataTable = new DataTable();

            /* Querry to search by student name or student ID*/
            string query = @$"SELECT Students.StudentID, Students.FirstName AS [Student], 
                             Takes.SubjectID_FK AS [SubjectID], Subjects.SubjectName, Takes.Grade,
                             Teachers.TeacherID,Teachers.FirstName AS [Teacher]
                             From Students
                             JOIN Takes ON Students.StudentID = Takes.StudentID_FK
                             JOIN Subjects ON Subjects.SubjectID = Takes.SubjectID_FK
                             JOIN Teachers ON Subjects.SubjectID = Teachers.TeachSubjectID_FK
                             WHERE Students.StudentID LIKE '%{studentSearch}%' OR Students.FirstName LIKE '%{studentSearch}%'";

            /* Connect to the srver */
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                /* Open connection to execute querry */
                connection.Open();
                /* Execute the querry */
                SqlCommand cmd = new SqlCommand(query, connection);

                /* Fill dataTable with the result of the querry by using SqlDataAdapter */
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            /* Return the result */
            return dataTable;
        }


        /* Method to return the result of search by Teacher in relation table */
        public DataTable SearchByTeacher(string teacherSearch)
        {
            /* Creat a data tabe to contain the output query result */
            DataTable dataTable = new DataTable();

            /* Querry to search by Teacher name or Teacher ID*/
            string query = @$"SELECT  Teachers.TeacherID,Teachers.FirstName AS [Teacher], 
                             Takes.SubjectID_FK AS [SubjectID], Subjects.SubjectName,
                             Students.StudentID, Students.FirstName AS [Student], Takes.Grade
                             From Students
                             JOIN Takes ON Students.StudentID = Takes.StudentID_FK
                             JOIN Subjects ON Subjects.SubjectID = Takes.SubjectID_FK
                             JOIN Teachers ON Subjects.SubjectID = Teachers.TeachSubjectID_FK
                             WHERE Teachers.TeacherID LIKE '%{teacherSearch}%' OR Teachers.FirstName LIKE '%{teacherSearch}%'";

            /* Connect to the srver */
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                /* Open connection to execute querry */
                connection.Open();
                /* Execute the querry */
                SqlCommand cmd = new SqlCommand(query, connection);

                /* Fill dataTable with the result of the querry by using SqlDataAdapter */
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            /* Return the result */
            return dataTable;
        }


        /* Method to return the result of search by subject in relation table */
        public DataTable SearchBySubject(string SubjectSearch)
        {
            /* Creat a data tabe to contain the output query result */
            DataTable dataTable = new DataTable();

            /* Querry to search by subject name or subject ID*/
            string query = @$"SELECT Takes.SubjectID_FK AS [SubjectID], Subjects.SubjectName,
                             Students.StudentID, Students.FirstName AS [Student], Takes.Grade,
                             Teachers.TeacherID,Teachers.FirstName AS [Teacher]
                             From Students
                             JOIN Takes ON Students.StudentID = Takes.StudentID_FK
                             JOIN Subjects ON Subjects.SubjectID = Takes.SubjectID_FK
                             JOIN Teachers ON Subjects.SubjectID = Teachers.TeachSubjectID_FK
                             WHERE Takes.SubjectID_FK LIKE '%{SubjectSearch}%' OR Subjects.SubjectName LIKE '%{SubjectSearch}%'";

            /* Connect to the srver */
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                /* Open connection to execute querry */
                connection.Open();
                /* Execute the querry */
                SqlCommand cmd = new SqlCommand(query, connection);

                /* Fill dataTable with the result of the querry by using SqlDataAdapter */
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            /* Return the result */
            return dataTable;
        }

        /* Method to return the result of search by subject in relation table */
        public DataTable CalculateAverage(string searchByStudentID)
        {
            /* Creat a data tabe to contain the output query result */
            DataTable dataTable = new DataTable();

            /* Querry to search by subject name or subject ID*/
            string query = @$"SELECT  AVG(Takes.Grade) AS [Average Degree for {searchByStudentID}]
                             From Students
                             JOIN Takes ON Students.StudentID = Takes.StudentID_FK
                             JOIN Subjects ON Subjects.SubjectID = Takes.SubjectID_FK
                             JOIN Teachers ON Subjects.SubjectID = Teachers.TeachSubjectID_FK
                             WHERE Students.StudentID = {Int32.Parse(searchByStudentID)}";

            /* Connect to the srver */
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                /* Open connection to execute querry */
                connection.Open();
                /* Execute the querry */
                SqlCommand cmd = new SqlCommand(query, connection);

                /* Fill dataTable with the result of the querry by using SqlDataAdapter */
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            /* Return the result */
            return dataTable;
        }
    }
}
