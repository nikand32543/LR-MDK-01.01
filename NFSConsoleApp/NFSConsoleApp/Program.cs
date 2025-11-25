

using System;
using System.Collections.Generic;
using System.Threading;

namespace NFSConsoleApp
{
    class Program
    {
        static public void Print(Car automobile)
        {
            Console.WriteLine(automobile.GetModel());
        }
        static void Main()
        {
            Car auto = new Car(); /// объект Лада
            auto.SetModel("Лада");
            auto.SetSpeed(150);
           // Print(auto);

            Car merc = new Car(); /// объект Merc
            merc.SetModel("Merc");
            merc.SetSpeed(300);
           // Print(merc);

            List<Car> cars = new List<Car>(); /// Список для хранения объектов
            cars.Add(auto);
            cars.Add(merc);

            LadaVsMerc(cars);
        }
        static public void LadaVsMerc(List<Car> cars) /// функция для гонок
        {
            int speed = 1;
            while (true)
            {
                foreach (Car s in cars)
                { 
                    for (int i = 0; i < s.GetSpeed() / 50 * speed; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(s.GetModel());
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------");
                    speed++;
                }
                Thread.Sleep(60);
                Console.Clear();
            }
        }
    }
}
