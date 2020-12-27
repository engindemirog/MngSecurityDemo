using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EnitityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EnitityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
       
    }
}
