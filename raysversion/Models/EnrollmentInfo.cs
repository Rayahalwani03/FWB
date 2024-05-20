using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raysversion.Models
{
    public class EnrollmentInfo
    {
        [PrimaryKey, AutoIncrement]
        public int EnrollmentID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
    }
}
