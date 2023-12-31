﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rc_service.Models;

#nullable disable

namespace Rc_service.Migrations
{
    [DbContext(typeof(rcserviceContext))]
    [Migration("20230615220139_BDmigration")]
    partial class BDmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Rc_service.Models.Contratacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EstadosId")
                        .HasColumnType("int")
                        .HasColumnName("Estados_Id");

                    b.Property<int>("OfertasIdOfertas")
                        .HasColumnType("int")
                        .HasColumnName("Ofertas_Id_Ofertas");

                    b.HasKey("Id");

                    b.HasIndex("EstadosId");

                    b.HasIndex("OfertasIdOfertas");

                    b.ToTable("Contratacion", (string)null);
                });

            modelBuilder.Entity("Rc_service.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoEstado")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Tipo_Estado");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Rc_service.Models.Inmueble", b =>
                {
                    b.Property<int>("IdInmueble")
                        .HasColumnType("int")
                        .HasColumnName("Id_Inmueble");

                    b.Property<string>("DetallesInmueble")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Detalles_Inmueble");

                    b.Property<string>("PropietariosIdPropietario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Propietarios_Id_Propietario");

                    b.Property<string>("TipoInmueble")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Tipo_Inmueble");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int")
                        .HasColumnName("Ubicacion_Id");

                    b.HasKey("IdInmueble")
                        .HasName("PK__Inmueble__DB51280D21ABBE03");

                    b.HasIndex("PropietariosIdPropietario");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Inmuebles");
                });

            modelBuilder.Entity("Rc_service.Models.Logeo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Logeo", (string)null);
                });

            modelBuilder.Entity("Rc_service.Models.Oferta", b =>
                {
                    b.Property<int>("IdOfertas")
                        .HasColumnType("int")
                        .HasColumnName("Id_Ofertas");

                    b.Property<int>("InmueblesIdInmueble")
                        .HasColumnType("int")
                        .HasColumnName("Inmuebles_Id_Inmueble");

                    b.Property<int>("ServiciosIdServicio")
                        .HasColumnType("int")
                        .HasColumnName("Servicios_Id_Servicio");

                    b.HasKey("IdOfertas")
                        .HasName("PK__Ofertas__C41D869B0AF968BA");

                    b.HasIndex("InmueblesIdInmueble");

                    b.HasIndex("ServiciosIdServicio");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("Rc_service.Models.PrestadoresDeServicio", b =>
                {
                    b.Property<string>("IdPrestador")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Id_Prestador");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LastnamePrestador")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Lastname_Prestador");

                    b.Property<string>("NamePrestador")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Name_Prestador");

                    b.Property<int>("ServiciosIdServicio")
                        .HasColumnType("int")
                        .HasColumnName("Servicios_Id_Servicio");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int")
                        .HasColumnName("Ubicacion_Id");

                    b.HasKey("IdPrestador")
                        .HasName("PK__Prestado__25950CC5C9132033");

                    b.HasIndex("ServiciosIdServicio");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Prestadores_de_servicios", (string)null);
                });

            modelBuilder.Entity("Rc_service.Models.Propietario", b =>
                {
                    b.Property<string>("IdPropietario")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Id_Propietario");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LastnamePropietario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Lastname_Propietario");

                    b.Property<string>("NamePropietario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Name_Propietario");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int")
                        .HasColumnName("Ubicacion_Id");

                    b.HasKey("IdPropietario")
                        .HasName("PK__Propieta__7360E97D53E2D633");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("Rc_service.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Servicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"), 1L, 1);

                    b.Property<string>("DetallesServicio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Detalles_Servicio");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Tipo_Servicio");

                    b.HasKey("IdServicio")
                        .HasName("PK__Servicio__5B1345F06B68D6DB");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Rc_service.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Ubicacion", (string)null);
                });

            modelBuilder.Entity("Rc_service.Models.Contratacion", b =>
                {
                    b.HasOne("Rc_service.Models.Estado", "Estados")
                        .WithMany("Contratacions")
                        .HasForeignKey("EstadosId")
                        .IsRequired()
                        .HasConstraintName("FK__Contratac__Estad__4E88ABD4");

                    b.HasOne("Rc_service.Models.Oferta", "OfertasIdOfertasNavigation")
                        .WithMany("Contratacions")
                        .HasForeignKey("OfertasIdOfertas")
                        .IsRequired()
                        .HasConstraintName("FK__Contratac__Ofert__4D94879B");

                    b.Navigation("Estados");

                    b.Navigation("OfertasIdOfertasNavigation");
                });

            modelBuilder.Entity("Rc_service.Models.Inmueble", b =>
                {
                    b.HasOne("Rc_service.Models.Propietario", "PropietariosIdPropietarioNavigation")
                        .WithMany("Inmuebles")
                        .HasForeignKey("PropietariosIdPropietario")
                        .IsRequired()
                        .HasConstraintName("FK__Inmuebles__Propi__3F466844");

                    b.HasOne("Rc_service.Models.Ubicacion", "Ubicacion")
                        .WithMany("Inmuebles")
                        .HasForeignKey("UbicacionId")
                        .IsRequired()
                        .HasConstraintName("FK__Inmuebles__Ubica__3E52440B");

                    b.Navigation("PropietariosIdPropietarioNavigation");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Rc_service.Models.Oferta", b =>
                {
                    b.HasOne("Rc_service.Models.Inmueble", "InmueblesIdInmuebleNavigation")
                        .WithMany("Oferta")
                        .HasForeignKey("InmueblesIdInmueble")
                        .IsRequired()
                        .HasConstraintName("FK__Ofertas__Inmuebl__47DBAE45");

                    b.HasOne("Rc_service.Models.Servicio", "ServiciosIdServicioNavigation")
                        .WithMany("Oferta")
                        .HasForeignKey("ServiciosIdServicio")
                        .IsRequired()
                        .HasConstraintName("FK__Ofertas__Servici__48CFD27E");

                    b.Navigation("InmueblesIdInmuebleNavigation");

                    b.Navigation("ServiciosIdServicioNavigation");
                });

            modelBuilder.Entity("Rc_service.Models.PrestadoresDeServicio", b =>
                {
                    b.HasOne("Rc_service.Models.Servicio", "ServiciosIdServicioNavigation")
                        .WithMany("PrestadoresDeServicios")
                        .HasForeignKey("ServiciosIdServicio")
                        .IsRequired()
                        .HasConstraintName("FK__Prestador__Servi__44FF419A");

                    b.HasOne("Rc_service.Models.Ubicacion", "Ubicacion")
                        .WithMany("PrestadoresDeServicios")
                        .HasForeignKey("UbicacionId")
                        .IsRequired()
                        .HasConstraintName("FK__Prestador__Ubica__440B1D61");

                    b.Navigation("ServiciosIdServicioNavigation");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Rc_service.Models.Propietario", b =>
                {
                    b.HasOne("Rc_service.Models.Ubicacion", "Ubicacion")
                        .WithMany("Propietarios")
                        .HasForeignKey("UbicacionId")
                        .IsRequired()
                        .HasConstraintName("FK__Propietar__Ubica__3B75D760");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Rc_service.Models.Estado", b =>
                {
                    b.Navigation("Contratacions");
                });

            modelBuilder.Entity("Rc_service.Models.Inmueble", b =>
                {
                    b.Navigation("Oferta");
                });

            modelBuilder.Entity("Rc_service.Models.Oferta", b =>
                {
                    b.Navigation("Contratacions");
                });

            modelBuilder.Entity("Rc_service.Models.Propietario", b =>
                {
                    b.Navigation("Inmuebles");
                });

            modelBuilder.Entity("Rc_service.Models.Servicio", b =>
                {
                    b.Navigation("Oferta");

                    b.Navigation("PrestadoresDeServicios");
                });

            modelBuilder.Entity("Rc_service.Models.Ubicacion", b =>
                {
                    b.Navigation("Inmuebles");

                    b.Navigation("PrestadoresDeServicios");

                    b.Navigation("Propietarios");
                });
#pragma warning restore 612, 618
        }
    }
}
