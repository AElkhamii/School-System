using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSQL
{
    internal class Relation
    {
        public int StudentID_FK { get; set; }
        public int SubjectID_FK { get; set; }
        public int Grade { get; set; }
    }
}
