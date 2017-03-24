using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SampleCore.Models
{
    public interface ICarRepository
    {
     
        IEnumerable<Car> Cars { get; set; }
        Car GetCarById(int id);
    }
}
