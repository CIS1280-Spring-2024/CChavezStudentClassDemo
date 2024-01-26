using StudentClassDemo;

namespace StaticClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.SetMajor("Computer Programming");

            Student myOtherStudent = new Student();
            myOtherStudent.SetMajor("Art History");

            Console.WriteLine(myStudent.GetMajor());
            Console.WriteLine(myOtherStudent.GetMajor());

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
