using AutoMapper;
using GraphQL.Mappings;

namespace GraphQL;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}