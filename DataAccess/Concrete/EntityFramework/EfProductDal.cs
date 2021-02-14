﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NortwindContext context = new NortwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto 
                             {   ProductId = p.ProductId, 
                                 ProductName = p.ProductName, 
                                 CategoryName = c.CategoryName, 
                                 UnitsInStock = p.UnitsInStock 
                             };
                return result.ToList();
            }
            
        }
    }
}
