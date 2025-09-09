using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class ErzeSt
{
    public int ErzestId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public decimal? Sollspanne { get; set; }

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<VariSt> VariSts { get; set; } = new List<VariSt>();
}
