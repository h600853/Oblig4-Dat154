using System;
using System.Collections.Generic;

namespace Maintance_App.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public int? Person { get; set; }

    public int? Room { get; set; }

    public virtual User? PersonNavigation { get; set; }

    public virtual Room? RoomNavigation { get; set; }
}
