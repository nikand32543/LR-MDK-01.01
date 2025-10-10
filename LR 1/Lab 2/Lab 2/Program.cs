using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5000];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-1000, 1001);
            }
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
