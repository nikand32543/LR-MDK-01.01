

using System;

namespace NFSConsoleApp
{
    class Program
    {
        static void Main()
        {
            Car auto = new Car();
            auto.SetModel("Лада");
            Console.WriteLine(auto.GetModel());
        }
    }
}
