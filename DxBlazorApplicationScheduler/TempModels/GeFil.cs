using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class GeFil
{
    public int GeFilId { get; set; }

    public int? GerastId { get; set; }

    public int? FilistId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Beschr { get; set; } = null!;

    public bool LSenden { get; set; }

    public bool LEmpfangen { get; set; }

    public int BidVksnn { get; set; }

    public int BidVkokn { get; set; }

    public int BidIkonn { get; set; }

    public int BidLkonn { get; set; }

    public int BidVkonn { get; set; }

    public int BidVksns { get; set; }

    public int BidVkoks { get; set; }

    public int BidIkons { get; set; }

    public int BidLkons { get; set; }

    public int BidVkons { get; set; }

    public int BidVksnd { get; set; }

    public int BidVkokd { get; set; }

    public int BidIkond { get; set; }

    public int BidLkond { get; set; }

    public int BidVkond { get; set; }

    public int BewastVko { get; set; }

    public int BewastVks { get; set; }

    public int BewastIko { get; set; }

    public int BewastLko { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual FiliSt? Filist { get; set; }

    public virtual GeraSt? Gerast { get; set; }
}
