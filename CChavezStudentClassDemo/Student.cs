using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezStudentClassDemo
{
    internal class Student
    {
        // FIELDS
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;

        // ACCESSOR
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
        // ALWAYS VOID
        public void SetMajor(string newMajor)
        {
            major = newMajor;
        }
        public void SetScore1(int newScore1)
        {
            score1 = newScore1;
        }

        public void SetScore2(int newScore2)
        {
            score1 = newScore2;
        }
        public void SetScore3(int newScore3)
        {
            score1 = newScore3;
        }

        // CONSTRUCTORS
        public Student()
        {
            // empty body can be used for
        }
    }


}
