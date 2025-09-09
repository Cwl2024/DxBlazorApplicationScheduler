using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class LageSt
{
    public int LagestId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? FilistId { get; set; }

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual ICollection<FiliSt> FiliStLagestIdaNavigations { get; set; } = new List<FiliSt>();

    public virtual ICollection<FiliSt> FiliStLagestIdzNavigations { get; set; } = new List<FiliSt>();

    public virtual FiliSt? Filist { get; set; }
}
