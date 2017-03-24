using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId = 1, Name = "Hyper Car", Description = "Concept car"},
                    new Category {CategoryId = 1, Name = "Super Car", Description = "Fast production car"},
                    new Category {CategoryId = 1, Name = "Sports Car", Description = "Affordable fast car"}
                };
            }
        }

        public Category GetCategoryById(int id)
        {
            return new Category {CategoryId = 1, Name = "Hyper Car", Description = "Concept car"};
        }
    }
}
