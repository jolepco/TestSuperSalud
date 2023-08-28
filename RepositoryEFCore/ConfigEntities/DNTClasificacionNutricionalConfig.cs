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
    public class DNTClasificacionNutricionalConfig : IEntityTypeConfiguration<DNTClasificacionNutricional>
    {
        public void Configure(EntityTypeBuilder<DNTClasificacionNutricional> builder)
        {
            builder.HasKey(s => s.IdDNTClasificacionNutricional);
        }
    }
}
