using System;
namespace test
{
    public class Student
    {
        private string code = "N.A";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "code = " + code + ", Age = " + age;
        }
    }
    class Tst
    {
        public static void Main()
        {
            Student s = new Student();
            s.Code = "SA";
            s.Age = 8;
            Console.WriteLine("Info: {0}", s);
        }
    }
}