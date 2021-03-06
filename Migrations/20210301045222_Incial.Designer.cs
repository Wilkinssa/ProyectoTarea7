// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoTarea6.DAL;

namespace ProyectoTarea6.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210301045222_Incial")]
    partial class Incial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ProyectoTarea6.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionPermiso")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePermiso")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisoID");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoID = 1,
                            DescripcionPermiso = "Este permiso puede modificar el precio",
                            NombrePermiso = "Descuenta",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoID = 2,
                            DescripcionPermiso = "Este permiso puede vender productos",
                            NombrePermiso = "Vende",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoID = 3,
                            DescripcionPermiso = "Este permiso puede cobrar dinero",
                            NombrePermiso = "Cobra",
                            VecesAsignado = 0
                        });
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.Roles", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("RolID");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AliasUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.Permisos", b =>
                {
                    b.HasOne("ProyectoTarea6.Entidades.Permisos", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permiso");
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("ProyectoTarea6.Entidades.Roles", null)
                        .WithMany("Detalle")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoTarea6.Entidades.Roles", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
