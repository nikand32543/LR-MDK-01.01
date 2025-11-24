using System;
using System.Collections.Generic;


namespace Диски
{
    class Program
    {
        static public void Print(List<catalog> Yearthese, int count)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Yearthese[i].name);
            }
            Console.WriteLine("Cреднее количество обращений: " + count);
            ;
        }
        static void Main()
        {

            List<catalog> C = new List<catalog>();


            C.Add(new catalog { name = "User", year = 2025, requests = 15 }); // идет заполнение диска C
            C.Add(new catalog { name = "Windows", year = 2025, requests = 32 });
            C.Add(new catalog { name = "Admin", year = 2025, requests = 20 });
            C.Add(new catalog { name = "Пользователи", year = 2025, requests = 52 });
            C.Add(new catalog { name = "Programs Files", year = 2025, requests = 12 });

            List<catalog> D = new List<catalog>();

            D.Add(new catalog { name = "Telegram", year = 2025, requests = 60 });// идет заполнение диска D
            D.Add(new catalog { name = "Kompas", year = 2025, requests = 90 });
            D.Add(new catalog { name = "War Thunder", year = 2025, requests = 230 });
            D.Add(new catalog { name = "Музыка", year = 2025, requests = 143 });
            D.Add(new catalog { name = "Steam", year = 2025, requests = 1000 });


            Disk disk_C = new Disk(); // Диск C
            disk_C.Name = "Диск C";
            disk_C.catalogs = C;
            Disk disk_D = new Disk(); // Диск D
            disk_D.Name = "Диск D";
            disk_D.catalogs = D;

            string user = userRequest.InputUserRequest();
            List<catalog> Yearthese = DateAnalysisModule.СataloguesThisYear(disk_C, disk_D, user);
            DateAnalysisModule.SortDescendingOrder(Yearthese);
            int countRequest = DateAnalysisModule.AverageNumberRequest(Yearthese);
            Print(Yearthese, countRequest);





        }
    }
}
