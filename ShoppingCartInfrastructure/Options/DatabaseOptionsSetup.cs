using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ShoppingCartInfrastructure.Options;

public class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
{
    private readonly IWebHostEnvironment _env;
    private readonly IConfiguration _configuration;
    private const string _envConnection = "constrDev";
    private const string _stagConnection = "constrStag";
    private const string _sectionName = "DatabaseOptions";
    public DatabaseOptionsSetup(IWebHostEnvironment env,IConfiguration configuration)
    {
        _env = env;
        _configuration = configuration;
    }
    public void Configure(DatabaseOptions options)
    {

        if (_env.IsStaging() is true)
        {
            options.ConnectionString = _configuration.GetConnectionString("_stagConnection");
        }else if (_env.IsDevelopment() is true)
        {
            options.ConnectionString = _configuration.GetConnectionString("_envConnection");
        }
        else
        {
            throw new InvalidOperationException("Environment not supported");
        }
        _configuration.GetSection(_sectionName).Bind(options);
    }
}
