using System;
using System.ComponentModel.DataAnnotations;

namespace ProductsWork.Models
{
    public class Product
    {
        
            public int Id  { get; set; }
            public string Name { get; set; }
            public string Description{ get; set; }
            public string Image { get; set; }
            public int Price { get; set; }
            [DataType((DataType.Date))]
            public DateTime ExpiryDate { get; set; }
            public int Quantity { get; set; }
        
        
        
    }
}