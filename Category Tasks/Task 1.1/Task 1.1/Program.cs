
using System;

namespace Task_1._1
{
    public class Program
    {
        static void Main()
        {
            Employee Nikita = new Employee(); /// создал 3 человек
            Nikita.SetId(1);
            Nikita.SetFullName("Никита Большиков");
            Nikita.SetEmail("nik@gmail.com");
            Employee Vlad = new Employee();
            Vlad.SetId(2);
            Vlad.SetFullName("Влад Николаев");
            Vlad.SetEmail("nikolaev@gmail.com");
            Employee Kirill = new Employee();
            Kirill.SetId(3);
            Kirill.SetFullName("Кирилл Малышев");
            Kirill.SetEmail("malish@mail.ru");

            FixedSalaryEmployee Nikitos = new FixedSalaryEmployee(); /// положил данные в класс FixedSalaryEmployee
            Nikitos.SetEmployee(Nikita);
            Nikitos.SetFixedSalary(110000);
            Console.WriteLine(Nikitos.CalculateSalary());

            HourlySalaryEmployee Kirya = new HourlySalaryEmployee(); /// положил данные в класс HourlySalaryEmployee
            Kirya.SetEmployee(Kirill);
            Kirya.SetsalarPenHour(400);
            Kirya.SethoursWorked(12);
            Kirya.SetovertimeHours(2);
            Console.WriteLine (Kirya.CalculateSalary());

            FreelancerEmployee Vlados = new FreelancerEmployee(); /// положил данные в класс FreelancerEmployee
            Vlados.SetEmployee(Vlad);
            Vlados.SetProjectPayment(150000);
            Vlados.SetTaxPercent(10);
            Console.WriteLine(Vlados.CalculateSalary());
        }
    }
}
