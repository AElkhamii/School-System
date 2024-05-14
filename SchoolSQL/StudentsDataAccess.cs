using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class StudentsDataAccess
    {
        /* Method to return the search value from student table */
        public  List<Student> GetStudents(string SearchValue)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Ask the SchoolSystemDB for a query to get a data back student data type and set the result to a list of student (.ToList()) to return with the result list that will be displaied on gridview  */
                return connection.Query<Student>($"SELECT * FROM Students WHERE (FirstName LIKE '%{SearchValue}%' OR LastName LIKE '%{SearchValue}%' OR StudentID LIKE'%{SearchValue}%')").ToList();
            }
        }

        /* Method to insert a new student into the table */
        public void InsertStudent(string firstName, string lastName, string age, string gender, string yearOfStudy)
        {
            /* Open SQL connection by creat new connection with the connection string (SchoolSystemDB) that you crated in App.config */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                /* Get the values that inserted in the text box for the first and last name, age , gender, and year of study to insert this new student into the students table*/
                connection.Query<Student>($"INSERT INTO Students(FirstName,LastName,Age,Gender,YearOfStudy) VALUES('{firstName}','{lastName}',{Int32.Parse(age)},'{gender}',{Int32.Parse(yearOfStudy)});");
            }
        }
    }
}
