using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class LireSt
{
    public int LirestId { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public string Klasse { get; set; } = null!;

    public string Klassenlib { get; set; } = null!;

    public virtual ICollection<GrupCv> GrupCvs { get; set; } = new List<GrupCv>();

    public virtual ICollection<LiefCv> LiefCvs { get; set; } = new List<LiefCv>();

    public virtual ICollection<LiefSt> LiefSts { get; set; } = new List<LiefSt>();
}
