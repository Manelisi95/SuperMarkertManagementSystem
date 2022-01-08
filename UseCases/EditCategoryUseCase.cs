using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Repositories;

namespace UseCases
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.EditCategory(category);
        }
    }
}
