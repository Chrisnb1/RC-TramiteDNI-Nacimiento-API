using Microsoft.EntityFrameworkCore;
using RC.MS_NacimientoDefuncion.Domain.Entities;
using RC.MS_TramiteDNI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_TramiteDNI.AccessData
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opcion) : base(opcion)
        {

        }
        //Tramite DNI
        public DbSet<TramiteDNI> TramiteDNIs { get; set; }
        public DbSet<NuevoEjemplar> NuevosEjemplares { get; set; }
        public DbSet<Extranjero> Extranjeros { get; set; }
        public DbSet<Nacimiento> Nacimientos { get; set; }

        //Tramite Nacimientos
        public DbSet<TramiteNacimiento> TramiteNacimientos { get; set; }
        public DbSet<RecienNacido> RecienNacidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Parámetros para la tabla NuevoEjemplar.
            modelBuilder.Entity<NuevoEjemplar>(entity =>
            {
                entity.Property(q => q.NuevoEjemplarId).IsRequired().IsUnicode();
                entity.Property(q => q.Descripcion).HasMaxLength(45).IsRequired();
            }
            );

            //Parámetros para la tabla Extranjero.
            modelBuilder.Entity<Extranjero>(entity =>
            {
                entity.Property(q => q.ExtranjeroId).IsRequired().IsUnicode();
                entity.Property(q => q.PaisOrigen).HasMaxLength(45).IsRequired();
            }
            );

            //Parámetros para la tabla Nacimiento.
            modelBuilder.Entity<Nacimiento>(entity =>
            {
                entity.Property(q => q.NacimientoId).IsRequired().IsUnicode();
                entity.Property(q => q.TramiteRecienNacidoId).IsRequired();
            }
            );

            //Tramite DNI
            modelBuilder.Entity<TramiteDNI>(entity =>
            {
                entity.Property(q => q.TramiteDNIid).IsRequired().IsUnicode();

            }
            );

            //Tramite Nacimiento
            modelBuilder.Entity<TramiteNacimiento>(entity =>
            {
                entity.Property(q => q.TramiteNacimientoId).IsRequired().IsUnicode();

            }
            );

            //Recien Nacido

            modelBuilder.Entity<RecienNacido>(entity =>
            {
                entity.Property(q => q.RecienNacidoId).IsRequired().IsUnicode();
                entity.Property(q => q.NumeroActa).IsRequired();
                entity.Property(q => q.Genero).HasMaxLength(250).IsRequired();
                entity.Property(q => q.FechaNacimiento).IsRequired();
                entity.Property(q => q.LugarNacimiento).HasMaxLength(250).IsRequired();
            }
            );
        }
    }
}
