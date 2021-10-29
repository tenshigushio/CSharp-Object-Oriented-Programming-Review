using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_OOP
{
    class TestClass
    {
        static void Main(string[] args)
        {
            int profession;
            do
            {
                Console.WriteLine("\n\nMAIN MENU\n");
                Console.WriteLine("[1] Doctor\n[2] Programmer\n[3] Exit\n");
                Console.WriteLine("Enter 1 if Doctor or 2 if Programmer: ");
                profession = Convert.ToInt32(Console.ReadLine());
                switch (profession)
                {
                    case 1:
                        Console.Write("Enter ID Number: ");
                        int doctor_id = int.Parse(Console.ReadLine());
                
                        Console.Write("Enter Name: ");
                        string doctor_name = (Console.ReadLine());
                        Console.Write("Enter Field of Specialization: ");
                        string doctor_specialization = (Console.ReadLine());
                        Console.Write("Number of days worked: ");
                        int doctor_workingDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nDoctors's Information:\n");
                        Employee doctor = new Doctor(doctor_id, doctor_name, doctor_specialization);

                        doctor.calculateSalary(doctor_workingDays);
                        doctor.display();
                        Console.WriteLine("Deduction: " + doctor.calculateDeduction());
                        Console.WriteLine("Net Pay: " + doctor.calculateNetPay());
                        break;
                    case 2:
                        Console.Write("Enter ID Number: ");
                        int programmer_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string programmer_name = (Console.ReadLine());
                        Console.Write("Enter Field of Specialization: ");
                        string programmer_specialization = (Console.ReadLine());
                        Console.Write("Number of days worked: ");
                        int programmer_workingDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nProgrammer's Information:\n");
                        Employee programmer = new Programmer(programmer_id, programmer_name, programmer_specialization);

                        programmer.calculateSalary(programmer_workingDays);
                        programmer.display();
                        Console.WriteLine("Deduction: " + programmer.calculateDeduction());
                        Console.WriteLine("Net Pay: " + programmer.calculateNetPay());
                        break;
                    default:
                        return;

                }
            } while (profession != 3);

                
            Console.ReadKey();
        }
    }
}
