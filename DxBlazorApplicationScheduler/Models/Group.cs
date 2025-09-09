using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.Models;

public partial class Group
{
    public int Iid { get; set; }

    public string Cgrpdesc { get; set; } = null!;

    public DateTime Tlastupd { get; set; }

    public int Ilastupdid { get; set; }

    public virtual ICollection<Usgrlink> Usgrlinks { get; set; } = new List<Usgrlink>();
}
