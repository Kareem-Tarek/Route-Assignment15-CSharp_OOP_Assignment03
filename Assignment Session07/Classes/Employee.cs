using Assignment_Session07.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session07.Classes
{
    internal class Employee
    {
        // Attributes
        private double salary;

        // Default constructor
        public Employee() { }

        // Full constructor
        public Employee(int id, string name, SecurityLevel securityLevel, double salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                salary = value;
            }
        }
        //public DateOnly HireDate { get; set; }
        public HiringDate HireDate { get; set; } // by using the class "HiringDate"
        public Gender Gender { get; set; }

        // Methods
        public override string ToString()
        {
            // For salary currency format: "{String.Format("{0:C}", Salary)}" or "{Salary:C}"
            return $"Id: {Id}\nName: {Name}\nSalary: {String.Format("{0:C}", Salary)}\nSecurity Level: {SecurityLevel}\nHire Date: {HireDate}\nGender: {Gender}";
        }


    }
}
