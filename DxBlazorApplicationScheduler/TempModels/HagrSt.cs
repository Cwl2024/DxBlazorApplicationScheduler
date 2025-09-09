using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class HagrSt
{
    public int HagrstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Hagrnr { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string? WagrstNrm { get; set; }

    public string? WagrstNrx { get; set; }

    public string Kuerzel { get; set; } = null!;

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<GrupCv> GrupCvs { get; set; } = new List<GrupCv>();

    public virtual ICollection<VariSt> VariSts { get; set; } = new List<VariSt>();
}
