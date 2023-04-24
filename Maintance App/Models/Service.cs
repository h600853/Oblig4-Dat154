using System;
using System.Collections.Generic;

namespace Maintance_App.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Request { get; set; }

    public string? Status { get; set; }

    public int? Room { get; set; }

    public virtual Room? RoomNavigation { get; set; }
}
