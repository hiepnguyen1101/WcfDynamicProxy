using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;  

namespace NorthwindContracts.ServiceContracts
{
    [ServiceContract(Name = "ProductService", Namespace = "http://northwind.com/productservice" )]
    public interface IProductService
    {
        [OperationContract] 
        string GetProductName(int productID);

        [OperationContract]
        int GetProductQty(int productID);
    }
}
