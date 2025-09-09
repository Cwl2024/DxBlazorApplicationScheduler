using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class KawgSt
{
    public int KawgstId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public decimal Kasatznr { get; set; }

    public virtual ICollection<WagrSt> WagrSts { get; set; } = new List<WagrSt>();
}
