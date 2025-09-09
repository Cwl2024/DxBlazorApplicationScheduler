using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VteAst
{
    public int VteastId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public bool Lnurstart { get; set; }

    public bool Llinkvari { get; set; }

    public bool Lreplvari { get; set; }

    public bool Lexchvari { get; set; }

    public virtual ICollection<VteKst> VteKsts { get; set; } = new List<VteKst>();

    public virtual ICollection<VtekIm> VtekIms { get; set; } = new List<VtekIm>();
}
