using System;

namespace Lab_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot test = new CarLot();
            Console.WriteLine("Welcome to Grand Chirpus' Used Car Emporium!");
            int userSelection;
           

            test.PrintCars(out int addCarIndex, out int quitIndex, out int rangeCars);

            do
            {
                userSelection = GetInt("Which car would you like? ");


                if (userSelection < addCarIndex && userSelection > 0)
                {
                    Console.Write("\nWould you like to buy this car? ");
                    string userBuying = Console.ReadLine().ToLower();

                    if (userBuying == "y")
                    {
                        test.RemoveCar(userSelection);

                        Console.WriteLine("\nExcellent! Our finance department will be in touch shortly. ");

                        test.PrintCars(out addCarIndex, out quitIndex, out rangeCars);
                    }
                    
                }
                if (userSelection == addCarIndex )
                {
                    test.AddCar();
                    test.PrintCars(out addCarIndex, out quitIndex, out rangeCars);
                }
                

            } while (userSelection != quitIndex);
            
        }
        static int GetInt(string prompt)
        {
            string input;
            int number;
            bool worked;

            Console.Write(prompt);
            input = Console.ReadLine();
            worked = int.TryParse(input, out number);

            while (worked == false)
            {
                Console.WriteLine("Let's try again.");
                Console.Write("\nPlease enter a number in the selection");
                input = Console.ReadLine();

                worked = int.TryParse(input, out number);
            }
            return number;
        }

    }
}
