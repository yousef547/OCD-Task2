using AutoMapper;
using OCD_task.Model;
using OCD_task.ViewModel;

namespace OCD_task
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var MappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EmployeeVM, Employee>();
                config.CreateMap<Employee, EmployeeVM>();

            });
            return MappingConfig;
        }
    }
}
