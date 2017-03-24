﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.Models
{


    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string  Manufacturer { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Class { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public int DriveType { get; set; }

    }
}
