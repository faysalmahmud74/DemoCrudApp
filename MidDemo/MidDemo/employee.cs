//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MidDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.product = new HashSet<product>();
        }
    
        public int eid { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string nationality { get; set; }
        public string type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
    }
}
