using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab_5_3
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public Car()
        {

        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            
            return $"{make,-15} {model,-15} {year} {price.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
