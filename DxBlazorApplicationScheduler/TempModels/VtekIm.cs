using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VtekIm
{
    public int VtekimId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public DateOnly Datumbis { get; set; }

    public DateOnly Datumvon { get; set; }

    public int? VteastId { get; set; }

    public string? Anmerkung { get; set; }

    public virtual VteAst? Vteast { get; set; }
}
