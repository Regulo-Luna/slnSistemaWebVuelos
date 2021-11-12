using SistemaWebVuelos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Data
{
    public class VueloDbContext : DbContext
    {
        public VueloDbContext() : base("KeyDB") { }
        public DbSet<Vuelo> Vuelos { get; set; }

    }
}