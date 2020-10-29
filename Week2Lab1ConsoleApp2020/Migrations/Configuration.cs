namespace Week2Lab1ConsoleApp2020.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
  

    internal sealed class Configuration : DbMigrationsConfiguration<Week2Lab1ConsoleApp2020.DbBusinessContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Week2Lab1ConsoleApp2020.DbBusinessContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Categories.AddOrUpdate(new Category[]
                {
                    new Category { CategoryID= 1, Description="Hardware"},
                    new Category{ CategoryID = 2, Description="Electrical Appliances"}
                });
            context.SaveChanges();

            context.Products.AddOrUpdate(new Product[]
            {
                new Product{ProductID = 1, datefirstIssued = DateTime.Parse("07/12/2019"),
                    description ="9 inch nails", unitPrice = 0.10f, quantityinStock = 200, CategoryID = 1, 
                    Fk_Category = context.Categories.FirstOrDefault(c => c.CategoryID == 1)
                },

                new Product{ProductID = 2, datefirstIssued = DateTime.Parse("15/12/2019"),
                    description = "9 inch bolts", unitPrice = 0.20f, quantityinStock = 120, CategoryID = 1,
                    Fk_Category = context.Categories.FirstOrDefault(c => c.CategoryID == 1)
                },

                new Product{ProductID = 3, datefirstIssued = DateTime.Parse("10/12/2019"),
                    description = "Chimney Hoover", unitPrice = 100.50f, quantityinStock = 10, CategoryID = 2,
                    Fk_Category = context.Categories.FirstOrDefault(c => c.CategoryID == 2)
                },

                new Product{ProductID = 4, datefirstIssued = DateTime.Parse("09/12/2019"),
                    description = "Washing Machine", unitPrice = 399.99f, quantityinStock = 7, CategoryID = 2,
                    Fk_Category = context.Categories.FirstOrDefault(c => c.CategoryID == 2)
                }
            });
            context.SaveChanges();

            context.Suppliers.AddOrUpdate(new Supplier[]
            {
                new Supplier{SupplierID = 1, SupplierName = "Joe Bloggs", SupplierAdd1 = "The Coop", SupplierAdd2 = "Coopersville"},
                new Supplier{SupplierID = 2, SupplierName = "Mary Quant", SupplierAdd1 = "Priory Road", SupplierAdd2 = "Paris"}
            });
            context.SaveChanges();

            context.SupplierProducts.AddOrUpdate(new SupplierProduct[]
            {
                new SupplierProduct{SupplierID = 1, ProductID = 1, datefirstSupplied = DateTime.Parse("07/12/2019"), Fk_Supplier = context.Suppliers.FirstOrDefault(f => f.SupplierID == 1), Fk_Product = context.Products.First(s => s.ProductID == 1)},
                new SupplierProduct{SupplierID = 1, ProductID = 2, datefirstSupplied = DateTime.Parse("15/12/2019"), Fk_Supplier = context.Suppliers.FirstOrDefault(f => f.SupplierID == 2), Fk_Product = context.Products.First(s => s.ProductID == 2)},
                new SupplierProduct{SupplierID = 2, ProductID = 3, datefirstSupplied = DateTime.Parse("10/12/2019"), Fk_Supplier = context.Suppliers.FirstOrDefault(f => f.SupplierID == 3), Fk_Product = context.Products.First(s => s.ProductID == 3)},
                new SupplierProduct{SupplierID = 2, ProductID = 4, datefirstSupplied = DateTime.Parse("09/12/2019"), Fk_Supplier = context.Suppliers.FirstOrDefault(f => f.SupplierID == 4), Fk_Product = context.Products.First(s => s.ProductID == 4)}
            });
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
