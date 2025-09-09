using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class LiefSt
{
    public int LiefstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Liefnr { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string Kuerzel { get; set; } = null!;

    public string? Anschrift1 { get; set; }

    public string? Anschrift2 { get; set; }

    public string? Plz { get; set; }

    public string? Ort { get; set; }

    public string? Land { get; set; }

    public string? Anrede { get; set; }

    public string? Vorname { get; set; }

    public string? Nachname { get; set; }

    public decimal? Rabattsatz { get; set; }

    public string? Blz { get; set; }

    public string? Kto { get; set; }

    public decimal? Bestelltag { get; set; }

    public string? Prldatei { get; set; }

    public string? Email { get; set; }

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Telefon3 { get; set; }

    public string? Url { get; set; }

    public bool? Llanrbarc { get; set; }

    public int? LirestId { get; set; }

    public string? Anmerkung { get; set; }

    public string? Kundennr { get; set; }

    public string? Bank { get; set; }

    public bool? LExpoverk { get; set; }

    public bool? LIsmeldung { get; set; }

    public string? Islandcode { get; set; }

    public string? Dataexchid { get; set; }

    public string? Iban { get; set; }

    public string? Bic { get; set; }

    public string? Ekfw { get; set; }

    public decimal? Ekfaktor { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDteLiefstIdbNavigations { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<AnalyseDte> AnalyseDteLiefsts { get; set; } = new List<AnalyseDte>();

    public virtual ICollection<AnalyseKbw> AnalyseKbwLiefstIdbNavigations { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<AnalyseKbw> AnalyseKbwLiefsts { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<ArtiIm> ArtiIms { get; set; } = new List<ArtiIm>();

    public virtual ICollection<BewDbw> BewDbwLiefstIdbNavigations { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDbw> BewDbwLiefsts { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDteLiefstIdbNavigations { get; set; } = new List<BewDte>();

    public virtual ICollection<BewDte> BewDteLiefsts { get; set; } = new List<BewDte>();

    public virtual ICollection<BewKbw> BewKbwLiefstIdbNavigations { get; set; } = new List<BewKbw>();

    public virtual ICollection<BewKbw> BewKbwLiefsts { get; set; } = new List<BewKbw>();

    public virtual ICollection<LiFil> LiFils { get; set; } = new List<LiFil>();

    public virtual ICollection<LiefCv> LiefCvs { get; set; } = new List<LiefCv>();

    public virtual LireSt? Lirest { get; set; }

    public virtual ICollection<RechBw> RechBws { get; set; } = new List<RechBw>();

    public virtual ICollection<VaLie> VaLieLiefstIdbNavigations { get; set; } = new List<VaLie>();

    public virtual ICollection<VaLie> VaLieLiefsts { get; set; } = new List<VaLie>();
}
