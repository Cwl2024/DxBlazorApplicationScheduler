using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.Models;

public partial class Usgrlink
{
    public int Iid { get; set; }

    public int Igroupid { get; set; }

    public int Iuserid { get; set; }

    public int Iorder { get; set; }

    public DateTime Tlastupd { get; set; }

    public int Ilastupdid { get; set; }

    public virtual Group Igroup { get; set; } = null!;

    public virtual User Iuser { get; set; } = null!;
}
