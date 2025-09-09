using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class RastSt
{
    public int RaststId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public int? RagrstIdx { get; set; }

    public int? RagrstIdy { get; set; }

    public virtual ICollection<ArtiSt> ArtiSts { get; set; } = new List<ArtiSt>();

    public virtual RagrSt? RagrstIdxNavigation { get; set; }

    public virtual RagrSt? RagrstIdyNavigation { get; set; }
}
