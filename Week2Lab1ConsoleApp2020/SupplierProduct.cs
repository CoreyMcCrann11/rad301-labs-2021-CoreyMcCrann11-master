using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    public class SupplierProduct
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Fk_Supplier")]
        public int SupplierID { get; set; }
        /// /////////////////////
        [Key, Column(Order = 1)]
        [ForeignKey("Fk_Product")]
        public int ProductID { get; set; }
        /// <summary>
        /// ////////////////////////////
        /// </summary>
        public DateTime datefirstSupplied { get; set; }
        public virtual Supplier Fk_Supplier { get; set; }

        public virtual Product Fk_Product { get; set; }
    }
}
