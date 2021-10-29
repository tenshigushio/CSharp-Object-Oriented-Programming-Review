using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_OOP
{
    /* **CLASS DOCTOR: EMPLOYEE** */
    class Doctor : Employee
    {
        /* **DATA MEMBER WITH GETTER AND SETTER** */
        internal string specialization { get; set; }

        /* **CONTRUCTORS** */

        //empty contructor for doctor
        public Doctor()
        {

        }

        /*
         contructor for Doctor with own parameter (specialization)
         & parameters (employee_id and name) invoking parent class: Employee
         */
        public Doctor(int employee_id, string name, string specialization) : base(employee_id, name)
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

        //override calculate salary based on specialization and number of working days in a month
        public override double calculateSalary(double workingDays)
        {
            string pedia = "Pediatrician";
            string oby = "Ob-Gynecologist";
            string neuro = "Neurologist";

            if (pedia.Equals(specialization))
            {
                base.salary = 2050 * workingDays;
            }
            if (oby.Equals(specialization))
            {
                base.salary = 2650 * workingDays;
            }
            if (neuro.Equals(specialization))
            {
                base.salary = 6575 * workingDays;
            }

            return base.salary;
        }

        //override calculate salary deduction
        public override double calculateDeduction()
        {
            double salary = base.salary;


            if (salary <= 10000)
            {
                base.deduction = (salary * 0.03/*SSS*/) + (salary * 0.02/*PAG-IBIG*/) + (salary * 0.05/*WTAX*/) + (salary * 0.01/*PHILHEALTH*/);
            }
            else if (salary > 10000 && salary <= 20000)
            {
                base.deduction = (salary * 0.05/*SSS*/) + (salary * 0.04/*PAG-IBIG*/) + (salary * 0.1/*WTAX*/) + (salary * 0.025/*PHILHEALTH*/);
            }
            else if (salary > 20000 && salary <= 30000)
            {
                base.deduction = (salary * 0.07/*SSS*/) + (salary * 0.07/*PAG-IBIG*/) + (salary * 0.15/*WTAX*/) + (salary * 0.5/*PHILHEALTH*/);
            }
            else if (salary > 30000)
            {
                base.deduction = (salary * 0.1/*SSS*/) + (salary * 0.1/*PAG-IBIG*/) + (salary * 0.3/*WTAX*/) + (salary * 0.08/*PHILHEALTH*/);
            }

            return base.deduction;

        }

        //override calculating NetPay by subtraction
        public override double calculateNetPay()
        {
            return base.salary - base.deduction;
        }

        
    }//end of class Doctor
}
