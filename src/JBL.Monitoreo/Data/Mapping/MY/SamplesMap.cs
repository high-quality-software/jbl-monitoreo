using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JBL.Monitoreo.Data.Mapping.MY;

public partial class SamplesMap
    : IEntityTypeConfiguration<JBL.Monitoreo.Data.Entities.Samples>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JBL.Monitoreo.Data.Entities.Samples> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("samples");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ID")
            .HasColumnType("int(11)")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.DeviceID)
            .IsRequired()
            .HasColumnName("Device_ID")
            .HasColumnType("int(11)");

        builder.Property(t => t.Timestamp)
            .IsRequired()
            .HasColumnName("Timestamp")
            .HasColumnType("datetime");

        builder.Property(t => t.Oid)
            .IsRequired()
            .HasColumnName("OID")
            .HasColumnType("varchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.OName)
            .IsRequired()
            .HasColumnName("OName")
            .HasColumnType("varchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.Unit)
            .IsRequired()
            .HasColumnName("Unit")
            .HasColumnType("varchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.Value)
            .IsRequired()
            .HasColumnName("Value")
            .HasColumnType("varchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.Status)
            .IsRequired()
            .HasColumnName("Status")
            .HasColumnType("tinyint(4)");

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
        public const string Name = "samples";
    }

    public readonly struct Columns
    {
        public const string Id = "ID";
        public const string DeviceID = "Device_ID";
        public const string Timestamp = "Timestamp";
        public const string Oid = "OID";
        public const string OName = "OName";
        public const string Unit = "Unit";
        public const string Value = "Value";
        public const string Status = "Status";
        public const string Deleted = "Deleted";
    }
    #endregion
}
