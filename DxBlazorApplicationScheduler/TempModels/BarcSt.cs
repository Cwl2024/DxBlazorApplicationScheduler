using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BarcSt
{
    public int BarcstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public decimal Faktor { get; set; }

    public decimal Vkkorrbetr { get; set; }

    public decimal Vkkorrfakt { get; set; }

    public DateOnly? Letztvk { get; set; }

    public int VaristId { get; set; }

    public string? Anmerkung { get; set; }

    public bool LIntausz { get; set; }

    public int? GegrstId { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual Gegrst? Gegrst { get; set; }

    public virtual VariSt Varist { get; set; } = null!;
}
