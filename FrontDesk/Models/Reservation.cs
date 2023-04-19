using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public string FromDate { get; set; } = null!;

    public string ToDate { get; set; } = null!;

    public int Person { get; set; }

    public int Room { get; set; }

    public virtual User PersonNavigation { get; set; } = null!;

    public virtual Room RoomNavigation { get; set; } = null!;
}
