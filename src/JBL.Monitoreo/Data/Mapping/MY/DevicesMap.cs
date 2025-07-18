using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JBL.Monitoreo.Data.Mapping.MY;

public partial class DevicesMap
    : IEntityTypeConfiguration<JBL.Monitoreo.Data.Entities.Devices>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JBL.Monitoreo.Data.Entities.Devices> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("devices");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ID")
            .HasColumnType("int(11)")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("varchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.Alias)
            .HasColumnName("Alias")
            .HasColumnType("varchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.Community)
            .HasColumnName("Community")
            .HasColumnType("varchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.Disabled)
            .HasColumnName("Disabled")
            .HasColumnType("tinyint(1)");

        builder.Property(t => t.Deleted)
            .IsRequired()
            .HasColumnName("Deleted")
            .HasColumnType("tinyint(1)");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "";
        public const string Name = "devices";
    }

    public readonly struct Columns
    {
        public const string Id = "ID";
        public const string Name = "Name";
        public const string Alias = "Alias";
        public const string Community = "Community";
        public const string Disabled = "Disabled";
        public const string Deleted = "Deleted";
    }
    #endregion
}
