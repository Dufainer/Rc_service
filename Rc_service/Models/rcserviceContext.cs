using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Rc_service.Models
{
    public partial class rcserviceContext : DbContext
    {
        public rcserviceContext()
        {
        }

        public rcserviceContext(DbContextOptions<rcserviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contratacion> Contratacions { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Inmueble> Inmuebles { get; set; } = null!;
        public virtual DbSet<Logeo> Logeos { get; set; } = null!;
        public virtual DbSet<Oferta> Ofertas { get; set; } = null!;
        public virtual DbSet<PrestadoresDeServicio> PrestadoresDeServicios { get; set; } = null!;
        public virtual DbSet<Propietario> Propietarios { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Ubicacion> Ubicacions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=rcservice;integrated security=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contratacion>(entity =>
            {
                entity.ToTable("Contratacion");

                entity.Property(e => e.EstadosId).HasColumnName("Estados_Id");

                entity.Property(e => e.OfertasIdOfertas).HasColumnName("Ofertas_Id_Ofertas");

                entity.HasOne(d => d.Estados)
                    .WithMany(p => p.Contratacions)
                    .HasForeignKey(d => d.EstadosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contratac__Estad__4E88ABD4");

                entity.HasOne(d => d.OfertasIdOfertasNavigation)
                    .WithMany(p => p.Contratacions)
                    .HasForeignKey(d => d.OfertasIdOfertas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contratac__Ofert__4D94879B");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.TipoEstado)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Estado");
            });

            modelBuilder.Entity<Inmueble>(entity =>
            {
                entity.HasKey(e => e.IdInmueble)
                    .HasName("PK__Inmueble__DB51280D21ABBE03");

                entity.Property(e => e.IdInmueble)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Inmueble");

                entity.Property(e => e.DetallesInmueble)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Detalles_Inmueble");

                entity.Property(e => e.PropietariosIdPropietario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Propietarios_Id_Propietario");

                entity.Property(e => e.TipoInmueble)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Inmueble");

                entity.Property(e => e.UbicacionId).HasColumnName("Ubicacion_Id");

                entity.HasOne(d => d.PropietariosIdPropietarioNavigation)
                    .WithMany(p => p.Inmuebles)
                    .HasForeignKey(d => d.PropietariosIdPropietario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inmuebles__Propi__3F466844");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.Inmuebles)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inmuebles__Ubica__3E52440B");
            });

            modelBuilder.Entity<Logeo>(entity =>
            {
                entity.ToTable("Logeo");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oferta>(entity =>
            {
                entity.HasKey(e => e.IdOfertas)
                    .HasName("PK__Ofertas__C41D869B0AF968BA");

                entity.Property(e => e.IdOfertas)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Ofertas");

                entity.Property(e => e.InmueblesIdInmueble).HasColumnName("Inmuebles_Id_Inmueble");

                entity.Property(e => e.ServiciosIdServicio).HasColumnName("Servicios_Id_Servicio");

                entity.HasOne(d => d.InmueblesIdInmuebleNavigation)
                    .WithMany(p => p.Oferta)
                    .HasForeignKey(d => d.InmueblesIdInmueble)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ofertas__Inmuebl__47DBAE45");

                entity.HasOne(d => d.ServiciosIdServicioNavigation)
                    .WithMany(p => p.Oferta)
                    .HasForeignKey(d => d.ServiciosIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ofertas__Servici__48CFD27E");
            });

            modelBuilder.Entity<PrestadoresDeServicio>(entity =>
            {
                entity.HasKey(e => e.IdPrestador)
                    .HasName("PK__Prestado__25950CC5C9132033");

                entity.ToTable("Prestadores_de_servicios");

                entity.Property(e => e.IdPrestador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Id_Prestador");

                entity.Property(e => e.Celular)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastnamePrestador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Lastname_Prestador");

                entity.Property(e => e.NamePrestador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Name_Prestador");

                entity.Property(e => e.ServiciosIdServicio).HasColumnName("Servicios_Id_Servicio");

                entity.Property(e => e.UbicacionId).HasColumnName("Ubicacion_Id");

                entity.HasOne(d => d.ServiciosIdServicioNavigation)
                    .WithMany(p => p.PrestadoresDeServicios)
                    .HasForeignKey(d => d.ServiciosIdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prestador__Servi__44FF419A");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.PrestadoresDeServicios)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prestador__Ubica__440B1D61");
            });

            modelBuilder.Entity<Propietario>(entity =>
            {
                entity.HasKey(e => e.IdPropietario)
                    .HasName("PK__Propieta__7360E97D53E2D633");

                entity.Property(e => e.IdPropietario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Id_Propietario");

                entity.Property(e => e.Celular)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastnamePropietario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Lastname_Propietario");

                entity.Property(e => e.NamePropietario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Name_Propietario");

                entity.Property(e => e.UbicacionId).HasColumnName("Ubicacion_Id");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Propietar__Ubica__3B75D760");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__5B1345F06B68D6DB");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.DetallesServicio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Detalles_Servicio");

                entity.Property(e => e.TipoServicio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Servicio");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.ToTable("Ubicacion");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
