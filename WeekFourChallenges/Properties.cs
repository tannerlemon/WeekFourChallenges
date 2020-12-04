using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalProperties
{
    public class Properties
    {
        public List<Rental> listOfProperties { get; set; } = new List<Rental>();
        public int NumberOfProperties { get { return listOfProperties.Count; } }

        public Properties() { }


    }
}
