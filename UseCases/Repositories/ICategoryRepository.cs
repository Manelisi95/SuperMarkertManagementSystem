﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Repositories
{
   public interface ICategoryRepository
    {
         IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void EditCategory(Category category);

    }
}
