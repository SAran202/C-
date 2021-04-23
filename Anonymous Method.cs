using System;
delegate void xyz(int x);
class Test
    {
        static int a = 10;
        public static void Add(int x)
        {
            a += x;
            Console.WriteLine("1: {0}",a);
        }
        public static void Mul(int y)
        {
            a += y;
            Console.WriteLine("2: {0}",a);
        }
        public static int Geta()
        {
            return a;
        }
        static void Main(string[] args)
        {
            xyz i = delegate(int x){
            Console.WriteLine("Method: {0}",x);
            };
            i(2);
            i=new xyz(Add);
            i(5);
            i=new xyz(Mul);
            i(10);
            Console.ReadKey();
        }
    }

