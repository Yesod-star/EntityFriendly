using AutoMapper;
using ListaAfazeres.Data.ValueObjects;
using ListaAfazeres.Model;
using ToDoList.Model;

namespace ListaAfazeres.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<Tarefa, TarefaVO>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
