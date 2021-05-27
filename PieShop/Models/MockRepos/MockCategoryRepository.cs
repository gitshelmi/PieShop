﻿using System.Collections.Generic;
using PieShop.Models.Interfaces;

namespace PieShop.Models.MockRepos
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{Id=1, Name="Fruit pies", Description="All-fruity pies"},
                new Category{Id=2, Name="Cheese cakes", Description="Cheesy all the way"},
                new Category{Id=3, Name="Seasonal pies", Description="Get in the mood for a seasonal pie"}
            };
    }
}
