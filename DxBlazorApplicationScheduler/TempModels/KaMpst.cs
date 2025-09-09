using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class KaMpst
{
    public int KampstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public decimal Kasatznr { get; set; }

    public virtual ICollection<MpgrSt> MpgrSts { get; set; } = new List<MpgrSt>();
}
