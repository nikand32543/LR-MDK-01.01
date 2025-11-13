using System;
using System.Collections.Generic;

namespace Selling_phones
{
    public class SalesAnalyzer
    {
        private List<PhoneSale> sales;

        public SalesAnalyzer(List<PhoneSale> salesData)
        {
            sales = salesData;
        }

        // а) Общая сумма проданного за период
        public decimal GetTotalSalesAmount(DateTime startDate, DateTime endDate)
        {
            decimal total = 0;
            foreach (PhoneSale sale in sales)
            {
                if (sale.Date >= startDate && sale.Date <= endDate)
                {
                    total += sale.TotalAmount;
                }
            }
            return total;
        }

        // б) Самый продаваемый телефон
        public string GetBestSellingPhone()
        {
            Dictionary<string, int> phoneQuantities = new Dictionary<string, int>();

            foreach (PhoneSale sale in sales)
            {
                if (phoneQuantities.ContainsKey(sale.PhoneModel))
                {
                    phoneQuantities[sale.PhoneModel] += sale.Quantity;
                }
                else
                {
                    phoneQuantities.Add(sale.PhoneModel, sale.Quantity);
                }
            }

            string bestSeller = "Нет данных";
            int maxQuantity = 0;

            foreach (KeyValuePair<string, int> pair in phoneQuantities)
            {
                if (pair.Value > maxQuantity)
                {
                    maxQuantity = pair.Value;
                    bestSeller = pair.Key;
                }
            }

            return bestSeller + " (" + maxQuantity + " шт.)";
        }

        // в) Два самых прибыльных телефона
        public List<string> GetTopTwoProfitablePhones()
        {
            Dictionary<string, decimal> phoneProfits = new Dictionary<string, decimal>();

            foreach (PhoneSale sale in sales)
            {
                if (phoneProfits.ContainsKey(sale.PhoneModel))
                {
                    phoneProfits[sale.PhoneModel] += sale.Profit;
                }
                else
                {
                    phoneProfits.Add(sale.PhoneModel, sale.Profit);
                }
            }

            // Сортируем по прибыли
            List<KeyValuePair<string, decimal>> sortedList = new List<KeyValuePair<string, decimal>>(phoneProfits);

            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    if (sortedList[i].Value < sortedList[j].Value)
                    {
                        var temp = sortedList[i];
                        sortedList[i] = sortedList[j];
                        sortedList[j] = temp;
                    }
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < 2 && i < sortedList.Count; i++)
            {
                result.Add(sortedList[i].Key + " - " + FormatMoney(sortedList[i].Value));
            }

            return result;
        }

        // Поиск продаж по дате
        public void ShowSalesByDate(DateTime searchDate)
        {
            Console.WriteLine("\nПродажи за " + searchDate.ToString("dd.MM.yyyy") + ":");
            Console.WriteLine("----------------------------");

            bool found = false;
            decimal dayTotal = 0;
            int dayPhones = 0;

            foreach (PhoneSale sale in sales)
            {
                if (sale.Date.Date == searchDate.Date)
                {
                    Console.WriteLine(sale.PhoneModel + " - " + sale.Quantity + " шт. по " + FormatMoney(sale.Price));
                    dayTotal += sale.TotalAmount;
                    dayPhones += sale.Quantity;
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Итого: " + dayPhones + " телефонов на сумму " + FormatMoney(dayTotal));
            }
            else
            {
                Console.WriteLine("Продаж не было");
            }
        }

        // Показать все даты с продажами
        public void ShowAvailableDates()
        {
            HashSet<DateTime> dates = new HashSet<DateTime>();
            foreach (PhoneSale sale in sales)
            {
                dates.Add(sale.Date.Date);
            }

            List<DateTime> dateList = new List<DateTime>(dates);
            dateList.Sort();

            Console.WriteLine("\nДаты с продажами:");
            foreach (DateTime date in dateList)
            {
                Console.WriteLine("  " + date.ToString("dd.MM.yyyy"));
            }
        }

        private string FormatMoney(decimal amount)
        {
            return amount.ToString("N0") + " руб.";
        }
    }
}
