using Ecommerce.Domain.Enum;
using Ecommerce.Domain.Identity;
using Ecommerce.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.EntityFramework.Contextos
{
    public class DataContext : IdentityDbContext<User, Role, int, 
                                                 IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, 
                                                 IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
                        .HasKey(ur => new{ur.UserId, ur.RoleId});

            modelBuilder.Entity<UserRole>()
                        .HasOne(ur => ur.Role)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.RoleId)
                        .IsRequired();

            modelBuilder.Entity<UserRole>()
                        .HasOne(ur => ur.User)
                        .WithMany(u => u.UserRoles)
                        .HasForeignKey(ur => ur.UserId)
                        .IsRequired();

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 1,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 2,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 3,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 4,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 5,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 6,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 7,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });               

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 8,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Normal
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 9,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Vegetariana
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 10,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.Vegana
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 11,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.SemLactose
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza{
                Id = 12,
                Preco = 25.00M,
                Titulo = "Pizza de Calabresa",
                Descricao = "Pizza de calabresa, com queijo, cebola e molho de tomate.",
                Categoria = CategoriaDePizza.SemGluten
            });
            }
    }
}