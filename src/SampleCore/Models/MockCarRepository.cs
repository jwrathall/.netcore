using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.Models
{
    public class MockCarRepository : ICarRepository
    {
        private readonly ICategoryRepository _CategoryRepository = new MockCategoryRepository();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {CarId = 1, Category = new Category {CategoryId = 1, Name="Hyper Car", Description = ""},Engine="A bif one", Transmission = "Manual", Manufacturer = "McLeran", Name = "P1"},
                    new Car {CarId = 1, Category = new Category {CategoryId = 1, Name="Hyper Car", Description = ""},Engine="A bif one", Transmission = "Manual", Manufacturer = "McLeran", Name="670LT"}
                };
            }
            set { throw new NotImplementedException(); }
        }

        public Car GetCarById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

