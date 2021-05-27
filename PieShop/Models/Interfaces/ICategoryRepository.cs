using System.Collections.Generic;

namespace PieShop.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
