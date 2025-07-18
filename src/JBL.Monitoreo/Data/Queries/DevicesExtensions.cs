using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JBL.Monitoreo.Data.Queries;

public static partial class DevicesExtensions
{
    #region Generated Extensions
    public static JBL.Monitoreo.Data.Entities.Devices? GetByKey(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Devices> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<JBL.Monitoreo.Data.Entities.Devices> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<JBL.Monitoreo.Data.Entities.Devices?> GetByKeyAsync(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Devices> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<JBL.Monitoreo.Data.Entities.Devices> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static JBL.Monitoreo.Data.Entities.Devices? GetByName(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Devices> queryable, string name)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.FirstOrDefault(q => q.Name == name);
    }

    public static async System.Threading.Tasks.Task<JBL.Monitoreo.Data.Entities.Devices?> GetByNameAsync(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Devices> queryable, string name, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return await queryable.FirstOrDefaultAsync(q => q.Name == name, cancellationToken);
    }

    #endregion

}
