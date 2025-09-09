using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Lstdbw
{
    public int LstdbwId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public int? LstkbwId { get; set; }

    public int? VaristId { get; set; }

    public decimal? Extmenge { get; set; }

    public virtual Lstkbw? Lstkbw { get; set; }

    public virtual VariSt? Varist { get; set; }
}
