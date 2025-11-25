
namespace ManyClassesApplications
{
    class Program
    {
        static void Main()
        {
            Storage storage = new Storage(); /// Создаем объект Storage
            storage.SetIdentifier(123);
            storage.SetLocation("г. Торжок, ул. Студенческая, д. 3");

            Product mercedesBenz = new Product(); /// Создаем объект mercedesBenz
            mercedesBenz.SetName("Mercedes Benz");
            mercedesBenz.SetPrice(1000000);

            Product UAZ = new Product(); /// Создаем объект UAZ
            UAZ.SetName("UAZ");
            UAZ.SetPrice(1000000);

            storage.SetProductQuantity(mercedesBenz, 2); 
            storage.SetProductQuantity(UAZ, 5);

            storage.Print();
        }
    }
}
