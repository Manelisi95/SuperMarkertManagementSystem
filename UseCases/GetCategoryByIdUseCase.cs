using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Repositories;

namespace UseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(int CategoryId)
        {
          return  categoryRepository.GetCategoriesById(CategoryId);

        }
    }
}
