using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge3Csharp
{
    class Car
    {
        private string brand = "";
        private string speed = "";
        private string topSpeed = "";
        private bool isUsed = true;
        private int year = 0;

        public Car(string brand, string speed, string topSpeed, bool isUsed, int year)
        {
            this.brand = brand;
            this.speed = speed;
            this.topSpeed = topSpeed;
            this.isUsed = isUsed;
            this.year = year;
        }

        public string getBrand()
        {
            return this.brand;
        }
        public void setBrand(string brand)
        {
            this.brand = brand;
        }
        public string getSpeed()
        {
            return this.speed;
        }
        public void setSpeed(string speed)
        {
            this.speed = speed;
        }
        public string gettopSpeed()
        {
            return this.topSpeed;
        }
        public void settopSpeed(string topSpeed)
        {
            this.topSpeed = topSpeed;
        }
        public bool getisUsed()
        {
            return this.isUsed;
        }
        public void setisUsed(bool isUsed)
        {
            this.isUsed = isUsed;
        }
        public int getYear()
        {
            return this.year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
    }
}
