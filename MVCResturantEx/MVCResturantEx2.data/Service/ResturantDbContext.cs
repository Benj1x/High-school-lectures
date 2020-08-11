using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCResturantEx2.data.Service
{
    public class ResturantDbContext : DbContext
    {
        public DbSet<ResturantModel> Resturants { get; set; }

        public ResturantDbContext()
        {
            Database.SetInitializer<ResturantDbContext>(new CreateDatabaseIfNotExists<ResturantDbContext>());
            Database.SetInitializer<ResturantDbContext>(new DropCreateDatabaseIfModelChanges<ResturantDbContext>());
        }
    }
}
