using System;
using System.Collections.Generic;

namespace Maintance_App.Models;

public partial class Room
{
    public int Roomnumber { get; set; }

    public string? Size { get; set; }

    public int? Numberofbeds { get; set; }

    public int? Price { get; set; }

    public bool? Available { get; set; }

    public virtual ICollection<Cleaning> Cleanings { get; } = new List<Cleaning>();

    public virtual ICollection<Maintenance> Maintenances { get; } = new List<Maintenance>();

    public virtual ICollection<Reservation> Reservations { get; } = new List<Reservation>();

    public virtual ICollection<Service> Services { get; } = new List<Service>();
}
