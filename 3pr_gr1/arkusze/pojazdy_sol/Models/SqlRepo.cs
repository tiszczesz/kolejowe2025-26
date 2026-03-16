using System;

namespace pojazdy_sol.Models;

public class SqlRepo
{
    private string? _connectionString;
    public SqlRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("mysql");
    }
}
