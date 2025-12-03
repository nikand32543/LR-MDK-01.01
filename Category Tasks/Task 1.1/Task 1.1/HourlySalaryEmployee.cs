
namespace Task_1._1
{
    public class HourlySalaryEmployee
    {
        private Employee Employee_;
        private double salarPenHour_;
        private int hoursWorked_;
        private int overtimeHours_;
        public void SetEmployee(Employee Employees)
        {
            Employee_ = Employees;
        }
        public void SetsalarPenHour(double SalarPenHour_)
        {
            salarPenHour_ = SalarPenHour_;
        }
        public void SethoursWorked(int HoursWorked_)
        {
            hoursWorked_ = HoursWorked_;
        }
        public void SetovertimeHours(int OvertimeHours_)
        {
            overtimeHours_ = OvertimeHours_;
        }
        public double CalculateSalary()
        {
            double ordinaryWatch = salarPenHour_ * hoursWorked_;
            double overtime = salarPenHour_ * hoursWorked_ * 1.5;
            return (ordinaryWatch + ordinaryWatch);
        }
    }
}
