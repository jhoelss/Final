﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tienda.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Tienda.Core;
    
    public partial class FinancieraEntities : DbContext
    {
        public FinancieraEntities()
            : base("name=FinancieraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetallePrestamo> DetallePrestamo { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
    }
}
