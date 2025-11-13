using System;

namespace Selling_phones
{
    public class PhoneSale
    {
        // Класс для хранения информации об одной продаже телефона
        public DateTime Date { get; set; }
        public string PhoneModel { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // общая сумма продажи
        public decimal TotalAmount
        {
            get { return Quantity * Price; }
        }

        // прибыль с продажи
        public decimal Profit
        {
            get { return Quantity * (Price - Cost); }
        }
    }
}
