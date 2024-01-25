namespace CChavezStudentClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.SetMajor("Computer Programing");

            Student myOtherStudent = new Student();
            myOtherStudent.SetMajor("Art History");

            Console.WriteLine("My student's major is {0}.", myStudent.GetMajor);
            Console.WriteLine("My other student's major is {0}.", myOtherStudent.GetMajor);
        }
    }
}
