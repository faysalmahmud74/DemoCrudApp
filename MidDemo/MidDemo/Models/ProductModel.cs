using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MidDemo.Models
{
    public class ProductModel
    {
        public int pid { get; set; }
       
        [Display(Name = "Enter product name")]
        public string name { get; set; }

        public Nullable<System.DateTime> expiredate { get; set; }
        [Display(Name = "Enter your price")]
        public Nullable<double> price { get; set; }
        [Display(Name = "Enter number of products ")]
        public Nullable<int> quantity { get; set; }
        public string descr { get; set; }

        public virtual employee employee { get; set; }

    }
}