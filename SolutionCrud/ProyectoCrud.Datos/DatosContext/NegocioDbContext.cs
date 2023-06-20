using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoCrud.Modelos;
namespace ProyectoCrud.Datos.DatosContext;

public partial class NegocioDbContext : DbContext
{
    public NegocioDbContext()
    {
    }

    public NegocioDbContext(DbContextOptions<NegocioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC07E8851C04");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("money");
            entity.Property(e => e.Stock).HasColumnName("stock");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
