using Microsoft.EntityFrameworkCore;
using ProvaEFCore.App.Models;

namespace ProvaEFCore.App.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<RM550187_Fornecedor> RM550187_Fornecedores { get; set; }
        public DbSet<RM550187_Produto> RM550187_Produtos { get; set; }
        public DbSet<RM550187_Pedido> RM550187_Pedidos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RM550187_Fornecedor>(e =>
            {
                e.ToTable("RM550187_FORNECEDOR");
                e.HasKey(x => x.idFornecedor);
                e.Property(x => x.idFornecedor).ValueGeneratedOnAdd();
                e.Property(x => x.nrCEP).HasMaxLength(9).IsRequired();
                e.Property(x => x.dsEndereco).HasMaxLength(200).IsRequired();
                e.Property(x => x.Estado).HasMaxLength(2).IsRequired();
                e.Property(x => x.Cidade).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<RM550187_Produto>(e =>
            {
                e.ToTable("RM550187_PRODUTO");
                e.HasKey(x => x.idProduto);
                e.Property(x => x.idProduto).ValueGeneratedOnAdd();
                e.Property(x => x.nmProduto).HasMaxLength(150).IsRequired();
                e.Property(x => x.preco).HasPrecision(18, 2);
            });

            modelBuilder.Entity<RM550187_Pedido>(e =>
            {
                e.ToTable("RM550187_PEDIDO");
                e.HasKey(x => x.idPedido);
                e.Property(x => x.idPedido).ValueGeneratedOnAdd();
                e.Property(x => x.valorTotal).HasPrecision(18, 2);
                e.Property(x => x.dataPedido).HasColumnType("DATE");
            });
        }
    }
}
