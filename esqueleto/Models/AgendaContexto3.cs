using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace blog13.Models
{
    public partial class AgendaContexto3 : DbContext
    {
        public DbSet<Agenda> Agendas{get;set;}
        public AgendaContexto3()
        {
        }

        public AgendaContexto3(DbContextOptions<AgendaContexto3> options)
            : base(options)
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=teste;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.ToTable("Table_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("telefone")
                    .HasMaxLength(10);
            });
        }
    }
}
