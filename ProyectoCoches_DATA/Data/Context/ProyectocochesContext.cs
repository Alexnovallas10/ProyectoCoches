
using Microsoft.EntityFrameworkCore;
using ProyectoCoches_DATA.Data.Entitys;

namespace ProyectoCoches_DATA.Data.Context
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coches>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Año)
                    .HasColumnName("año")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Combustible)
                    .IsRequired()
                    .HasColumnName("combustible")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descrpcion)
                    .HasColumnName("descrpcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("imagen")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Km)
                    .HasColumnName("km")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tracccion)
                    .HasColumnName("tracccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Coches)
                    .HasForeignKey<Coches>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coches_datosusuario");
            });

            modelBuilder.Entity<Datosusuario>(entity =>
            {
                entity.ToTable("datosusuario");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasColumnName("apellido2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña")
                    .HasMaxLength(10);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(10);
            });

            //modelBuilder.Entity<DatosUsuarioCompletos>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Contraseña)
            //        .IsRequired()
            //        .HasColumnName("contraseña")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Usuario)
            //        .IsRequired()
            //        .HasColumnName("usuario")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Apellido1)
            //        .IsRequired()
            //        .HasColumnName("apellido1")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Apellido2)
            //        .IsRequired()
            //        .HasColumnName("apellido2")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasColumnName("email")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Nombre)
            //        .IsRequired()
            //        .HasColumnName("nombre")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Telefono)
            //        .HasColumnName("telefono")
            //        .HasColumnType("numeric(9, 0)");
            //});

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
