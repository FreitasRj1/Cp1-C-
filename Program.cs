using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ProvaEFCore.App.Data;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseOracle(config.GetConnectionString("DefaultConnection"));

using var ctx = new AppDbContext(optionsBuilder.Options);
Console.WriteLine("Projeto pronto. Use os comandos dotnet ef para criar migrations e atualizar o banco.");
