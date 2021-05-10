using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // student ekene = new student();
            // ekene.id = -2;
            // ekene.name = null;
            // ekene.passMark = 100;
            // Console.WriteLine($"Student details {ekene.id} {ekene.name} {ekene.passMark}");
            Employee testEmployee = new Employee();
            testEmployee.FirstName = "Zegards";
            testEmployee.LastName = "Kinkoju";
            testEmployee.TotalPay = 20;
            testEmployee.Id = 2;
            testEmployee.PrintDetails();
        }
    }

    public class student
    {
        private int _id;
        public string name;
        public int passMark;

        
        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id should be greater than Zero");
            }
            this._id = id;
        }

        public int getId()
        {
            return _id;
        }
    }


    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalPay { get; set; }
        public int Id { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Firstname: {FirstName} \nLastname: {LastName} \nTotal pay: {TotalPay} \nID: {Id}");
        }

    }
}
