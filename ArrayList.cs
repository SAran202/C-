using System;
using System.Collections;

namespace ArrayApp
{
    class Program
    {
static void Main(string[] args)
    {
        ArrayList a = new ArrayList();

        Console.WriteLine("Adding: ");
        a.Add(0);
        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(0);
        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);

            Console.WriteLine("Capacity: {0}", a.Capacity);
            Console.WriteLine("Count: {0}", a.Count);

            Console.WriteLine("Content: ");
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorting: ");
            a.Sort();
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nContains");
            a.Contains(5);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nindex of 4");
            a.IndexOf(4);
            Console.WriteLine("Insert");
            a.Insert(3, 1);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nRemove 1");
            a.Remove(1);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nReverse");
            a.Reverse();
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nDone");
            Console.ReadKey();
    } }}
