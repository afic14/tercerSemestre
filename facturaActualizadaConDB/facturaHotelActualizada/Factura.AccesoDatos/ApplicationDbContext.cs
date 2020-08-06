using Factura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.AccesoDatos
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteHotel>()
               .ToTable("ClienteHotel")
               .HasKey(c => new { c.ClienteId, c.HotelId });
            modelBuilder.Entity<HabitacionFactura>()
               .ToTable("HabitacionFactura")
               .HasKey(h => new { h.HabitacionId, h.FacturaId });
            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .HasKey(c => new { c.ClienteId });
            modelBuilder.Entity<Recepcionista>()
                .ToTable("Recepcionista")
                .HasKey(r => new { r.RecepcionistaId });
            modelBuilder.Entity<Hotel>()
                .ToTable("Hotel")
                .HasKey(h => new { h.HotelId });
            modelBuilder.Entity<Factur>()
                .ToTable("Factura")
                .HasKey(f => new { f.FacturaId });
            modelBuilder.Entity<Habitacion>()
                .ToTable("Habitacion")
                .HasKey(h => new { h.HabitacionId });
        }
        public DbSet<ClienteHotel> ClienteHoteles { get; set; }
        public DbSet<HabitacionFactura> HabitacionFacturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Hotel> Hoteles { get; set; }
        public DbSet<Factur> Factura { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
