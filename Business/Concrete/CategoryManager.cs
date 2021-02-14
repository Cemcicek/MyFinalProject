using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // İş kodları
            return _categoryDal.GetAll();
        }

        // select * from Categories where CategoryId = 3 - aşagıda ki kodun sql anlamı
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
