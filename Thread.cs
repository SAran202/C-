using System;
using System.Threading;
class MainClass
{
    public static void thread()
    {
        Thread.Sleep(5000);
        Console.WriteLine("Nxt Thread");
    }
    static void Main(string[] args)
    {
        ThreadStart x = new ThreadStart(thread);
        Console.WriteLine("Main");
        Thread a = new Thread(x);
        a.Start();
        a.Abort();
        Console.ReadKey();
    }
}