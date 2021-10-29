using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_OOP
{
    class Programmer: Employee
    {
        /* **DATA MEMBER WITH GETTER AND SETTER** */
        internal string specialization { get; set; }

        /* **CONTRUCTORS** */

        //empty contructor for doctor
        public Programmer()
        {

        }

        /*
         contructor for Programmer with own parameter (specialization)
         & parameters (employee_id and name) invoking parent class: Employee
         */
        public Programmer(int employee_id, string name, string specialization) : base(employee_id, name)
        {
            this.specialization = specialization;
        }

        /* **OVERRIDING METHODS** */

        //override display adding specialization
        public override void display()
        {
            base.display();
            Console.WriteLine("Specialization: " + specialization);
        }

        //override calculate salary
        public override double calculateSalary(double workingDays)
        {

            base.salary = 950 * workingDays;

            return base.salary;
        }

        //override calculate salary deduction
        public override double calculateDeduction()
        {
            double salary = base.salary;

            base.deduction = (salary * 0.05/*SSS*/) + (salary * 0.03/*PAG-IBIG*/) + (salary * 0.08/*WTAX*/) + (salary * 0.03/*PHILHEALTH*/);

            return base.deduction;

        }

        //override calculating NetPay by subtraction
        public override double calculateNetPay()
        {
            return base.salary - base.deduction;
        }

    }
}
