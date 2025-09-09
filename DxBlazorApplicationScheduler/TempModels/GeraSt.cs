using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class GeraSt
{
    public int GerastId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public int? GegrstId { get; set; }

    public string Klassenlib { get; set; } = null!;

    public string Klasse { get; set; } = null!;

    public virtual ICollection<GeFil> GeFils { get; set; } = new List<GeFil>();

    public virtual Gegrst? Gegrst { get; set; }
}
