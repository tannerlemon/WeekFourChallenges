using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties
{
    public class RentalRepo
    {
        private readonly List<Rental> _rentalDirectory = new List<Rental>();

        // Create
        public void AddRental(Rental rental)
        {
            _rentalDirectory.Add(rental);
        }

        // Read
        public List<Rental> GetRentalList()
        {
            return _rentalDirectory;
        }

        // Update
        public bool UpdateRental(string streetAddress, Rental newRental)
        {
            Rental oldRental = GetRentalByAddress(streetAddress);

            if (oldRental != null)
            {
                oldRental.Bedrooms = newRental.Bedrooms;
                oldRental.Bathrooms = newRental.Bathrooms;
                oldRental.MonthlyRent = newRental.MonthlyRent;
                oldRental.StreetAddress = newRental.StreetAddress;
                oldRental.City = newRental.City;
                oldRental.State = newRental.State;
                oldRental.ZipCode = newRental.ZipCode;
                oldRental.SqFt = newRental.SqFt;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete
        public bool RemoveRental(string streetAddress)
        {
            Rental rental = GetRentalByAddress(streetAddress);

            if (rental == null)
            {
                return false;
            }

            int initialCount = _rentalDirectory.Count;
            _rentalDirectory.Remove(rental);

            if (initialCount > _rentalDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper
        public Rental GetRentalByAddress(string streetAddress)
        {
            foreach (Rental rental in _rentalDirectory)
            {
                if (rental.StreetAddress == streetAddress)
                {
                    return rental;
                }
            }

            return null;
        }
    }
}
