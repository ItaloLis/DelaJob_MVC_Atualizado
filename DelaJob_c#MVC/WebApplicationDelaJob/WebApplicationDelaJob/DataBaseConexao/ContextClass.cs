using WebApplicationDelaJob.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDelaJob.DataBaseConexao
{
    public class ContextClass : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ITALO7;Initial Catalog=Agência_de_Viagens;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(tab => {
                tab.ToTable("Login");

                tab.Property(p => p.email).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.senha).HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Cadastro>(tab => {
                tab.ToTable("Cadastro");

                tab.Property(p => p.email).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.senha).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.nome).HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Contato>(tab => {
                tab.ToTable("Contato");

                tab.Property(p => p.email).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.telefone).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.nome).HasColumnType("VARCHAR(50)");
                tab.Property(p => p.assunto).HasColumnType("VARCHAR(100)");
                tab.Property(p => p.mensagem).HasColumnType("VARCHAR");
            });
        }
    }
}
