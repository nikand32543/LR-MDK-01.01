
namespace Task_1._1
{
    public class Employee /// сделал класс человек
    {
        private int Id_; /// поля класса
        private string FullName_;
        private string Email_;


        public void SetId(int id) /// методы для получения данных
        {
            Id_ = id;
        }
        public void SetFullName(string FullName)
        {
            FullName_ = FullName;
        }
        public void SetEmail(string Email)
        {
            Email_ = Email;
        }
    }
}
