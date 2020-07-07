using Microsoft.EntityFrameworkCore;
using PooLojaVirtual.Models;

namespace PooLojaVirtual.Infraestructure
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
    }
}