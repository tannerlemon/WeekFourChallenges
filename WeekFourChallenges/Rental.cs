using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties
{
    public abstract class Rental
    {
        public double Bathrooms { get; set; }
        public decimal MonthlyRent { get; set; }
        public int SqFt { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Rental() { }
        public Rental(double bathrooms, decimal monthlyRent, int sqFt, string streetAddress, string city, string state, int zipCode)
        {
            Bathrooms = bathrooms;
            MonthlyRent = monthlyRent;
            SqFt = sqFt;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }

    public class Commercial : Rental
    {
        public string Subtype { get; set; }

        public Commercial() { }
        public Commercial(string subtype, double bathrooms, decimal monthlyRent, int sqFt, string streetAddress, string city, string state, int zipCode)
            : base(bathrooms, monthlyRent, sqFt, streetAddress, city, state, zipCode)
        {
            Subtype = subtype;
        }
    }

    public class Residential : Rental
    {
        public int Bedrooms { get; set; }

        public Residential() { }
        public Residential(int bedrooms, double bathrooms, decimal monthlyRent, int sqFt, string streetAddress, string city, string state, int zipCode)
            : base(bathrooms, monthlyRent, sqFt, streetAddress, city, state, zipCode)
        {
            Bedrooms = bedrooms;
        }
    }
}
