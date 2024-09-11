
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Models;

namespace TiendaOnline.Data
{
    public class TiendaOnlineContext:IdentityDbContext<Usuario>
    {
        public TiendaOnlineContext(DbContextOptions<TiendaOnlineContext> options) : base(options) 
        { 

        }

        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<VentaTemporal> VentaTemporales { get; set; }
        public DbSet<DataSale> DataSale { get; set; }

        public DbSet<Venta>Ventas { get; set; }



    }
}
