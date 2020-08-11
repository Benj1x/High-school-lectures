using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVCResturantEx2.data.Service
{
    public class SqlRestaurantData
    {
        private ResturantDbContext db;

        public SqlRestaurantData(ResturantDbContext db)
        {
            this.db = db;
        }

        public void Add(ResturantModel resturant)
        {
            db.Resturants.Add(resturant);
            db.SaveChanges();
        }

        public ResturantModel getDetails(int Id)
        {
            return db.Resturants.FirstOrDefault(r => r.Id == Id);
        }

        public List<ResturantModel> getAll()
        {
            return db.Resturants.OrderBy(x => x.Name).ToList();
        }

        public void update(ResturantModel resturant)
        {
            var existing = getDetails(resturant.Id);
            if (existing != null)
            {
                existing.Name = resturant.Name;
                existing.Cuisine = resturant.Cuisine;
            }
        }

        public void Remove(ResturantModel resturant)
        {
            var target = db.Resturants.Find(resturant.Id);
            db.Resturants.Remove(target ?? throw new InvalidOperationException());
            db.SaveChanges();
        }
    }
}
