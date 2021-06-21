using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    public interface IEmployeeRoleService
    {
        void AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
