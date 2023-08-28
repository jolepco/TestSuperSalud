using Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.DataContext
{
    public class DataContexDb : DbContext
    {
        public DataContexDb(DbContextOptions<DataContexDb> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Persona>  Personas { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }
    }
}
