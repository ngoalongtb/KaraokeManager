﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaraokeManager.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppDB : DbContext
    {
        public AppDB()
            : base("name=AppDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Music> Musics { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderFood> OrderFoods { get; set; }
        public virtual DbSet<OrderMusic> OrderMusics { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
