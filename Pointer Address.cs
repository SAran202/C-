//Printing Address & value
using System;

class PointerClass
{
    public unsafe static void Main(string[] args)
    {
        int[] list = { 2, 3, 4 };
        fixed(int *p = list)

        for(int i=0; i < 3; i++)
        {
            Console.WriteLine("Address of {0} : {1}", i, (int)(p+i));
                Console.WriteLine("value of {0} : {1}", i, *(p + i));
                Console.ReadKey();

        }
    }
}