using Avanade.SUBTCSE.Projeto.Data.Base;
using Avanade.SUBTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repository;

namespace Avanade.SUBTCSE.Projeto.Data.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>, IEmployeeRepository
    {

    }
}
