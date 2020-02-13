using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_3
{
    class UsedCar : Car
    {
        private double mileage;

        
        public double Mileage { get => mileage; set => mileage = value; }
        
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }
        public UsedCar()
        {

        }

        public override string ToString()
        {
            return base.ToString() + $" (Used) {mileage}";
        }
    }
}
