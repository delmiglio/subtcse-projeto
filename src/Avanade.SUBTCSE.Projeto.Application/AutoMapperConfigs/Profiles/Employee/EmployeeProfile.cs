using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, SUBTCSE.Projeto.Domain.Aggregates.Employee.Entities.Employee>()
                .ConstructUsing((ctor, res) =>
                {
                    return new SUBTCSE.Projeto.Domain.Aggregates.Employee.Entities.Employee(
                        firstName: ctor.FirstName,
                        lastName: ctor.LastName,
                        birthDate: ctor.BirthDate,
                        active: ctor.Active,
                        salary: ctor.Salary,
                        employeeRole: res.Mapper.Map<SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(ctor.EmployeeRole));
                })
                .ForAllOtherMembers(i => i.Ignore());

            CreateMap<SUBTCSE.Projeto.Domain.Aggregates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.EmployeeRole, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
