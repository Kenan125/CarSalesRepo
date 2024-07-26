using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarSaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = Kenan\\MSSQL2022; Initial Catalog = CarSale; Persist Security Info = True; User ID = sa; Password = 54321; Trust Server Certificate = True");
        }
        
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarColor> Colors { get; set; }
    }
}
