using System;
using System.Collections.Generic;

namespace Selling_phones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем данные
            List<PhoneSale> salesData = DataGenerator.GenerateTestData();
            SalesAnalyzer analyzer = new SalesAnalyzer(salesData);

            Console.WriteLine("АНАЛИЗ ПРОДАЖ ТЕЛЕФОНОВ");
            Console.WriteLine("=======================");

            // Показываем даты
            analyzer.ShowAvailableDates();

            // Поиск по дате
            SearchByDate(analyzer);

            // Основной анализ
            ShowAnalysis(analyzer);

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }

        static void SearchByDate(SalesAnalyzer analyzer)
        {
            while (true)
            {
                Console.WriteLine("\nПоиск продаж по дате");
                Console.Write("Введите дату (ДД.ММ.ГГГГ) или 'нет': ");
                string input = Console.ReadLine();

                if (input.ToLower() == "нет")
                    break;

                try
                {
                    DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", null);
                    analyzer.ShowSalesByDate(date);
                }
                catch
                {
                    Console.WriteLine("Ошибка формата даты!");
                }
            }
        }

        static void ShowAnalysis(SalesAnalyzer analyzer)
        {
            // а) Общая сумма
            DateTime start = new DateTime(2025, 11, 1);
            DateTime end = new DateTime(2024, 11, 30);
            decimal total = analyzer.GetTotalSalesAmount(start, end);
            Console.WriteLine("\nа) Общая сумма продаж: " + FormatMoney(total));

            // б) Самый продаваемый
            string bestSeller = analyzer.GetBestSellingPhone();
            Console.WriteLine("б) Самый продаваемый: " + bestSeller);

            // в) Самые прибыльные
            List<string> profitable = analyzer.GetTopTwoProfitablePhones();
            Console.WriteLine("в) Самые прибыльные телефоны:");
            for (int i = 0; i < profitable.Count; i++)
            {
                Console.WriteLine("   " + (i + 1) + ". " + profitable[i]);
            }
        }

        static string FormatMoney(decimal amount)
        {
            return amount.ToString("N0") + " руб.";
        }
    }
}
