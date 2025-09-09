using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class FaktBw
{
    public int FaktbwId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Datzeit { get; set; }

    public int Faktnr { get; set; }

    public int? KundstId { get; set; }

    public DateOnly Bewkbisdat { get; set; }

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual KundSt? Kundst { get; set; }
}
