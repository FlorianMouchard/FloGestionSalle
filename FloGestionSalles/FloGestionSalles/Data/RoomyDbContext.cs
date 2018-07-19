﻿using FloGestionSalles.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Data
{
    public class RoomyDbContext : DbContext
    {
        public RoomyDbContext() : base("Roomix")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Civility> Civilities { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}