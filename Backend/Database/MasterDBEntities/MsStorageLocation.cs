using System;
using System.Collections.Generic;

namespace Backend.Database.MasterDBEntities;

public partial class MsStorageLocation
{
    public string LocationId { get; set; } = null!;

    public string? LocationName { get; set; }
}
