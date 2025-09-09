using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class RadeSt
{
    public int RadestId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? RagrstId { get; set; }

    public string Kuerzel { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public virtual RagrSt? Ragrst { get; set; }

    public virtual ICollection<VariSt> VariStRadestIdxNavigations { get; set; } = new List<VariSt>();

    public virtual ICollection<VariSt> VariStRadestIdyNavigations { get; set; } = new List<VariSt>();
}
