using MVCResturantEx2.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCResturantEx2.data.Service
{
    public class ResturantModelView
    {
        //Her laves en liste
        List<ResturantModel> resturants;

        public ResturantModelView()
        {
            //Her tilføjes elementer til listen
            resturants = new List<ResturantModel>()
            {
                new ResturantModel{Id = 1, Name = "Marco's Pizzaria", Cuisine = CuisineType.Italian},
                new ResturantModel{Id = 2, Name = "Glee's Sloppy Joe", Cuisine = CuisineType.French},
                new ResturantModel{Id = 3, Name = "Mads's Rice 'n' Curry", Cuisine = CuisineType.Indian}

            };
        }
    }
}
