using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class LiefCv
{
    public int LiefcvId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Cvliefnr { get; set; } = null!;

    public int LirestId { get; set; }

    public int LiefstId { get; set; }

    public virtual LiefSt Liefst { get; set; } = null!;

    public virtual LireSt Lirest { get; set; } = null!;
}
