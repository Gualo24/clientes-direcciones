
using Microsoft.EntityFrameworkCore;

namespace backend.Context
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.CascadeDeleteTiming = Microsoft.EntityFrameworkCore.ChangeTracking.CascadeTiming.Never;
        }

        public virtual DbSet<Models.Cliente> Clientes { get; set; }
        public virtual DbSet<Models.Direccion> Direcciones { get; set; }
        public virtual DbSet<Models.Provincia> Provincias { get; set; }
        public virtual DbSet<Models.Municipio> Municipios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelsConfigure.ClienteConfigure.Configure(modelBuilder);
            ModelsConfigure.DireccionConfigure.Configure(modelBuilder);
            ModelsConfigure.ProvinciaConfigure.Configure(modelBuilder); 
            ModelsConfigure.MunicipioConfigure.Configure(modelBuilder);

        }
    }
}