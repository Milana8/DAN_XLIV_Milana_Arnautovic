//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zadatak_1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string Username { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
    }
}