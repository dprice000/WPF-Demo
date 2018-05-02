using System;
using System.Data.Entity;

namespace Demo.DAL.Models
{
    public class LIMSContext : DbContext
    {
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
