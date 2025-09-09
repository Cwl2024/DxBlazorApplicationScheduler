using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class FigrSt
{
    public int FigrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public virtual ICollection<FiliSt> FiliSts { get; set; } = new List<FiliSt>();
}
