using Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.ConfigEntities
{
    public class SeguimientoConfig : IEntityTypeConfiguration<Seguimiento>
    {
        public void Configure(EntityTypeBuilder<Seguimiento> builder)
        {
            builder.HasKey(s => s.IdSeguimiento);
            builder.Property(s => s.FechaDefuncion).HasColumnType("Date");
            builder.Property(s => s.CodLugarAtencion).HasMaxLength(12);
            builder.Property(s => s.PesoKg).HasPrecision(5, 2);
            builder.Property(s => s.CodClasificacionNutricional).HasMaxLength(2);
            builder.Property(s => s.CodManejoActual).HasMaxLength(2);


            builder.HasOne<DNTManejo>(s => s.DNTManejos)
     .WithMany(g => g.Seguimientos)
     .HasForeignKey(s => s.CodManejoActual);

            builder.HasOne<DNTClasificacionNutricional>(s => s.DNTClasificacionNutricional)
     .WithMany(g => g.SeguimientoClasificacion)
     .HasForeignKey(s => s.CodClasificacionNutricional);
        }
    }
}
