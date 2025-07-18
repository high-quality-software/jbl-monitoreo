using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JBL.Monitoreo.Data;

public partial class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<JBL.Monitoreo.Data.Entities.Devices> Devices { get; set; } = null!;

    public virtual DbSet<JBL.Monitoreo.Data.Entities.Samples> Samples { get; set; } = null!;

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new JBL.Monitoreo.Data.Mapping.MY.DevicesMap());
        modelBuilder.ApplyConfiguration(new JBL.Monitoreo.Data.Mapping.MY.SamplesMap());
        #endregion
    }
}
