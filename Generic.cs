using System;
using System.Collections.Generic;

namespace GenericApp
{
    public class GenericArray<T>
    {
        private T[] array;

        public GenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index,T value)
        {
            array[index] = value;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>(5);

            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            for(int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();
            GenericArray<char> charArray = new GenericArray<char>(5);
            for(int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            for(int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}