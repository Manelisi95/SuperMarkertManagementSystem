using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Repositories;

namespace UseCases
{
    class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.DeleteCategory(category);
        }
    }
}
