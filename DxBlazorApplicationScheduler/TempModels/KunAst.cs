using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class KunAst
{
    public int KunastId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public decimal Preisebene { get; set; }

    public virtual ICollection<KundSt> KundSts { get; set; } = new List<KundSt>();
}
