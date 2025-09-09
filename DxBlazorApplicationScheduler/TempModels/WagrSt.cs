using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class WagrSt
{
    public int WagrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Wagrnr { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string? AgrustNrm { get; set; }

    public string? AgrustNrx { get; set; }

    public int SteustId { get; set; }

    public string Kuerzel { get; set; } = null!;

    public int? KawgstId { get; set; }

    public string Kabezeichn { get; set; } = null!;

    public bool? Lnegativ { get; set; }

    public bool? Lgewicht { get; set; }

    public string? Wawagrnr { get; set; }

    public string? Waabteilnr { get; set; }

    public bool? LFlag01 { get; set; }

    public bool? LFlag02 { get; set; }

    public bool? Lkomm { get; set; }

    public bool? Lgesperrt { get; set; }

    public bool? Lsammel { get; set; }

    public string? Sammelsapo { get; set; }

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<GrupCv> GrupCvs { get; set; } = new List<GrupCv>();

    public virtual KawgSt? Kawgst { get; set; }

    public virtual SteuSt Steust { get; set; } = null!;

    public virtual ICollection<VariSt> VariSts { get; set; } = new List<VariSt>();
}
