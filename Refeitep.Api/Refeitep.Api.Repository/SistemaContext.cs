using Refeitep.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Refeitep.Api.Repository;

public class SistemaContext : DbContext
{
    
//  public DbSet<Cliente>? Clientes { get; set; }

    public DbSet<Produto>? Produtos { get; set; }

//  public DbSet<Dispositivo>? Dispositivos { get; set; }

//  public DbSet<Usuario>? Usuarios { get; set; }

//  public DbSet<Pedido>? Pedidos { get; set; }

//  public DbSet<PedidoItem>? PedidoItems { get; set; }

//  public DbSet<Senha>? Senhas { get; set; }

    public SistemaContext(DbContextOptions<SistemaContext> options) 
    : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(produto => produto.Id);
            
            entity.Property(produto => produto.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(cliente => cliente.Estoque)
                .HasColumnName("estoque")
                .IsRequired();

            entity.Property(produto => produto.Preco)
                .HasColumnName("preco")
                .IsRequired();

            entity.Property(produto => produto.Custo)
                .HasColumnName("custo")
                .IsRequired();
        });
    }

}

