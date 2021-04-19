using System;
using System.Collections;

namespace CollectionApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Hashtable t = new Hashtable();

            t.Add("1", "SA");
            t.Add("2", "AS");
            t.Add("3", "S");

            if (t.ContainsValue("A"))
            {
                Console.WriteLine("It Have");
            }
            else
            {
                t.Add("4", "A");
            }
            ICollection key = t.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(k + ": " + t[k]);
            }
            t.Remove(3);
            Console.WriteLine("Removed");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + t[k]);
            }
            t.Clear();
            Console.WriteLine("Clear");
            Console.ReadKey();
        }
    }
}