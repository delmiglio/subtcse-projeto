using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
