using Avanade.SUBTCSE.Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repository
{
    public interface IEmployeeRepository : IBaseRepository<Entities.Employee, string>
    {

    }
}
