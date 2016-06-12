using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using NorthwindContracts.DataContracts; 

namespace NorthwindContracts.ServiceContracts
{
    [ServiceContract(Name = "CategoryService", Namespace = "http://northwind.com/categoryservice")]
    public interface ICategoryService
    {
        [OperationContract]
        string GetCategoryName(int categoryID);

        [OperationContract]
        Category GetCategoryDetails(int categoryID);
    }
}
