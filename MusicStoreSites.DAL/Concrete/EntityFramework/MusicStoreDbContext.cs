﻿using MusicStoreSites.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreSites.DAL.Concrete.EntityFramework
{
    public class MusicStoreDbContext:DbContext
    {
        public MusicStoreDbContext():base("server=.;database=MusicStoreSitesDB;integrated security=true;")
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<User> UserDetails { get; set; }







    }
}
