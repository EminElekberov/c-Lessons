//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pfapp.Employee.ParfumUI.DataModelMsSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalePrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalePrice()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int Id { get; set; }
        public int SizeId { get; set; }
        public int Price { get; set; }
        public int number { get; set; }
        public Nullable<int> ParfumId { get; set; }
    
        public virtual Parfume Parfume { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual Size Size { get; set; }
    }
}
