using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="# In Stock")]
        public int  InventoryCount { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name="It is food")]
        public bool IsFood { get; set; }

    }
}