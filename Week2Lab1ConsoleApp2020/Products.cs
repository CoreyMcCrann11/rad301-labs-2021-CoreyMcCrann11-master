using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    
        public class Product
        {
            [Key]
            public int ProductID { get; set; }
            public DateTime datefirstIssued { get; set; }

            public string description { get; set; }

            public double unitPrice { get; set; }

            public int quantityinStock { get; set; }
            [ForeignKey("Fk_Category")]
            public int CategoryID { get; set; }

            public virtual Category Fk_Category { get; set; }


        }

        /*public class Category
        {
            [Key]
            public int CategoryID { get; set; }
            public string Description { get; set; }

            public virtual ICollection<Product> Products { get; set; }

            public override string ToString()
            {
                return String.Concat("Category ID:", CategoryID.ToString(),
                    " Description: ", Description);
            }
        } */

        /* public class Supplier
        { 
            [Key]
            public int SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string SupplierAdd1 { get; set; }
            public string SupplierAdd2 { get; set; }
        } */

        /*public class SupplierProduct
        {
            [Key, Column(Order = 0)]
            [ForeignKey("FK_Supplier")]
            public int SupplierID { get; set; }
            /// /////////////////////
            [Key, Column(Order = 1)]
            [ForeignKey("FK_Product")]
            public int ProductID { get; set; }
            /// <summary>
            /// ////////////////////////////
            /// </summary>
            public DateTime datefirstSupplied { get; set; }
            public virtual Supplier FK_Supplier { get; set; }

            public virtual Product FK_Product { get; set; }
        } */

        /* public class DbBusinessContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Supplier> Suppliers { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<SupplierProduct> SupplierProducts { get; set; }

            public DbBusinessContext() : base("ProductDbConnection")
            {

            }
         } */
    
}
