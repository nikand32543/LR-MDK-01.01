using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massiv = new string[3];
            massiv[0] = "La";
            massiv[1] = "Ma";
            massiv[2] = "Si";

            massiv[1] = "GiGi";
            foreach(string n in massiv)
            {
                Console.WriteLine("Элементы массива " + n);
            }

            string[] array = new string[3];
            array[2] = massiv[0];
            array[1] = massiv[1];
            array[0] = massiv[2];



        }
    }
}
