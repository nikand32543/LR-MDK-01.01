using System;
using System.Collections.Generic;

namespace Selling_phones
{
    public static class DataGenerator
    {
        // Создает список тестовых продаж
        public static List<PhoneSale> GenerateTestData()
        {
            Random random = new Random();

            // Список всех моделей телефонов в магазине
            string[] phoneModels = new string[]
            {
                "iPhone 17 Pro", "Samsung Galaxy S25", "Xiaomi Redmi Note 15",
                "Google Pixel 10", "OnePlus 15", "Huawei P70", "Realme 14 Pro", "Vivo V29"
            };

            List<PhoneSale> sales = new List<PhoneSale>();
            DateTime startDate = new DateTime(2025, 11, 1);

            // Создаем данные за 30 дней
            for (int i = 0; i < 30; i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                int salesPerDay = random.Next(3, 8);

                // Цикл по продажам в текущем дне
                for (int j = 0; j < salesPerDay; j++)
                {
                    // Выбираем случайную модель из списка
                    string phoneModel = phoneModels[random.Next(phoneModels.Length)];
                    int quantity = random.Next(1, 4);
                    decimal price = GetPhonePrice(phoneModel);
                    decimal cost = price * GetCostRatio(phoneModel);

                    // Создаем объект продажи
                    PhoneSale sale = new PhoneSale
                    {
                        Date = currentDate,
                        PhoneModel = phoneModel,
                        Quantity = quantity,
                        Price = price,
                        Cost = cost
                    };

                    sales.Add(sale);
                }
            }

            return sales;
        }

        // возвращает цену телефона по модели
        private static decimal GetPhonePrice(string model)
        {
            switch (model)
            {
                case "iPhone 17 Pro": return 149990;
                case "Samsung Galaxy S25": return 109990;
                case "Xiaomi Redmi Note 15": return 29990;
                case "Google Pixel 10": return 89990;
                case "OnePlus 15": return 79990;
                case "Huawei P70": return 89990;
                case "Realme 14 Pro": return 34990;
                case "Vivo V29": return 49990;
                default: return 50000;
            }
        }

        // Возвращает коэффициент себестоимости (сколько % от цены составляет себестоимость)
        private static decimal GetCostRatio(string model)
        {
            switch (model)
            {
                case "iPhone 17 Pro": return 0.78m;
                case "Samsung Galaxy S25": return 0.75m;
                case "Xiaomi Redmi Note 15": return 0.65m;
                case "Google Pixel 10": return 0.72m;
                case "OnePlus 15": return 0.70m;
                case "Huawei P70": return 0.74m;
                case "Realme 14 Pro": return 0.67m;
                case "Vivo V29": return 0.69m;
                default: return 0.70m;
            }
        }
    }
}
