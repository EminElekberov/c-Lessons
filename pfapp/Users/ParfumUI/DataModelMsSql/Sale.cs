//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pfapp.Users.ParfumUI.DataModelMsSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public int SalePriceId { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> Total { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual SalePrice SalePrice { get; set; }
        public virtual User User { get; set; }
    }
}