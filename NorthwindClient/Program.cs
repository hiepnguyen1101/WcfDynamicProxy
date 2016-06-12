using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindContracts.DataContracts;   
using NorthwindContracts.ServiceContracts;   

namespace NorthwindClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CategoryServiceClient.GetCategoryName(10));


            Category category = CategoryServiceClient.GetCategoryDetails(10);
            if (category != null)
            {
                Console.WriteLine("Category ID " + category.CategoryID);
                Console.WriteLine("Category Name: " + category.CategoryName);
                Console.WriteLine("Category Description:" + category.CategoryDescription);
                Console.WriteLine("Category URL: " + category.CategoryURL); 
            }

            Console.Read();             
        }
    }
}
