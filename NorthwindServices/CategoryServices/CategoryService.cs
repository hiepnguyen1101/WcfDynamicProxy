using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindContracts.DataContracts;
using NorthwindContracts.ServiceContracts;
using System.ServiceModel;  

namespace NorthwindServices.CategoryServices
{
    [ServiceBehavior(Name = "CategoryService", Namespace = "http://northwind.com/categoryservice")] 
    public class CategoryService : ICategoryService 
    {
        public string GetCategoryName(int categoryID)
        {
            return "Beverages";
        }

        public Category GetCategoryDetails(int categoryID)
        {
            Category category = new Category();
            category.CategoryID = 1;
            category.CategoryName = "Beverages";
            category.CategoryDescription = "Soft drinks, coffees, teas, beers, and ales";
            category.CategoryURL = "http://northwind.com/Beverages"; 

            return category;
        }        
    }
}
