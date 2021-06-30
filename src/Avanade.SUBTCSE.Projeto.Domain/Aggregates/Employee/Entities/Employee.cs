using System;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(string firstName, string lastName, DateTime birthDate, decimal salary, bool active, EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Salary = salary;
            Active = active;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public bool Active { get; set; }
        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; set; }
    }
}
