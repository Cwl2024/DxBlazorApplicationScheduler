using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VaLie
{
    public int VaLieId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int LiefstId { get; set; }

    public int VaristId { get; set; }

    public string? Liefartnr { get; set; }

    public string? Liefartbez { get; set; }

    public string Lieftype { get; set; } = null!;

    public decimal? Ghe { get; set; }

    public string? Ghebez { get; set; }

    public decimal? Minlizeit { get; set; }

    public decimal? Ekp { get; set; }

    public decimal? Bek { get; set; }

    public decimal? Letztekp { get; set; }

    public DateOnly? Letztekdat { get; set; }

    public bool Lwhauptart { get; set; }

    public string Ghstatus { get; set; } = null!;

    public int? LiefstIdb { get; set; }

    public DateOnly? Datumvon { get; set; }

    public DateOnly? Datumbis { get; set; }

    public decimal? Sollspanne { get; set; }

    public decimal? Minlimenge { get; set; }

    public decimal? Fwekp { get; set; }

    public string? Suslief { get; set; }

    public bool Lwvkp { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual LiefSt Liefst { get; set; } = null!;

    public virtual LiefSt? LiefstIdbNavigation { get; set; }

    public virtual VariSt Varist { get; set; } = null!;
}
