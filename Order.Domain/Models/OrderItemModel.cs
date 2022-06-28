using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public class OrderItemModel : EntityBase
    {
        public ProductModel Product { get; set; }
        
        public decimal SelValue { get; set; }
        
        public int Quantity { get; set; }

        public decimal TotalAmout { get; set; }
        
            
    
    }
}