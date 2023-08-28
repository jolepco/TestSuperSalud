using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.DataContext
{
    public class ContextDbFactory : IDesignTimeDbContextFactory<DataContexDb>
    {
        public DataContexDb CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DataContexDb>();
            optionBuilder.UseSqlServer(
                "Server=JOSEP; database = aprendercleanArq; user id = sa; password = j.8916;TrustServerCertificate=True");
            return new DataContexDb(optionBuilder.Options);
        }
    }
}
