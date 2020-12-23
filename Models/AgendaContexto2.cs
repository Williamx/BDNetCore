using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace blog13.Models
{
    public partial class AgendaContexto2 : DbContext
    {
        public DbSet<Agenda> Agendas {get;set;}
        
        public AgendaContexto2()
        {
        }

        public AgendaContexto2(DbContextOptions<AgendaContexto2> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Filename=C:\\blog13\\db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
            modelBuilder.Entity<Agenda>()
            .HasKey(o => o.id);
        }
    }
}
