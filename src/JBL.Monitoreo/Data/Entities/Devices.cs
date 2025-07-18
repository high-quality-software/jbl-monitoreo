using System;
using System.Collections.Generic;

namespace JBL.Monitoreo.Data.Entities;

public partial class Devices
{
    public Devices()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Alias { get; set; }

    public string? Community { get; set; }

    public bool? Disabled { get; set; }

    public bool Deleted { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
