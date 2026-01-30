using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;

namespace ShoppingCartInfrastructure.Options;

public class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
{
    private readonly IWebHostEnvironment _env;
    
    public void Configure(DatabaseOptions options)
    {

        throw new NotImplementedException();
    }
}
