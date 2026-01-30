using System;

namespace ShoppingCartInfrastructure.Options;

public class DatabaseOptions
{
    public int MaxRetryCount { get; set; }
    public int MaxRetryDelay { get; set; }
    public int CommandTimeout { get; set; }
    public string ConnectionString { get; set; } = string.Empty;
}
