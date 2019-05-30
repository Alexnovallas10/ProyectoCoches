using DATA.Data.Entitys;
using Microsoft.EntityFrameworkCore;

namespace DATA.Data.Context
{
    public partial class ProyectocochesContext : DbContext
    {
        public ProyectocochesContext()
        {
        }

        public ProyectocochesContext(DbContextOptions<ProyectocochesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coches> Coches { get; set; }
        public virtual DbSet<Datosusuario> Datosusuario { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coches>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Combustible).IsUnicode(false);

                entity.Property(e => e.Descrpcion).IsUnicode(false);

                entity.Property(e => e.Imagen).IsUnicode(false);

                entity.Property(e => e.Marca).IsUnicode(false);

                entity.Property(e => e.Modelo).IsUnicode(false);

                entity.Property(e => e.Tracccion).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Coches)
                    .HasForeignKey<Coches>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coches_datosusuario");
            });

            modelBuilder.Entity<Datosusuario>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellido1).IsUnicode(false);

                entity.Property(e => e.Apellido2).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
