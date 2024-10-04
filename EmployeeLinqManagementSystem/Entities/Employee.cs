using System.Globalization;

namespace EmployeeLinqManagementSystem.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, string email, decimal salary, string department)
        {
            Name = name;
            Email = email;
            Salary = salary;
            Department = department;
        }

        public override string? ToString()
        {
            return $"Employee: {Name} - Email {Email} - Salary {Salary.ToString("f2", CultureInfo.InvariantCulture)} - ({Department})";
        }
    }
}
