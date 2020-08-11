using MVCResturantEx2.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCResturantEx2.data
{
    public class ResturantModel
    {
        //Disse elementer kan også laves med "prop" og at tabbe to gange
        public int Id { get; set; }

        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
