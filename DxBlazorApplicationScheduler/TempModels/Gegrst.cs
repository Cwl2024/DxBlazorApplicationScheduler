using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Gegrst
{
    public int GegrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public bool Lsendn { get; set; }

    public bool Lsendu { get; set; }

    public bool Lsendl { get; set; }

    public bool Lsends { get; set; }

    public string Flaglist { get; set; } = null!;

    public int? GegrsyId { get; set; }

    public bool LErlgegrbc { get; set; }

    public virtual ICollection<BarcSt> BarcSts { get; set; } = new List<BarcSt>();

    public virtual ICollection<ExpoBw> ExpoBws { get; set; } = new List<ExpoBw>();

    public virtual GegrSy? Gegrsy { get; set; }

    public virtual ICollection<GeraSt> GeraSts { get; set; } = new List<GeraSt>();
}
