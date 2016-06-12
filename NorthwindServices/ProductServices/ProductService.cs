using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using NorthwindContracts.ServiceContracts; 

namespace NorthwindServices.ProductServices
{
    [ServiceBehavior(Name = "ProductService", Namespace = "http://northwind.com/productservice")] 
    public  class ProductService : IProductService 
    {
        public string GetProductName(int productID)
        {
            return "Aniseed Syrup";
        }

        public int GetProductQty(int productID)
        {
            return 13;
        }
    }
}
