

namespace Variant_4
{
    public class Medicines
    {
        private double price_;
        private string name_;
        private string photo_;
        private string description_;

        public Medicines (double price, string name, string photo, string description)
        {
            price_ = price;
            name_ = name;
            photo_ = photo;
            description_ = description;
        }
        public string Name
        {
            get { return name_; }
        }
        public string Photo
        {
            get { return photo_; }
        }
    }
}
