using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class Room
{
    public int roomnumber { get; set; }

    public string? Size { get; set; }

    public int? Numberofbeds { get; set; }

    public int? Price { get; set; }

    public bool? Available { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
