//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pfapp.AdminPanel.ParfumUI.DataModelMsSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoryToParfum
    {
        public int Id { get; set; }
        public Nullable<int> ParfumId { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Catogory Catogory { get; set; }
        public virtual Parfume Parfume { get; set; }
    }
}