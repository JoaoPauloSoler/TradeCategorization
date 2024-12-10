using System;
using System.Collections.Generic;
using TradeCategorization.Categories;
using TradeCategorization.Models;

namespace TradeCategorization.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly List<ICategory> _categories;

        public CategoryService()
        {
            _categories = new List<ICategory>
            {
                new ExpiredCategory(),
                new HighRiskCategory(),
                new MediumRiskCategory()
            };
        }

        public string Categorize(ITrade trade, DateTime referenceDate)
        {
            foreach (var category in _categories)
            {
                if (category.IsMatch(trade, referenceDate))
                {
                    return category.Name;
                }
            }
            return "UNCATEGORIZED";
        }
    }
}
