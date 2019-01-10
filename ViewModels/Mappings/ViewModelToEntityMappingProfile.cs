using AutoMapper;
using payroll.Models;

namespace payroll.ViewModels.Mappings 
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
              CreateMap<RegistrationViewModel,AppUser>().ForMember(au => au.EmployeeNo, map => map.MapFrom(vm => vm.EmployeeNo));
        }
    }
}