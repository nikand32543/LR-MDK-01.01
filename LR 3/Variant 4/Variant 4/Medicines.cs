

using System;
using System.Windows.Forms;

namespace Variant_4
{
    public class Medicines
    {
        private string name_;
        private double price_;
        private string photo_;
        private string description_;
        private DateTime shelfLifeDate_;

        public Medicines(string name, double price, string photo, string description, DateTime date)
        {
            name_ = name;
            price_ = price;
            photo_ = photo;
            description_ = description;
            shelfLifeDate_ = date;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Photo
        {
            get { return photo_; }
        }

        public string Description
        {
            get { return description_; }
        }
        public DateTime Date
        {
            get { return shelfLifeDate_; }
        }
    }
}
