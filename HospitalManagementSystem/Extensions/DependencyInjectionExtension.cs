using ASP_.NET__Projects.Services;

namespace ASP_.NET__Projects.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<HospitalService>();
        
        // services.AddSingleton<HospitalService>(); // Butun requestlerde ayni instance kullanilir.
        // services.AddScoped<HospitalService>(); // Request boyunca ayni instance kulllanir. Her request icin insatance degisir.
        // services.AddTransient<HospitalService>(); // Her kullanildigi yer icin bir instance olusturulur.
        
        return services;
    }
}