using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class MpgrSt
{
    public int MpgrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int MpgastId { get; set; }

    public string Bezeichn { get; set; } = null!;

    public string Kabezeichn { get; set; } = null!;

    public decimal Menge { get; set; }

    public decimal Wert { get; set; }

    public int KampstId { get; set; }

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual KaMpst Kampst { get; set; } = null!;

    public virtual MpGast Mpgast { get; set; } = null!;

    public virtual ICollection<VaFil> VaFils { get; set; } = new List<VaFil>();

    public virtual ICollection<VteDst> VteDsts { get; set; } = new List<VteDst>();
}
