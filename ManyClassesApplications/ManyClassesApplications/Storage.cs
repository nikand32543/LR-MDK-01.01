

using System;
using System.Collections.Generic;

namespace ManyClassesApplications
{
    class Storage /// класс (место хранения товара)
    {
        private int identifier_; /// идентификатор
        private string location_; /// локация
        private Dictionary<Product, int> products_ = new Dictionary<Product, int>(); /// Словарь с ключом Product

        public void SetIdentifier(int identifier) /// Метод добавления идентификатора
        {
            identifier_ = identifier;
        }
        public void SetLocation(string location) /// Метод добавления локации
        {
            location_ = location;
        }
        public void SetProductQuantity(Product product, int quantity)
        {
            products_.Add(product, quantity);
        }
        public void Print() /// 
        {
            foreach(Product key in products_.Keys)
            {
                Console.WriteLine(key.GetName() + " " + products_[key] + " шт.");
            }
        }
        
    }
}
