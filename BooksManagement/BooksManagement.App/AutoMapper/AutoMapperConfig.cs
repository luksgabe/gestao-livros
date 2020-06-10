using AutoMapper;

namespace BooksManagement.App.AutoMapper
{
    public class AutoMapperConfig 
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDTOMappingProfile());
                cfg.AddProfile(new DTOToDomainMappingProfile());
            });
        }
    }
}
