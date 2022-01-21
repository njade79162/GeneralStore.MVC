using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Display(Name = "Customer")]
        public virtual int CustomerID { get; set; }
        
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [Display(Name = "Product")]
        public virtual int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}