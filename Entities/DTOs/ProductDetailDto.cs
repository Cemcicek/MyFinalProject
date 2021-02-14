using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Core.Entities
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }


    
    }
}
