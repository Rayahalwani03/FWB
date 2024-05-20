using raysversion.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raysversion.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;

        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<StudentInfo>();

        }

        public List<StudentInfo> GetALLStudents() {
        
            Init();
            return conn.Table<StudentInfo>().ToList();
        }

        public void AddStudents(StudentInfo student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void DeleteStudents(int Student_ID) {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentInfo { StudentID = Student_ID });
        }

        public void Init2()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<CourseInfo>();

        }

        public List<CourseInfo> GetAllCourses()
        {

            Init2();
            return conn.Table<CourseInfo>().ToList();
        }

        public void AddCourses(CourseInfo course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }

        public void DeleteCourses(int course_Id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new CourseInfo { CourseID = course_Id });
        }

        public void Init3()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<EnrollmentInfo>();

        }

        public List<EnrollmentInfo> GetAllEnrollments()
        {

            Init3();
            return conn.Table<EnrollmentInfo>().ToList();
        }

        public void AddEnrollments(EnrollmentInfo enrollment)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(enrollment);
        }

        public void DeleteEnrollments (int enrollment_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new EnrollmentInfo { EnrollmentID = enrollment_ID });
        }
    }


}
