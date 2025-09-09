using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VteKst
{
    public int VtekstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? VteastId { get; set; }

    public string Bezeichn { get; set; } = null!;

    public DateOnly Datumvon { get; set; }

    public DateOnly? Datumbis { get; set; }

    public bool Lgestartet { get; set; }

    public bool? Lbeendet { get; set; }

    public DateTime? Datstart { get; set; }

    public DateTime? Datende { get; set; }

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<VteDst> VteDsts { get; set; } = new List<VteDst>();

    public virtual VteAst? Vteast { get; set; }
}
