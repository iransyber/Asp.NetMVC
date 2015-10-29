using AutoMapper; 

namespace SystemDevelopment
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Entidades.Data1.Pessoa  , Models.Data1.Pessoa>  ();
            Mapper.CreateMap<Entidades.Data1.Usuario , Models.Data1.Usuario> ();
            Mapper.CreateMap<Entidades.Data1.Telefone, Models.Data1.Telefone>();
        }
    }
}