using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Add Product Details
        /// </summary>
        /// <param name="productId">Enter Product ID (String)</param>
        /// <param name="productName">Enter Product Name (String)</param>
        /// <param name="productCost">Enter Product Cost (Decimal Value)</param>
        /// <param name="productPrice">Enter Product Price (Decimal Value)</param>
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

        public List<Product> List()
        {
            try
            {
                return products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product Search(string productId)
        {
            throw new NotImplementedException();
        }

        public void Update(string productId, string productName, decimal productCost, decimal ProductPrice)
        {
            throw new NotImplementedException();
        }
        
    }
}
