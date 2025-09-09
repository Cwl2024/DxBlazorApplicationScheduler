using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class RagrSt
{
    public int RagrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public virtual ICollection<RadeSt> RadeSts { get; set; } = new List<RadeSt>();

    public virtual ICollection<RastSt> RastStRagrstIdxNavigations { get; set; } = new List<RastSt>();

    public virtual ICollection<RastSt> RastStRagrstIdyNavigations { get; set; } = new List<RastSt>();
}
