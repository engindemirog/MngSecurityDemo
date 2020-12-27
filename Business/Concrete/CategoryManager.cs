using Business.Abstract;
using Core.Uilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.BusinessAspects.Autofac;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [SecuredOperation("category.read")]
        public IDataResult<IList<Category>> GetAll()
        {
            return new SuccessDataResult<IList<Category>>(_categoryDal.GetList());
        }
    }
}
