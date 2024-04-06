﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace MVCPracticaUno.Models
{
    public class equiposDbContext : DbContext
    { 
        public equiposDbContext(DbContextOptions options): base(options)
        {
        }
    
        public DbSet<marcas> marcas {  get; set; }
        public DbSet<equipos> equipos { get; set; }
    }
}
