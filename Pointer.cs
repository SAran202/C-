using System;
class PointerClass
{
    public unsafe void swap(int* x, int* y)
    {
        int t = *x;
        *x = *y;
        *y = t;        
    }
    public unsafe static void Main()
    {
        PointerClass pc = new PointerClass();
        int a = 2;
        int b = 3;
        int* i = &a;
        int* j = &b;

        Console.WriteLine("B4 swap: {0} {1}", a, b);
        pc.swap(i, j);
        Console.WriteLine("After swap: {0} {1}", a, b);
        Console.ReadKey();
    }
}