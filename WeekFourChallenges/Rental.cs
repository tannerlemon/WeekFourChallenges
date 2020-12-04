using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties
{
    public class Rental
    {
        public int Bedrooms { get; set; }
        public double Bathrooms { get; set; }
        public double MonthlyRent { get; set; }
        public int SqFt { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Rental() { }
        public Rental(int bedrooms, double bathrooms, double monthlyRent, int sqFt, string streetAddress, string city, string state, int zipCode)
        {
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            MonthlyRent = monthlyRent;
            SqFt = sqFt;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
