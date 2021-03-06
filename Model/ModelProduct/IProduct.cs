﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelProduct
{
    public interface IProduct
    {
        void Add(string productId, string productName, decimal productCost, decimal productPrice);
        Product Search(string productId);
        void Update(string productId, string productName, decimal productCost, decimal productPrice);
        void Delete(String productId);
        List<Product> List();
    }
}
