using AutoMapper;
using ListaAfazeres.Data.ValueObjects;
using ListaAfazeres.Model;

namespace ListaAfazeres.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<Tarefa, TarefaVO>().ReverseMap();
                config.CreateMap<Pessoa, PessoaVO>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
