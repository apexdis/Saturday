using System;
using Services.ServiceProduct;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServices productServices = new ProductServices();
            productServices.Add("ABC123", "Computer Pentium", (decimal)45000.00, (decimal)50000.00);
            productServices.Add("ABC124", "Computer i3", (decimal)75000.00, (decimal)90000.00);
            productServices.Add("ABC125", "Computer i5", (decimal)125000.00, (decimal)150000.00);
            productServices.Add("ABC126", "Computer i7", (decimal)150000.00, (decimal)175000.00);

            var listProduct = productServices.List();

            foreach (var item in listProduct)
            {
                Console.WriteLine(item.ProductId + "  " + item.ProductName + "  " + item.ProductCost.ToString("N2") + "  " + item.ProductPrice.ToString("N2"));
            }


            Console.ReadKey();

        }
    }
}
