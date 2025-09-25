using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
        }
    }
}
