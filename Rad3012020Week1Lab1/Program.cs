using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityTracker;

namespace Rad3012020Week1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity.Track("Designing Classes Model");

            ProductModel ProductModel = new ProductModel();
            Console.WriteLine("Question 8 To be answered");
            var allCategories = ProductModel.categories
                .OrderByDescending(n => n.CategoryDesc);
            
            foreach (var item in allCategories)
                Console.WriteLine("List of Categories {0}", item.CategoryDesc);
            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Now onto Question 9");
            var allProducts = ProductModel.Products
                .OrderByDescending(p => p.Description);

            foreach (var products in allProducts)
                Console.WriteLine("List of All Products {0}", products.Description);         
            ////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("QUESTION 10: ALL PRODUCTS WITH A QUANTITY GREATER THAN 100");
            foreach (var products in allProducts)
                if (products.QuantityInStock > 100)
                {
                    Console.WriteLine("Product Name: {0}", products.Description);
                }
            /////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("QUESTION 11:");
            
                
                
       
        }
    }
}
