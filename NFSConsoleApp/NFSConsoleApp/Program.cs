

using System;

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
            Car auto = new Car();
            auto.SetModel("Лада");
            auto.SetSpeed(150);
            Print(auto);

            Car merc = new Car();
            merc.SetModel("Merc");
            merc.SetSpeed(300);
            Print(merc);

        }
    }
}
