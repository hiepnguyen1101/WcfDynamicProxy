using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; 
using NorthwindContracts.ServiceContracts;
using NorthwindContracts.DataContracts;     

namespace NorthwindClient
{
    public static class CategoryServiceClient
    {
        public static string GetCategoryName(int categoryID)
        {
            ICategoryService bookproxy = ServiceFactory.Create<ICategoryService>();
            var categoryName = bookproxy.GetCategoryName(categoryID);
            return categoryName;
            //string categoryName = string.Empty;
            //WSHttpBinding myBinding = new WSHttpBinding();
            //EndpointAddress myEndpoint = new EndpointAddress("http://localhost:7741/NorthwindServices/CategoryServices/CategoryService");
            //ChannelFactory<ICategoryService> myChannelFactory = new ChannelFactory<ICategoryService>(myBinding, myEndpoint);

            //ICategoryService instance = myChannelFactory.CreateChannel();

            //categoryName = instance.GetCategoryName(categoryID);

            //myChannelFactory.Close();
            //return categoryName;

        }

        public static Category GetCategoryDetails(int categoryID)
        {
            Category category = new Category();

            WSHttpBinding myBinding = new WSHttpBinding();
            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:7741/NorthwindServices/CategoryServices/CategoryService");
            ChannelFactory<ICategoryService> myChannelFactory = new ChannelFactory<ICategoryService>(myBinding, myEndpoint);

            ICategoryService instance = myChannelFactory.CreateChannel();

            category = instance.GetCategoryDetails(categoryID);                  

            myChannelFactory.Close();

            return category;
        }
    }
}
