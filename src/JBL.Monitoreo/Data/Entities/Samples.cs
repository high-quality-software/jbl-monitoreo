using System;
using System.Collections.Generic;

namespace JBL.Monitoreo.Data.Entities;

public partial class Samples
{
    public Samples()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int DeviceID { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Oid { get; set; }

    public string? QName { get; set; }

    public string? Unit { get; set; }

    public int? Value { get; set; }

    public sbyte Status { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
