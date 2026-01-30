using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using ShoppingCartPresentation;

namespace ShoppingCartApp.ExtentionsMethods;

public static class RegisterControllerExtention
{
    public static IServiceCollection RegisterController(this IServiceCollection services)
    {
        services.AddControllers().AddApplicationPart(AssemblyReferance.Assembly).AddNewtonsoftJson(o=>
        {
        o.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        });
        return services;
    }

}
