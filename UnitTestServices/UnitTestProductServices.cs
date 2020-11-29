using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.ServiceProduct;

namespace UnitTestServices
{
    [TestClass]
    public class UnitTestProductServices
    {
        ProductServices productServices;

        [TestInitialize]
        public void ProductServicesInitialise()
        {
            productServices = new ProductServices();
        }

        [TestMethod]
        public void TestMethodAdd()
        {
            productServices.Add("ABC123", "Eraser", (decimal)10.00, (decimal)15.00);
        }

        [TestMethod]
        public void TestMethodList()
        {
            productServices.List();
        }
    }
}
