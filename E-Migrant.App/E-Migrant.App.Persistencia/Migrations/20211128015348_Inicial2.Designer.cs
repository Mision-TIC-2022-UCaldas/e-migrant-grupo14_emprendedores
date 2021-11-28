﻿// <auto-generated />
using System;
using E_Migrant.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Migrant.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211128015348_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("E_Migrant.App.Dominio.DatosEntidadesColaboradoras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paginaWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serviciosOfrece")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DatosEntidadesColaboradoras");
                });

            modelBuilder.Entity("E_Migrant.App.Dominio.Migrante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccionActual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroIdentificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefonico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacionLaboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoIdentificacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Migrante");
                });
#pragma warning restore 612, 618
        }
    }
}