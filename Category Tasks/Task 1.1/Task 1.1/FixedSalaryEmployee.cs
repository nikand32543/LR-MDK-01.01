
namespace Task_1._1
{
    public class FixedSalaryEmployee /// класс фиксированная месячная оплата
    {
        private Employee Employee_;
        private double FixedSalary_;
        public void SetEmployee(Employee Employees) /// методы для получения данных
        {
            Employee_ = Employees;
        }
        public void SetFixedSalary(double fixedSalary)
        {
            FixedSalary_ = fixedSalary;
        }
        public double CalculateSalary()
        {
            return FixedSalary_;
        }
    }
}
