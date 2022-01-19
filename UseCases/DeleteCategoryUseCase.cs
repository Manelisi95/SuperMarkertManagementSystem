using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Repositories;

namespace UseCases
{
   public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(int CategoryId)
        {
            categoryRepository.DeleteCategory(CategoryId);
        }
    }
}
