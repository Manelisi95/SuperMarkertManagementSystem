using CoreBusiness;
using System.Collections.Generic;
using UseCases.Repositories;

namespace UseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepositry;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepositry)
        {
            this.categoryRepositry = categoryRepositry;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepositry.GetCategories();
        }
    }
}
