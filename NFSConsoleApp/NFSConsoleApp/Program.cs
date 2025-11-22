

using System;
using System.Collections.Generic;

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
            Print(auto);

            Car merc = new Car(); /// объект Merc
            merc.SetModel("Merc");
            merc.SetSpeed(300);
            Print(merc);

            List<Car> cars = new List<Car>(); /// Список для хранения объектов
            cars.Add(auto);
            cars.Add(merc);
        }
    }
}
