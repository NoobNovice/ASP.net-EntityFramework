//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppEntity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productAmount { get; set; }
        public int categoryID { get; set; }
    
        public virtual category category { get; set; }
    }
}
