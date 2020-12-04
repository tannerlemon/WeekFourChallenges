using RentalProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties_Console
{
    class ProgramUI
    {
        private RentalRepo _rentalRepo = new RentalRepo();

        // Start
        public void Run()
        {
            Seed();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display options
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Rental\n" +
                    "2. View All Rentals\n" +
                    "3. View Rental By Street Address\n" +
                    "4. Update Rental\n" +
                    "5. Delete Rental\n" +
                    "6. Exit");

                // Get input
                string input = Console.ReadLine();

                // Act accordingly
                switch (input)
                {
                    case "1":
                        CreateNewRental();
                        break;
                    case "2":
                        DisplayAllRentals();
                        break;
                    case "3":
                        DisplayRentalByStreetAddress();
                        break;
                    case "4":
                        UpdateExistingRental();
                        break;
                    case "5":
                        RemoveExistingRental();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number..");
                        break;
                }

                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create New Rental
        private void CreateNewRental()
        {
            Console.Clear();

            var newRental = new Rental();

            // Beds
            Console.WriteLine("Enter the number of bedrooms for this property:");
            newRental.Bedrooms = int.Parse(Console.ReadLine());

            // Baths
            Console.WriteLine("Enter the number of bathrooms for this property:");
            newRental.Bathrooms = double.Parse(Console.ReadLine());

            // Rent
            Console.WriteLine("Enter the monthly rent for this property:");
            newRental.MonthlyRent = double.Parse(Console.ReadLine());

            // SqFt
            Console.WriteLine("Enter the square feet for this property:");
            newRental.SqFt = int.Parse(Console.ReadLine());

            // Street
            Console.WriteLine("Enter the street address for this property:");
            newRental.StreetAddress = Console.ReadLine();

            // City
            Console.WriteLine("Enter the city for this property:");
            newRental.City = Console.ReadLine();

            // State
            Console.WriteLine("Enter the state for this property:");
            newRental.State = Console.ReadLine();

            // Zip
            Console.WriteLine("Enter the zip code for this property:");
            newRental.ZipCode = int.Parse(Console.ReadLine());

            _rentalRepo.AddRental(newRental);
        }

        // Display All Rentals
        private void DisplayAllRentals()
        {
            Console.Clear();
            List<Rental> listofRentals = _rentalRepo.GetRentalList();

            foreach (Rental rental in listofRentals)
            {
                Console.WriteLine($"{rental.StreetAddress}\n" +
                    $"{rental.City}, {rental.State} {rental.ZipCode}\n" +
                    $"Bedrooms: {rental.Bedrooms}\n" +
                    $"Bathrooms: {rental.Bathrooms}\n" +
                    $"SqFt: {rental.SqFt}\n" +
                    $"Rent: ${rental.MonthlyRent}\n");
            }
        }

        // Display Rental By Address
        private void DisplayRentalByStreetAddress()
        {
            Console.Clear();

            Console.WriteLine("Enter the street address for the property you would like to view:");

            string input = Console.ReadLine();

            Rental rental = _rentalRepo.GetRentalByAddress(input);

            if (rental != null)
            {
                Console.WriteLine($"{rental.StreetAddress}\n" +
                    $"{rental.City}, {rental.State} {rental.ZipCode}\n" +
                    $"Bedrooms: {rental.Bedrooms}\n" +
                    $"Bathrooms: {rental.Bathrooms}\n" +
                    $"SqFt: {rental.SqFt}\n" +
                    $"Rent: ${rental.MonthlyRent}\n");
            }
            else
            {
                Console.WriteLine("I couldn't find that property..");
            }
        }

        // Update Rental
        private void UpdateExistingRental()
        {
            DisplayAllRentals();

            Console.WriteLine("\nEnter the street address of the property you would like to update:");

            string input = Console.ReadLine();

            Rental newRental = new Rental();

            // Beds
            Console.WriteLine("Enter the new number of bedrooms for this property:");
            newRental.Bedrooms = int.Parse(Console.ReadLine());

            // Baths
            Console.WriteLine("Enter the new number of bathrooms for this property:");
            newRental.Bathrooms = double.Parse(Console.ReadLine());

            // Rent
            Console.WriteLine("Enter the new monthly rent for this property:");
            newRental.MonthlyRent = double.Parse(Console.ReadLine());

            // SqFt
            Console.WriteLine("Enter the new square feet for this property:");
            newRental.SqFt = int.Parse(Console.ReadLine());

            // Street
            Console.WriteLine("Enter the new street address for this property:");
            newRental.StreetAddress = Console.ReadLine();

            // City
            Console.WriteLine("Enter the new city for this property:");
            newRental.City = Console.ReadLine();

            // State
            Console.WriteLine("Enter the new state for this property:");
            newRental.State = Console.ReadLine();

            // Zip
            Console.WriteLine("Enter the new zip code for this property:");
            newRental.ZipCode = int.Parse(Console.ReadLine());

            bool wasUpdated = _rentalRepo.UpdateRental(input, newRental);

            if (wasUpdated)
            {
                Console.WriteLine("This property was successfully updated.");
            }
            else
            {
                Console.WriteLine("Sorry, I could not update the property.");
            }
        }

        // Remove Rental
        private void RemoveExistingRental()
        {
            DisplayAllRentals();

            Console.WriteLine("Enter the street address of the property you would like to remove:");

            string input = Console.ReadLine();

            bool wasDeleted = _rentalRepo.RemoveRental(input);

            if (wasDeleted)
            {
                Console.WriteLine("Property was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The property could not be deleted.");
            }
        }

        // Get Number Of Properties
        private void GetNumberOfProperties()
        {
            Console.Clear();

            Properties properties = new Properties();

            Console.WriteLine($"There are {properties.NumberOfProperties} in the directory.");
        }


        // Seed
        public void Seed()
        {
            Rental sMadison = new Rental(7, 2, 750, 1553, "1333 S Madison Ave", "Anderson", "IN", 46016);
            Rental eleventh = new Rental(3, 1, 500, 1200, "519 W 11th St", "Anderson", "IN", 46016);
            Rental nichol = new Rental(3, 1, 750, 1400, "917 Nichol Ave", "Anderson", "IN", 46016);

            _rentalRepo.AddRental(sMadison);
            _rentalRepo.AddRental(eleventh);
            _rentalRepo.AddRental(nichol);
        }
    }
}
