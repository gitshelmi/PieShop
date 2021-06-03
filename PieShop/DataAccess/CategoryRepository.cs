using System.Collections.Generic;
using PieShop.Models;
using PieShop.Models.Interfaces;

namespace PieShop.DataAccess
{
    public class CategoryRepository : ICategoryRepository
    {
        public AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
