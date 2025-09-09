using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class EtiaSt
{
    public int EtiastId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public string Druckparam { get; set; } = null!;

    public bool LStdeinzdr { get; set; }

    public virtual ICollection<VaFil> VaFils { get; set; } = new List<VaFil>();
}
