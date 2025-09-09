using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Setsst
{
    public int SetsstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? VaristIds { get; set; }

    public int? VaristIdd { get; set; }

    public decimal Menge { get; set; }

    public decimal Splitschl { get; set; }

    public virtual VariSt? VaristIddNavigation { get; set; }

    public virtual VariSt? VaristIdsNavigation { get; set; }
}
