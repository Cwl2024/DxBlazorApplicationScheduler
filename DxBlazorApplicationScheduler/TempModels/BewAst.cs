using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BewAst
{
    public int BewastId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? BewasyId { get; set; }

    public string Bezeichn { get; set; } = null!;

    public bool LErlmanneu { get; set; }

    public bool LErlmanupd { get; set; }

    public bool LUmsatz { get; set; }

    public bool LLagerabs { get; set; }

    public bool LLagerbew { get; set; }

    public int Faktorlag { get; set; }

    public int Faktorums { get; set; }

    public bool LErlliefst { get; set; }

    public bool LZwaliefst { get; set; }

    public bool LZwafilist { get; set; }

    public bool LErlliefb { get; set; }

    public bool LZwaliefb { get; set; }

    public bool LErl0meng { get; set; }

    public bool LErl0menaw { get; set; }

    public int? BewastIdl { get; set; }

    public bool LZurefbest { get; set; }

    public bool LZuautbest { get; set; }

    public int Reihung { get; set; }

    public bool LVlieinf { get; set; }

    public bool LVlieinfaw { get; set; }

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual BewAst? BewastIdlNavigation { get; set; }

    public virtual BewaSy? Bewasy { get; set; }

    public virtual ICollection<BewAst> InverseBewastIdlNavigation { get; set; } = new List<BewAst>();
}
