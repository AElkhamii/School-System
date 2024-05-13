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
        public  List<Student> GetStudents(string SearchValue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SchoolSystemDB")))
            {
                connection.Open();

                return connection.Query<Student>($"SELECT * FROM Students WHERE (FirstName LIKE '%{SearchValue}%' OR LastName LIKE '%{SearchValue}%' OR StudentID LIKE'%{SearchValue}%')").ToList();
            }
        }
    }
}
