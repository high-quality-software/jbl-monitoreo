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

    public DateTime Timestamp { get; set; }

    public string Oid { get; set; } = null!;

    public string OName { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string Value { get; set; } = null!;

    public sbyte Status { get; set; }

    public bool Deleted { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
