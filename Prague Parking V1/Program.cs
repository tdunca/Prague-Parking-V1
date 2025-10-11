using System;
using System.ComponentModel.Design;
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
                Parking(garage);
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
    static void Parking(string[] garage)
    {
        Console.Write("Enter vehicle type (Car/Motorbike): ");
        string vehicleType = Console.ReadLine().Trim().ToLower();

        if (vehicleType != "Car" && vehicleType != "Motorbike")
        {
            Console.WriteLine("Invalid vehicle type. Please enter 'Car' or 'Motorbike'.");
            return;
        }

        Console.WriteLine("Format: 1-2 letters, 1-4 numbers, 0-2 letters): ");
        Console.Write("Enter license plate: ");
        string registration = Console.ReadLine();

        string pattern = @"^[A-Za-z]{1,2}[0-9]{1,4}[A-Za-z]{0,2}$";

        if (!string.IsNullOrEmpty(registration) && registration.Length <= 10 && Regex.IsMatch(registration, pattern))
        {
            Console.WriteLine("License plate is valid");
        }
        else
        {
            Console.WriteLine("Wrong format for license plate. Please try again");
            return;
        }

        for (int i = 0; i < garage.Length; i++)
        {
            if (string.IsNullOrEmpty(garage[i]))
            {
                garage[i] = $"{vehicleType}:{registration}";
                Console.WriteLine($"Vehicle parked in spot {i + 1}.");
                return;
            }
            else if (vehicleType == "MC" && garage[i].StartsWith("MC#"))
            {
                if (garage[i].Split('').Length < 2)
                {
                    garage[i] += $"#{vehicleType}:{registration}";
                    Console.WriteLine($"Motorbike parked in spot {i + 1}.");
                    return;
                }
            }
        }

        Console.WriteLine("Garage is full. Cannot park the vehicle.");
    }

}
