using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class FiliSt
{
    public int FilistId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public int? FigrstId { get; set; }

    public string Kuerzel { get; set; } = null!;

    public string Anrede { get; set; } = null!;

    public string? Anschrift1 { get; set; }

    public string? Anschrift2 { get; set; }

    public string? Email { get; set; }

    public string? Land { get; set; }

    public string Nachname { get; set; } = null!;

    public string? Ort { get; set; }

    public string? Plz { get; set; }

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Telefon3 { get; set; }

    public string? Url { get; set; }

    public string Vorname { get; set; } = null!;

    public int? LagestIdz { get; set; }

    public int? LagestIda { get; set; }

    public string Uidnr { get; set; } = null!;

    public decimal? Nielsfilnr { get; set; }

    public decimal? Woffentage { get; set; }

    public string? Koebuvknr { get; set; }

    public string? Koebuclpw { get; set; }

    public bool? Ghivksperr { get; set; }

    public bool? Ghinaktiv { get; set; }

    public string? Nosapanka { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual ICollection<ExpoBw> ExpoBws { get; set; } = new List<ExpoBw>();

    public virtual FigrSt? Figrst { get; set; }

    public virtual ICollection<GeFil> GeFils { get; set; } = new List<GeFil>();

    public virtual ICollection<LageSt> LageSts { get; set; } = new List<LageSt>();

    public virtual LageSt? LagestIdaNavigation { get; set; }

    public virtual LageSt? LagestIdzNavigation { get; set; }

    public virtual ICollection<LiFil> LiFils { get; set; } = new List<LiFil>();

    public virtual ICollection<Lstkbw> Lstkbws { get; set; } = new List<Lstkbw>();

    public virtual ICollection<RechBw> RechBws { get; set; } = new List<RechBw>();

    public virtual ICollection<VaFil> VaFils { get; set; } = new List<VaFil>();

    public virtual ICollection<VtedIm> VtedIms { get; set; } = new List<VtedIm>();
}
