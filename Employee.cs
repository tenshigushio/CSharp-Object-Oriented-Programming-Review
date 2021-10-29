using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_OOP
{
    /* **ABSTRACT CLASS EMPLOYEE** */
    abstract class Employee
    {
        /* **DATA MEMBERS WITH GETTERS AND SETTERS** */
        public int employee_id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public double deduction { get; set; }


        /* **CONTRUCTORS** */

        //empty contructor for Employee
        public Employee() { }

        //constructor with parameters: employee_id and name
        public Employee(int employee_id, string name)
        {
            this.employee_id = employee_id;
            this.name = name;
        }

        /* ** DISPLAY METHOD ** */
        public virtual void display(){

            Console.WriteLine("\n\nID : " + employee_id + "\nName : " + name + "\nSalary : " + salary);
        }

        /* ** ABSTRACT METHODS ** */
        public abstract double calculateSalary(double workingDays);
        public abstract double calculateDeduction();
        public abstract double calculateNetPay();
    }
}
