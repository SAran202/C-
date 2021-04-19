using System;
using System.Collections;

class StackApp
{
    static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push("A");
        s.Push("S");
        s.Push("SA");

        Console.WriteLine("Current: ");
        foreach(string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\nAfter Push");
        s.Push("AS");
        foreach (string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\nnxt PoP: {0}", s.Peek());
        s.Pop();
        Console.WriteLine("After PoP");
        foreach (string c in s)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}