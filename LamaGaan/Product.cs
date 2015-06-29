//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LamaGaan.BU
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Dier = new HashSet<Dier>();
            this.VerkoopOrder = new HashSet<VerkoopOrder>();
            this.InkoopOrder = new HashSet<InkoopOrder>();
        }
    
        public int Id { get; set; }
        public string Naam { get; set; }
        public Nullable<int> MaxVoorraad { get; set; }
        public Nullable<int> HuidigeVoorraad { get; set; }
        public Nullable<int> VerkoopPrijs { get; set; }
        public Nullable<int> InkoopPrijs { get; set; }
        public Nullable<int> MinVoorraad { get; set; }
        public string InkoopWinkel { get; set; }
    
        public virtual ICollection<Dier> Dier { get; set; }
        public virtual ICollection<VerkoopOrder> VerkoopOrder { get; set; }
        public virtual ICollection<InkoopOrder> InkoopOrder { get; set; }
    }
}
