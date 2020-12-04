using RentalProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            var residentialProperty = new Residential(5, 2.5, 1250, 1347, "1333 S Madison Ave", "Anderson", "IN", 46016);

            var commercialProperty = new Commercial();
            commercialProperty.Subtype = "Warehouse";
            commercialProperty.StreetAddress = "917 Nichol Ave";
            commercialProperty.MonthlyRent = 1500;
            commercialProperty.SqFt = 4500;
            commercialProperty.City = "Anderson";
            commercialProperty.State = "IN";
            commercialProperty.ZipCode = 46016;
            commercialProperty.Bathrooms = 3;
        }
    }
}
