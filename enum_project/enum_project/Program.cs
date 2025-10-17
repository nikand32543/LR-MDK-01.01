

using System;

namespace enum_project
{
    enum Size
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }
    class Program
    {
        static void Main()
        {
            Size mySize = Size.ExtraLarge;
            Console.WriteLine($"Мой размер : {mySize}");
            Console.WriteLine("\nДоступные размеры:");
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                string description;
                if (size == Size.Small)
                    description = "Small";
                else if (size == Size.Medium)
                    description = "Medium";
                else if (size == Size.Large)
                    description = "Large";
                else
                    description = "ExtraLarge";

                    Console.WriteLine($"{size} - {description}");
            }
        }
    }
}
