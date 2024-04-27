namespace cleaningUpProgramCsFile.StartupConfig;
public static class ServicesCollectionConfig
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        
        return services;
    }
}
