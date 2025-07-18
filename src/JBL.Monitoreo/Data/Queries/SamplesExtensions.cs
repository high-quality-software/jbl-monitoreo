using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JBL.Monitoreo.Data.Queries;

public static partial class SamplesExtensions
{
    #region Generated Extensions
    public static JBL.Monitoreo.Data.Entities.Samples? GetByKey(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Samples> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<JBL.Monitoreo.Data.Entities.Samples> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<JBL.Monitoreo.Data.Entities.Samples?> GetByKeyAsync(this System.Linq.IQueryable<JBL.Monitoreo.Data.Entities.Samples> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<JBL.Monitoreo.Data.Entities.Samples> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    #endregion

}
