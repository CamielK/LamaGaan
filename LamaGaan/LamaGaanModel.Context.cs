﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LamaGaanModelContainer : DbContext
    {
        public LamaGaanModelContainer()
            : base("name=LamaGaanModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Werkrooster> Werkrooster { get; set; }
        public virtual DbSet<Taak> Taak { get; set; }
        public virtual DbSet<Dier> Dier { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Persoon> Persoon { get; set; }
        public virtual DbSet<VerkoopOrder> VerkoopOrderSet { get; set; }
        public virtual DbSet<Evenement> Evenement { get; set; }
        public virtual DbSet<Reservering> Reservering { get; set; }
    }
}
