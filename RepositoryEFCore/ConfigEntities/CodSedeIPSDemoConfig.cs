using Entities.POCOs;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.ConfigEntities
{
    public class CodSedeIPSDemoConfig : IEntityTypeConfiguration<CodSedeIPSDemo>
    {
        public void Configure(EntityTypeBuilder<CodSedeIPSDemo> builder)
        {
            builder.HasKey(s => s.IdCodSedeIPSDemo);
        }
    }
}
