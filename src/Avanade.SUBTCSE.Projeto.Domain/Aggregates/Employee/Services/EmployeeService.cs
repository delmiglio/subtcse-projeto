using Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services;
using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
