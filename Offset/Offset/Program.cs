using OffsetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offset
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Zaporogec = new Car("Запорожец", 150000, "Лада");

            Console.WriteLine(Zaporogec.GetName());

            List<Car> allCars = new List<Car>
            {
                new Car ("Vesta", 1500000, "Лада"),
                new Car ("Niva", 250000, "Лада"),
                new Car ("Lamborgini", 15000000, "Lamborgini")
            };
            allCars.Add(Zaporogec);
            Console.WriteLine("Название автомобиля: " + allCars[1].GetName());
            List<Car> cars = GetAllCarsMoreThanX(500000, allCars);

            Console.WriteLine(cars[0].GetName());


        }
        static public List<Car> GetAllCarsMoreThanX(double x, List<Car> allCars)
        {
            List<Car> result = new List<Car>();
            foreach (Car t in allCars)
            {
                if (t.GetPrice() > x)
                {
                    result.Add(t);
                }
            }

            return result;
        }
    }
}
