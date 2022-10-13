using Microsoft.EntityFrameworkCore;
using ProductOwner.Microservice.Models;

namespace ProductOwner.Microservice.Data
{
    public class DbContextClass : DbContext
    {
        //  The IConfiguration interface is used to read Settings and Connection Strings from AppSettings. json file
        protected readonly IConfiguration Configuration;    // ReadOnly is a runtime constant. Const is a compile time constant. The value of readonly field can be changed. The value of the const field can not be changed.ReadOnly is a runtime constant. Const is a compile time constant. The value of readonly field can be changed. The value of the const field can not be changed.
        public DbContextClass (IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // sql server connection

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<ProductDetails> Products { get; set; }
        // DbContext corresponds to your database (or a collection of tables and views in your database) whereas a DbSet corresponds to a table or view in your database.
    }
}
