using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class LiFil
{
    public int LiFilId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? LiefstId { get; set; }

    public int? FilistId { get; set; }

    public string Kundennr { get; set; } = null!;

    public virtual FiliSt? Filist { get; set; }

    public virtual LiefSt? Liefst { get; set; }
}
