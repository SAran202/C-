using System;
using System.Collections;

class QueueApp
{
    static void Main(string[] args)
    {
        Queue s = new Queue();
        s.Enqueue("A");
        s.Enqueue("S");
        s.Enqueue("SA");

        Console.WriteLine("Current: ");
        foreach(string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\nAfter EnQueue");
        s.Enqueue("AS");
        foreach (string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\nnxt DQ: {0}", s.Peek());
        s.Dequeue();
        Console.WriteLine("After DQ");
        foreach (string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}