using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraOpgaver
{
    class Car
    {
        private string model = "";
        private string brand = "";
        private string horses = "";
        private int km = 0;
        private int price = 0;
        private int year = 0;

        public Car(string brand, string model, string horses, int km, int price, int year)
        {
            this.model = model;
            this.brand = brand;
            this.horses = horses;
            this.km = 0;
            this.price = price;
            this.year = year;
        }

        public string getModel()
        {
            return this.model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public string getBrand()
        {
            return this.brand;
        }
        public void setBrand(string brand)
        {
            this.brand = brand;
        }
        public string getHorses()
        {
            return this.horses;
        }
        public void setHorses(string horses)
        {
            this.horses = horses;
        }
        public int getKm()
        {
            return this.km;
        }
        public void setKm(int km)
        {
            this.km = 0;
        }
        public int getPrice()
        {
            return this.price;
        }
        public void setPrice()
        {
            this.price = 0;
        }
        public int getYear()
        {
            return this.year;
        }
        public void setYear()
        {
            this.year = 0;
        }        
    }
}
