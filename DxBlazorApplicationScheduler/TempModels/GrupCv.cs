using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class GrupCv
{
    public int GrupcvId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Cvgruppe { get; set; } = null!;

    public int HagrstId { get; set; }

    public int WagrstId { get; set; }

    public int AgrustId { get; set; }

    public int LirestId { get; set; }

    public virtual AgruSt Agrust { get; set; } = null!;

    public virtual HagrSt Hagrst { get; set; } = null!;

    public virtual LireSt Lirest { get; set; } = null!;

    public virtual WagrSt Wagrst { get; set; } = null!;
}
