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

        [Required]
        public int CustomerID { get; set; }
        [Required]

        public int ProductID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }

    }
}