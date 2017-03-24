using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.Models
{
    public interface IManufacturerRepository
    {
        IEnumerable<Manufacturer> Manufacturers { get; set; }
        Manufacturer GetManufacturerById(int id);
    }
}
