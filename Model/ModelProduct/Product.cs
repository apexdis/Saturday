using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelProduct
{
    public class Product
    {
        public string ProductId 
        {
            get { return ProductId; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("Prodcut ID is not entered!");
                }

                ProductId = value; 
            
            }
        }

        public string ProductName 
        {
            get { return ProductName; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("Product Name is not entered!");
                }
                else if (value.Length > 20)
                {
                    throw new Exception("You cannot enter more than 20 character!");
                }

                ProductName = value; 
            } 
        }
        public decimal ProductCost { get; set; }
        public decimal ProductPrice { get; set; }

    }
}
