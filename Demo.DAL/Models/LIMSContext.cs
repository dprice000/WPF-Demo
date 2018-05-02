using System;
using System.Data.Entity;

namespace Demo.DAL
{
    public class LIMSContext : DbContext, ILIMSContext
    {
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
