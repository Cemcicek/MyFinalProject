using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstarct
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
