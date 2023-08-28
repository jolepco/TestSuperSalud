using Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.ConfigEntities
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(t => t.IdPersona);
            builder.Property(t => t.TipoIdentificacion).HasMaxLength(2);
            builder.Property(t => t.NroIdentificacion).HasMaxLength(17);
            builder.Property(t => t.PrimerNombre).HasMaxLength(60);
            builder.Property(t => t.SegundoNombre).HasMaxLength(60);
            builder.Property(t => t.PrimerApellido).HasMaxLength(60);
            builder.Property(t => t.SegundoApellido).HasMaxLength(60);
            builder.Property(t => t.Sexo).HasMaxLength(2);
            builder.Property(t => t.CodMpioResidencia).HasMaxLength(5);
            builder.Property(t => t.CodAsegurador).HasMaxLength(6);
        }
    }
}
