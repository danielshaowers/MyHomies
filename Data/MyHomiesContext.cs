﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyHomies.Models;

namespace MyHomies.Models
{
    public class MyHomiesContext : DbContext
    {
        public MyHomiesContext (DbContextOptions<MyHomiesContext> options)
            : base(options)
        {
        }

        public DbSet<MyHomies.Models.Item> Item { get; set; }

        public DbSet<MyHomies.Models.User> User { get; set; }
    }
}
