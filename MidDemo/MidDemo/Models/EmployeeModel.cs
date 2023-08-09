using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MidDemo.Models
{
    public class EmployeeModel
    {
        public int eid { get; set; }

        [Required]
        [Display (Name="Enter your name ")]
        public string name { get; set; }
        
        [Required]
        [Display(Name = "Enter your age ")]
        public string age { get; set; }

        [Required]
        [Display(Name = "Enter your date of birth  ")]
        public Nullable<System.DateTime> dob { get; set; }
        [Display(Name = "Enter your gender")]

        public string gender { get; set; }
        
        [Display(Name = "Enter your email")]
        public string email { get; set; }
        [Display(Name = "Enter your phone")]
        public string phone { get; set; }
        public string address { get; set; }
        [Display(Name = "Enter your address")]
        public string nationality { get; set; }
        [Required]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
    }
}