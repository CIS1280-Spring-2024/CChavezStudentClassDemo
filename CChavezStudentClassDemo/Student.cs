using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Student
    {
        // FIELDS
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;

        // ACCESSORS
        public string GetMajor()
        {
            return major;
        }
        public int GetScore1()
        {
            return score1;
        }
        public int GetScore2()
        {
            return score2;
        }
        public int GetScore3()
        {
            return score3;
        }
        public string GetStudentFirstName()
        {
            return studentFirstName;
        }
        public string GetStudentLastName()
        {
            return studentLastName;
        }
        public string GetStudentNumber()
        {
            return studentNumber;
        }

        // MUTATOR FUNCTIONS
        public void SetMajor(string major)
        {
            this.major = major;
        }
        public void SetScore1(int score1)
        {
            this.score1 = score1;
        }
        public void SetScore2(int score2)
        {
            this.score2 = score2;
        }
        public void SetScore3(int score3)
        {
            this.score3 = score3;
        }

        public void SetFirstName(string firstName)
        {
            this.studentFirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            this.studentLastName = lastName;
        }
        public void SetStudentNumber(string num)
        {
            studentNumber = num;
        }

        // Constructors
        // Can include default values for feilds
        public Student()
        {
            //empty body
        }
    }
}
