﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LBA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lba_testEntities1 : DbContext
    {
        public lba_testEntities1()
            : base("name=lba_testEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_Limit> T_Limit { get; set; }
        public virtual DbSet<T_Nationality> T_Nationality { get; set; }
        public virtual DbSet<T_Operation> T_Operation { get; set; }
        public virtual DbSet<T_OperationType> T_OperationType { get; set; }
        public virtual DbSet<T_Person> T_Person { get; set; }
    }
}