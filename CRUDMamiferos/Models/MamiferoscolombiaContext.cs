using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDMamiferos.Models;

public partial class MamiferoscolombiaContext : DbContext
{
    public MamiferoscolombiaContext()
    {
    }

    public MamiferoscolombiaContext(DbContextOptions<MamiferoscolombiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Especy> Especies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //        => optionsBuilder.UseMySql("server=localhost;port=3306;database=mamiferoscolombia;uid=root;password=123456789", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Especy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("especies");

            entity.Property(e => e.Especie).HasMaxLength(250);
            entity.Property(e => e.Familia).HasMaxLength(250);
            entity.Property(e => e.Genero).HasMaxLength(250);
            entity.Property(e => e.Latitud).HasPrecision(7, 5);
            entity.Property(e => e.Longitud).HasPrecision(7, 5);
            entity.Property(e => e.Orden).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
