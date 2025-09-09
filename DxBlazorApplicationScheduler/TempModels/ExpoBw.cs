using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class ExpoBw
{
    public int ExpobwId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? FilistId { get; set; }

    public int? GegrstId { get; set; }

    public string Exportflag { get; set; } = null!;

    public string Quelle { get; set; } = null!;

    public int QuellId { get; set; }

    public decimal Menge { get; set; }

    public string Extraparam { get; set; } = null!;

    public virtual FiliSt? Filist { get; set; }

    public virtual Gegrst? Gegrst { get; set; }
}
