using System;
using System.Collections.Generic;
using System.Text;
using Model.ModelProduct;

namespace Services.ServiceProduct
{
    public class ProductServices : IProduct
    {
        List<Product> products;

        public ProductServices()
        {
            products = new List<Product>();
        }

        public void Add(string productId, string productName, decimal productCost, decimal productPrice)
        {
            try
            {
                // Transfer parmeter value to a model. Model become a record
                Product product = new Product()
                {
                    ProductId = productId,
                    ProductName = productName,
                    ProductCost = productCost,
                    ProductPrice = productPrice
                };

                // Add record to list.
                products.Add(product);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(string productId)
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Search(string productId)
        {
            throw new NotImplementedException();
        }

        public void Update(string productId, string productName, decimal productCost, decimal ProductPrice)
        {
            throw new NotImplementedException();
        }
    }
}
