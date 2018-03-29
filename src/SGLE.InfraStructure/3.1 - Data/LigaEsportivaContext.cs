using Microsoft.EntityFrameworkCore;
using SGLE.ApplicationCore.__2._1___Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.InfraStructure._3._1___Data
{
    public class LigaEsportivaContext : DbContext
    {
        public LigaEsportivaContext(DbContextOptions<LigaEsportivaContext> options) :base(options)
        {
                
        }

        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<Assistente> Assistentes { get; set; }
        public DbSet<Atleta> Atletas { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Equipe> Equipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arbitro>().ToTable("Arbitro");
            modelBuilder.Entity<Assistente>().ToTable("Assistente");
            modelBuilder.Entity<Atleta>().ToTable("Atleta");
            modelBuilder.Entity<Campeonato>().ToTable("Campeonato");
            modelBuilder.Entity<Equipe>().ToTable("Equipe");

            #region Configuração de Arbitro
            modelBuilder.Entity<Arbitro>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Arbitro>().Property(e => e.Endereco)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Arbitro>().Property(e => e.Nacionalidade)
                .HasColumnType("varchar(80)")
                .IsRequired();

            modelBuilder.Entity<Arbitro>().Property(e => e.Naturalidade)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Arbitro>().Property(e => e.NomeArbitro)
                .HasColumnType("varchar(180)")
                .IsRequired();

            modelBuilder.Entity<Arbitro>().Property(e => e.RG)
                .HasColumnType("varchar(200)")
                .IsRequired();

            #endregion
            #region Configuracao de Assistente
            modelBuilder.Entity<Assistente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Assistente>().Property(e => e.Endereco)
                .HasColumnType("varchar(180)")
                .IsRequired();

            modelBuilder.Entity<Assistente>().Property(e => e.Nacionalidade)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Assistente>().Property(e => e.Naturalidade)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Assistente>().Property(e => e.NomeAssistente)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Assistente>().Property(e => e.RG)
                .HasColumnType("varchar(10)")
                .IsRequired();
            #endregion
            #region Configuracao de Atleta
            modelBuilder.Entity<Atleta>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.Endereco)
                .HasColumnType("varchar(180)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.Nacionalidade)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.Naturalidade)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.NomedoAtleta)
                .HasColumnType("varchar(140)")
                .IsRequired();

            modelBuilder.Entity<Atleta>().Property(e => e.RG)
                .HasColumnType("varchar(10)")
                .IsRequired();
            #endregion
            #region Configuracao de Campeonato
            modelBuilder.Entity<Campeonato>().Property(e => e.NomedoCampeonato)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion
            #region Configuracao de Equipe
            modelBuilder.Entity<Equipe>().Property(e => e.Email)
                .HasColumnType("varchar(120)")
                .IsRequired();

            modelBuilder.Entity<Equipe>().Property(e => e.Endereco)
                .HasColumnType("varchar(140)")
                .IsRequired();

            modelBuilder.Entity<Equipe>().Property(e => e.NomeEquipe)
                .HasColumnType("varchar(180)")
                .IsRequired();
            #endregion
        }
    }
}
