using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EjemploCrudMVC5AngJs.Models
{
    public class VEHICULOSDBCONTEXT:DbContext
    {
        public DbSet<VEHICULOS> VEHICULO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}