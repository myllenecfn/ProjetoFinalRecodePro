using Microsoft.EntityFrameworkCore;
using ProjetoMod6.Models;

namespace ProjetoMod6.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Compra> Compras { get; set; }

    }
}
