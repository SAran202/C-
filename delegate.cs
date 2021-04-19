using System;
delegate int xyz(int x);
namespace Delegate
{
    class Test
    {
        static int a = 10;
        public static int Add(int x)
        {
            a += x;
            return a;
        }
        public static int Mul(int y)
        {
            a += y;
            return a;
        }
        public static int Geta()
        {
            return a;
        }
        static void Main(string[] args)
        {
            xyz i = new xyz(Add);
            xyz j = new xyz(Mul);

            i(5);
            Console.WriteLine("a: {0}", Geta());
            j(5);
            Console.WriteLine("a: {0}", Geta());
        }
    }
}