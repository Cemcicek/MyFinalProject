using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    // public -> bu classa diğer katmanlarda ulaşabilsin demek.
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
