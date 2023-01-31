using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Fundamentals_Lab03
{
    public class Student
    {
        private int _studentId;
        public int StudentId { get { return _studentId; } }
        private void _setStudentId(int studentId)
        {
            if (studentId > 0)
            {
                _studentId = studentId;
            }
            else
            {
                throw new Exception("Student ID must be greater than zero");
            }

        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length > 0)
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("Cannot be empty.");
                }
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length > 0)
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Cannot be empty.");
                }
            }
        }
        //many students can each take one course
        public HashSet<Enrolment> CurrentEnrolments = new HashSet<Enrolment>();
        public Course Course { get; set; }
        private int? _courseGrade;

        public int? CourseGrade { get { return _courseGrade; } }


        public void SetCourseGrade(int grade)
        {
            if (Course == null)
            {
                throw new Exception("Student not enrolled in any ");
            }
            else if (grade < 0 || grade > 100)
            {
                throw new Exception("Grade must be between 0 and 100");
            }
            else
            {
                _courseGrade = grade;
            }
        }

        public void RemoveGade()
        {
            _courseGrade = null;
        }

        private DateTime? _registrationDate;
        public DateTime? RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }

        //public void SetRegistrationDate(DateTime date)
        //{
        //    if (Course == null)
        //    {
        //        throw new Exception("Student not enrolled in any ");
        //    }
        //    else
        //    {
        //        _registrationDate = date;
        //    }
        //}

        public void RemoveRegistrationDate()
        {
            _registrationDate = null;
        }

        public Enrolment _currentEnrolment { get; set; }
        //Constructors
        public Student(int studentId)
        {
            _setStudentId(studentId);
        }
        public Student(int studentId, string firstName, string lastName)
        {
            _setStudentId(studentId);
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

