using System;
using System.Collections.Generic;

namespace Backend.Database.MasterDBEntities;

public partial class MsUser
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserType { get; set; } = null!;
}
