using System;

namespace ClassLession
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            objStudent.TakeExam();
        }
    }
    public class Student
    {
        public string strName;
        public byte byteMark;

        public Student() { }

        public Student(string name, byte mark)
        {
            strName = name;
            byteMark = mark;

            Console.WriteLine("The object was created");
        }

        public void SetStudent(string name)
        {
            strName = name;
        }

        public string GetStudent()
        {
            return strName;
        }

        public void TakeExam()
        {
            Console.WriteLine("The student is taking exam.");
        }

        ~Student()
        {
            Console.WriteLine("The object was detroyed");
        }
    }
}
