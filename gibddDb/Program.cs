using gibddDBcore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace gibddDb
{
    class Program
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<gibddDbContext> _optionsBuilder;
        static void Main(string[] args)
        {
            BuildOptions();
            Console.WriteLine(_configuration.GetConnectionString("gibddDBManager"));
           
            ListInventory();
        }
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<gibddDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("gibddDBManager"));
        }
        static void ListInventory()
        {
        }
    }
}
