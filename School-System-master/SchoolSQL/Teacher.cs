using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class Teacher
    {
        int TeacherID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int age { get; set; }

        public int TeachSubjectID_FK { get; set; }
    }
}
