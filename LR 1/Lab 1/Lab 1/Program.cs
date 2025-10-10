using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // С клавиатуры ввести массив из n целых чисел. Найти произведение отрицательных элементов
            Console.WriteLine("Введите размер массива ");
            int razArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[razArray];
            for (int i = 0; i < razArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int product = 1;
            bool negativ = false;
            foreach (int num in array)
            {
                if (num < 0)
                {
                    product *= num;
                    negativ = true;
                }
            }
            if (negativ)
            {
                Console.WriteLine($"Произведение отрицательных элементов: {product}");
            }
            else
            {
                Console.WriteLine("Произведение отрицательных элементов нет");
            }
        }
    }
}
