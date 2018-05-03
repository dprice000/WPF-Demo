using Demo.DAL.Models;
using System;
using System.Data.Entity;

namespace Demo.DAL
{
    public interface ILIMSContext
    {
        DbSet<Measurement> Measurements { get; set; }
        DbSet<User> Users { get; set; }
    }
}
