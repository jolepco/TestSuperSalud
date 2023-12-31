﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryEFCore.DataContext;

#nullable disable

namespace RepositoryEFCore.Migraciones
{
    [DbContext(typeof(DataContexDb))]
    partial class DataContexDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.POCOs.CodSedeIPSDemo", b =>
                {
                    b.Property<string>("IdCodSedeIPSDemo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCodSedeIPSDemo");

                    b.ToTable("CodSedeIPSDemo");
                });

            modelBuilder.Entity("Entities.POCOs.DNTClasificacionNutricional", b =>
                {
                    b.Property<string>("IdDNTClasificacionNutricional")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("IdDNTClasificacionNutricional");

                    b.ToTable("DNTClasificacionNutricional");
                });

            modelBuilder.Entity("Entities.POCOs.DNTManejo", b =>
                {
                    b.Property<string>("IdDNTManejo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDNTManejo");

                    b.ToTable("DNTManejo");
                });

            modelBuilder.Entity("Entities.POCOs.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"));

                    b.Property<string>("CodAsegurador")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("CodMpioResidencia")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPersona");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Entities.POCOs.Seguimiento", b =>
                {
                    b.Property<int>("IdSeguimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSeguimiento"));

                    b.Property<string>("CodClasificacionNutricional")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CodLugarAtencion")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("CodManejoActual")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CodSedeIPSDemoIdCodSedeIPSDemo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaAtencion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDefuncion")
                        .HasColumnType("Date");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("PersonaIdPersona")
                        .HasColumnType("int");

                    b.Property<decimal>("PesoKg")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<short>("TallaCm")
                        .HasColumnType("smallint");

                    b.Property<int>("estadoVital")
                        .HasColumnType("int");

                    b.Property<int>("ubicacionDefuncion")
                        .HasColumnType("int");

                    b.HasKey("IdSeguimiento");

                    b.HasIndex("CodClasificacionNutricional");

                    b.HasIndex("CodManejoActual");

                    b.HasIndex("CodSedeIPSDemoIdCodSedeIPSDemo");

                    b.HasIndex("PersonaIdPersona");

                    b.ToTable("Seguimientos");
                });

            modelBuilder.Entity("Entities.POCOs.Seguimiento", b =>
                {
                    b.HasOne("Entities.POCOs.DNTClasificacionNutricional", "DNTClasificacionNutricional")
                        .WithMany("SeguimientoClasificacion")
                        .HasForeignKey("CodClasificacionNutricional")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.POCOs.DNTManejo", "DNTManejos")
                        .WithMany("Seguimientos")
                        .HasForeignKey("CodManejoActual")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.POCOs.CodSedeIPSDemo", "CodSedeIPSDemo")
                        .WithMany()
                        .HasForeignKey("CodSedeIPSDemoIdCodSedeIPSDemo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.POCOs.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodSedeIPSDemo");

                    b.Navigation("DNTClasificacionNutricional");

                    b.Navigation("DNTManejos");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Entities.POCOs.DNTClasificacionNutricional", b =>
                {
                    b.Navigation("SeguimientoClasificacion");
                });

            modelBuilder.Entity("Entities.POCOs.DNTManejo", b =>
                {
                    b.Navigation("Seguimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
