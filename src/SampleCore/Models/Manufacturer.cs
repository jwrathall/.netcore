using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.Models
{
    public class Manufacturer 
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Collection<Car> Cars { get; set; }

    }
}
