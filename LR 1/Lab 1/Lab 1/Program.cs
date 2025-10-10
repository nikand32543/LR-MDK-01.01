using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // С клавиатуры ввести массив из n целых чисел. Найти произведение отрицательных элементов
            Console.WriteLine("Введите размер массива ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = 1;
            bool negativ = false;
            foreach (int num in array)
            {
                if (num < 0)
                {
                    result *= num;
                    negativ = true;
                }
            }
            if (negativ)
            {
                Console.WriteLine($"Произведение отрицательных элементов: {result}");
            }
            else
            {
                Console.WriteLine("Произведение отрицательных элементов нет");
            }
        }
    }
}
