using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class SteuSt
{
    public int SteustId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public decimal Steusatz { get; set; }

    public string Kuerzel { get; set; } = null!;

    public string Steunr { get; set; } = null!;

    public decimal? Kasatznr { get; set; }

    public decimal? Wasatznr { get; set; }

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<VaFil> VaFils { get; set; } = new List<VaFil>();

    public virtual ICollection<VteDst> VteDsts { get; set; } = new List<VteDst>();

    public virtual ICollection<WagrSt> WagrSts { get; set; } = new List<WagrSt>();
}
