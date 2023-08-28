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
    public class DNTManejoConfig : IEntityTypeConfiguration<DNTManejo>
    {
        public void Configure(EntityTypeBuilder<DNTManejo> builder)
        {
            builder.HasKey(s => s.IdDNTManejo);
        }
    }
}
