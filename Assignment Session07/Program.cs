using Assignment_Session07.Classes;
using Assignment_Session07.Enums;

namespace Assignment_Session07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Design and implement a Class for the employees in a company
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Kareem";
            //employee.SecurityLevel = SecurityLevel.Developer;
            //employee.Salary = 12500.45;
            //employee.HireDate = new DateOnly(2022, 3, 15); // or DateOnly.Parse("2022-03-15");
            //employee.Gender = Gender.Male;
            //Console.WriteLine(employee.ToString());
            #endregion

            #region Q2- Develop a Class to represent the Hiring Date Data
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Kareem";
            //employee.SecurityLevel = SecurityLevel.Developer;
            //employee.Salary = 12500.45;
            //employee.HireDate = new HiringDate(15, 3, 2022); // by using the class "HiringDate"
            //employee.Gender = Gender.Male;
            //Console.WriteLine(employee.HireDate.ToString());
            #endregion

            #region Q3- Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Kareem", SecurityLevel.Developer, 20000, new HiringDate(1, 1, 2020), Gender.Male);
            //EmpArr[1] = new Employee(2, "Ramy", SecurityLevel.SecurityOfficer, 65000, new HiringDate(12, 7, 2009), Gender.Male);
            //EmpArr[2] = new Employee(3, "Marian", SecurityLevel.Secretary, 11000, new HiringDate(8, 3, 2023), Gender.Female);

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("---------------------------");
            //}
            //Console.ReadLine();
            #endregion

            #region Q4- Sort the employees based on their hire date then Print the sorted array
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Kareem", SecurityLevel.Developer, 20000, new HiringDate(1, 1, 2020), Gender.Male);
            //EmpArr[1] = new Employee(2, "Ramy", SecurityLevel.SecurityOfficer, 65000, new HiringDate(12, 7, 2009), Gender.Male);
            //EmpArr[2] = new Employee(3, "Marian", SecurityLevel.Secretary, 11000, new HiringDate(8, 3, 2023), Gender.Female);

            //Array.Sort(EmpArr, CompareByHireDate);

            //Console.WriteLine("Employees sorted by Hire Date:\n\n");
            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("---------------------------");
            //}
            //Console.WriteLine("\nBoxing/Unboxing operations during sorting: 0");
            #endregion

            #region Q5- Design a program for a library management system where
            //// Book
            //Book book = new Book(1, "C# OOP", "Kareem", "124-67422-67310-45");
            //book.DisplayInfo();
            //Console.WriteLine("-------------------------------");
            //// EBook
            //EBook EBook = new EBook(1, "C# OOP", "Kareem", "124-67422-67310-45", 129.32);
            //EBook.DisplayInfo();
            //Console.WriteLine("-------------------------------");
            //// PrintedBook
            //PrintedBook PrintedBook = new PrintedBook(1, "C# OOP", "Kareem", "124-67422-67310-45", 430);
            //PrintedBook.DisplayInfo();

            /*
             * Demonstrate how inheritance simplifies the design:
                 => Using inheritance made the design of the library system much easier and cleaner. 
                Instead of repeating the same properties like Title, Author, and ISBN in every type of book, 
                I put them once in a base class called Book. Then the other classes like PrintedBook and EBook 
                just inherited from it and added only what was unique to them — like PageCount for printed books 
                and FileSize for ebooks. This way, I avoided writing the same code multiple times, and if I ever 
                need to change something like how book info is displayed, I can do it in one place instead of everywhere.
                Also, by using constructor chaining, the shared information (like title and author) gets passed directly to 
                the base class, keeping the code organized and avoiding errors. Overall, inheritance helped me write less code, 
                keep it more readable, and make it easier to update later.
             */
            #endregion
        }

        // Comparison method — no boxing involved [used in Q4]
        public static int CompareByHireDate(Employee e1, Employee e2)
        {
            return e1.HireDate.ToDateOnly().CompareTo(e2.HireDate.ToDateOnly());
        }
    }
}
