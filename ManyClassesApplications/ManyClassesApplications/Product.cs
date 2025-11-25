

namespace ManyClassesApplications
{
    public class Product
    {
        private string name_;
        private double price_;

        public void SetName(string name) /// задать имя
        {
            name_ = name;
        }
        public void SetPrice(double price) /// задается цена
        {
            price_ = price;
        }
        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }
    }
}
