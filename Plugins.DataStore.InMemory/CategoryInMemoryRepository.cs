using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.Repositories;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
              {
                  new Category{ CategoryId= 1, Name ="Beverages",  Description = "Beverage"},
                  new Category{ CategoryId= 2, Name ="Meat",  Description = "Meat"},
                  new Category{ CategoryId= 3, Name ="Bakery",  Description = "Bakery"},

              };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            if(categories !=null && categories.Count >0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }
        public void EditCategory(Category category)
        {

            var editCategory = GetCategoriesById(category.CategoryId);
            if (editCategory != null)
            {
                editCategory = category;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoriesById(int CategoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == CategoryId);
        }

        public void DeleteCategory(int CategoryId)
        {

            categories?.Remove(GetCategoriesById(CategoryId));
           
        }


    }
}