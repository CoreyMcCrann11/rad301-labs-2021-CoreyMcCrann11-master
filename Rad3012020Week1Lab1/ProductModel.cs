using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad3012020Week1Lab1
{
    public class ProductModel
    {
        public List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductID = 1,
                Description = "9 inch Nails",
                QuantityInStock = 200,
                UnitPrice = (float)0.10,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 2,
                Description = "9 inch bolts",
                QuantityInStock = 120,
                UnitPrice = (float)0.20,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 3,
                Description = "Chimney Hoover",
                QuantityInStock = 10,
                UnitPrice = (float)100.50,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 4,
                Description = "Washing machine",
                QuantityInStock = 7,
                UnitPrice = (float)399.99,
                CategoryID = 2
            }


        };
        public List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier
            {
                SupplierID = 1,
                SupplierName = "Parts 1",
                SupplierAddressLine1 = "addr 11",
                Addressline2 = "addr 21"
            },
            new Supplier
            {
                SupplierID = 2,
                SupplierName = "Parts 2",
                SupplierAddressLine1 = "addr 11",
                Addressline2 = "addr 21"
            }
        };
        public List<Category> categories = new List<Category>
        {
            new Category
            {
                CategoryDesc = "hardware",
                CategoryID = 1
            },
            new Category
            {
                CategoryDesc = "Electrical Appliences",
                CategoryID = 2
            }
        };
        public List<SupplierProduct> suppplier_products = new List<SupplierProduct>
        {
           new SupplierProduct
           {
               SupplierID = 1,
               ProductID = 1,
               dateFirstSupplied = new DateTime(12/12/2012)
           },
            new SupplierProduct
           {
               SupplierID = 1,
               ProductID = 2,
               dateFirstSupplied = new DateTime(06/01/2013)
           },
            new SupplierProduct
           {
               SupplierID = 2,
               ProductID = 3,
               dateFirstSupplied = new DateTime(09/09/2017)
           },new SupplierProduct
           {

               SupplierID = 2,
               ProductID = 4,
               dateFirstSupplied = new DateTime(10/09/2017)
           },

        };
    };
        public class Supplier
        {
            public int SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string SupplierAddressLine1 { get; set; }
            public string Addressline2 { get; set; }

            public override string ToString()
            {
                return String.Concat(new string[]
                {
                " supplier ID ", SupplierID.ToString()," Supplier Name ", SupplierName,
                " Addr1 ", SupplierAddressLine1," addr2 ",Addressline2
                 });
            }

        }

        public class Product
        {
            
            public int ProductID { get; set; }
            public string Description { get; set; }
            public float UnitPrice { get; set; }
            public int QuantityInStock { get; set; }

            public int CategoryID { get; set; }

        }

        public class Category
        {
            
            public int CategoryID { get; set; }
            public string CategoryDesc { get; set; }
        }

        public class SupplierProduct
        {
            
            public int SupplierID { get; set; }

            public int ProductID { get; set; }
            
            public DateTime dateFirstSupplied { get; set; }


        }
}

