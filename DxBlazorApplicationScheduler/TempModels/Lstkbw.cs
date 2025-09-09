using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Lstkbw
{
    public int LstkbwId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public int? FilistId { get; set; }

    public string Bezeichn { get; set; } = null!;

    public virtual FiliSt? Filist { get; set; }

    public virtual ICollection<Lstdbw> Lstdbws { get; set; } = new List<Lstdbw>();
}
