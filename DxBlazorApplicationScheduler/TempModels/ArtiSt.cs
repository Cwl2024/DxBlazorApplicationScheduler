using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class ArtiSt
{
    public int ArtistId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public int? RaststId { get; set; }

    public bool? LSetarti { get; set; }

    public virtual RastSt? Rastst { get; set; }

    public virtual ICollection<VariSt> VariSts { get; set; } = new List<VariSt>();
}
