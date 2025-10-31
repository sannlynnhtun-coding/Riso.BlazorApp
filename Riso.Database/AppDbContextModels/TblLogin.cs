using System;
using System.Collections.Generic;

namespace Riso.Database.AppDbContextModels;

public partial class TblLogin
{
    public int LoginId { get; set; }

    public int UserId { get; set; }

    public Guid SessionId { get; set; }

    public DateTime SessionTime { get; set; }
}
