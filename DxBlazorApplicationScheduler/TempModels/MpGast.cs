using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class MpGast
{
    public int MpgastId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public bool? Lbetrag { get; set; }

    public bool? Lprozent { get; set; }

    public bool? Lfuerstk { get; set; }

    public bool? Labstk { get; set; }

    public virtual ICollection<MpgrSt> MpgrSts { get; set; } = new List<MpgrSt>();
}
