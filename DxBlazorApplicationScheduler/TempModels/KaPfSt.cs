using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class KaPfSt
{
    public int KapfstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public decimal Kasatznr { get; set; }

    public virtual ICollection<VariSt> VariSts { get; set; } = new List<VariSt>();
}
