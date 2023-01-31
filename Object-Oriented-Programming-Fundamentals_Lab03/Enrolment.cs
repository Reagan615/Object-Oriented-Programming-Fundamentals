using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Fundamentals_Lab03
{
    public class Enrolment
    {
        public int _id;
        public int Id { get { return _id; } }

        private Student _student;
        public Student Student { get { return _student; } }

        private Course _course;
        public Course Course { get { return _course; } }

        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set
            {

            }

        }


        private DateTime _enrolmentDate;
        public DateTime EnrolmentDate { get { return _enrolmentDate; } }
        public Enrolment(int id, Student student, Course course)
        {
            _id = id;
            _student = student;
            _course = course;

            _enrolmentDate = DateTime.Now;
        }
    }
}
