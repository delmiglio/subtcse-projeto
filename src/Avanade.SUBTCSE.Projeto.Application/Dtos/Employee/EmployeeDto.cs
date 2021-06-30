using Avanade.SubTCSE.Projeto.Application.Dtos.Base;
using Avanade.SUBTCSE.Projeto.Application.Dtos.EmployeeRole;
using System;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }

        public decimal Salary { get; set; }

        public EmployeeRoleDto EmployeeRole { get; set; }
    }
}
