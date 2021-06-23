using System;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(string firstName, string surName, DateTime birthDate, decimal salary, bool active)
        {
            FirstName = firstName;
            SurName = surName;
            BirthDate = birthDate;
            Salary = salary;
            Active = active;
        }

        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public bool Active { get; set; }
        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; set; }
    }
}
