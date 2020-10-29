using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity.Track("Implementing Queries");
            //Console.ReadKey();
            List_Categories();
        }
        static void List_Categories()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Category> ListAll = db.Categories.ToList();

                Console.WriteLine("Query 1: Category List :");
                foreach (var category in ListAll)
                {
                    Console.WriteLine("{0}  {1}", category.CategoryID, category.Description);                    
                }
                Console.WriteLine("///////////////////////////////////////////////////"); }
            List_Products();
            
        }

        static void List_Products()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> ListProducts = db.Products.ToList();

                Console.WriteLine("Query 2: Product List :");
                foreach (var product in ListProducts)
                {
                    Console.WriteLine("{0}  {1}", product.ProductID, product.description);
                }
                
            }
            List_products(100);
        }

        static void List_products(int UpperLimit)
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> ListProductLimit = db.Products.ToList();
                Console.WriteLine("Query 3: Products over the determined quantity ");
                foreach (var product in ListProductLimit)
                {
                    if (product.quantityinStock > UpperLimit)
                    {
                        Console.WriteLine("{0}  {1}", product.ProductID, product.description);
                    }
                }
            }
            list_product_value();
            
        }

        static void list_product_value()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                double totalPrice = 0;
                List<Product> ListProductPrice = db.Products.ToList();
                Console.WriteLine("Query 4: Value of all products added up");

                foreach (var product in ListProductPrice)
                {
                    totalPrice = totalPrice + product.unitPrice * product.quantityinStock;
                    Console.WriteLine("Product ID: {0}  Product Name: {1}  Product price: {2}, Quantity: {3}", product.ProductID, product.description, product.unitPrice, product.quantityinStock);
                }
                Console.WriteLine("Total Price of all products : {0}", totalPrice);
            }
            list_category_products("Hardware");
        }

        static void list_category_products(string Category)
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                
            }
        }

        }
}
