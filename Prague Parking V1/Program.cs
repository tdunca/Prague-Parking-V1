using System;
using System.Text.RegularExpressions;

class Program
{       
    static void Main()
    {
        string[] garage = new string[100]; 
        for (int i = 0; i < garage.Length; i++)
        {
            garage[i] = "";
        }
        while (true) //loop until "6.Exit" is chosen
        {
            Console.Clear();
            Console.WriteLine("Prague Parking System");
            Console.WriteLine("Hourly Fee - Car: 20,00 SEK");
            Console.WriteLine("Hourly Fee - Motorbike: 10,00 SEK");

            Console.WriteLine("1. Park a vehicle");
            Console.WriteLine("2. Collect a vehicle");
            Console.WriteLine("3. Move a vehicle");
            Console.WriteLine("4. Search using license plate");
            Console.WriteLine("5. Calculate parking fee");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");
            string choice = Console.ReadLine();

            if (choice == "1") //matches the first choice in a chain
            {
                Name(garage);
            }
            else if (choice == "2")
            {
                Name(garage);
            }
            else if (choice == "3")
            {
                Name(garage);
            }
            else if (choice == "4")
            {
                Name(garage);
            }
            else if (choice == "5")
            {
                Name(garage); 
            }
            else if (choice == "6")
            {
                return; //exit the program  
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option (1-6).");
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
