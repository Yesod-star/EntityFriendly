using AutoMapper;
using EntityFriendlyBack.Data.ValueObjects;
using EntityFriendlyBack.Model;

namespace EntityFriendlyBack.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ToDoListVO, ToDoList>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
