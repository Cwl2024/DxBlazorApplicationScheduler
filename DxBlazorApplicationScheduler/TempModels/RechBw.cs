using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class RechBw
{
    public int RechbwId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public DateTime Datzeit { get; set; }

    public DateOnly Rechdat { get; set; }

    public string Anluserid { get; set; } = null!;

    public string Rechnr { get; set; } = null!;

    public int? LiefstId { get; set; }

    public int? FilistId { get; set; }

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual FiliSt? Filist { get; set; }

    public virtual LiefSt? Liefst { get; set; }
}
