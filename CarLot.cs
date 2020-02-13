using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_3
{

    public class CarLot 
    {
        static List<Car> cars = new List<Car>
        {
            new Car("Nikolai","Model S",2017,54999.90),
            new Car("Fourd","Escapade",2017,31999.90),
            new Car("Chewie","Vette",2017 ,44989.95),
            new Car("Audi","R8",2020,200999.99),

            new UsedCar("Hyonda","Prior",2015,14795.50,35987.6),
            new UsedCar("GC","Chirpus",2013,8500,12345),
            new UsedCar("GC", "Witherell", 2016, 14450,3500.3)

        };
        public static int addCarIndex;
        public static int quitIndex;
        

        public void AddCar()
        {
            
            Console.Write("What is the car make? ");
            string carMake= Console.ReadLine();

            Console.Write("What is the car model? ");
            string carModel = Console.ReadLine();

            Console.Write("What is the year of the car? ");
            int carYear = int.Parse(Console.ReadLine());

            Console.Write("What is the car's price? ");
            double carPrice = Double.Parse(Console.ReadLine());

            Console.Write("Is this a used car?");
            string usedCar = Console.ReadLine().ToLower();
            
            if (usedCar == "yes")
            {
                Console.Write("What's the mileage? ");
                double carMileage = Double.Parse(Console.ReadLine());

                cars.Add(new UsedCar(carMake, carModel, carYear, carPrice, carMileage));
            }
            else
            {
                cars.Add(new Car(carMake, carModel, carYear, carPrice));
            }

        }

        public void RemoveCar(int indexCar)
        {
            indexCar--;
            cars.RemoveAt(indexCar);
        }
        public void PrintCars(out int indexC, out int quitI, out int rangeC)
        {
            int count = 1;
           
            Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine($"{count}. {car}");
                count++;
            }
            rangeC = cars.Count;
            indexC = count;
            Console.WriteLine($"{indexC}. Add a car");

            quitI = count + 1;
            Console.WriteLine($"{quitI}. Quit\n");
            
        }
        public void PrintCars()
        {
            int count = 1;

            Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine($"{count}. {car}");
                count++;
            }
            
            Console.WriteLine($"{count}. Add a car");

            count++;
            Console.WriteLine($"{count}. Quit\n");

        }








        /*
         *  robotList.Add(new WallE("Wall-E!!!"));
            robotList.Add(new WallE("Wall-F"));
            robotList.Add(new WallE("Wall-G"));
            robotList.Add(new Eve("Eve"));
            robotList.Add(new Eve("Ev-a!!!")); 
         */

    }
}
