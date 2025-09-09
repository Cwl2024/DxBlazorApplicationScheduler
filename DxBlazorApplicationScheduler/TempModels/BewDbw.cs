using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BewDbw
{
    public int BewdbwId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int BewkbwId { get; set; }

    public int FilistId { get; set; }

    public int? LagestId { get; set; }

    public int? GeFilId { get; set; }

    public int VaristId { get; set; }

    public int? AgrustId { get; set; }

    public int? HagrstId { get; set; }

    public int? WagrstId { get; set; }

    public int? MpgrstId { get; set; }

    public int? LiefstId { get; set; }

    public int? VaLieId { get; set; }

    public int? VtedstId { get; set; }

    public int? VtekstId { get; set; }

    public int? BarcstId { get; set; }

    public int? SteustId { get; set; }

    public int? BewdbwIdl { get; set; }

    public DateTime Datzeit { get; set; }

    public int? Lagekbew { get; set; }

    public decimal? Lagerbew { get; set; }

    public decimal? Lagerabs { get; set; }

    public decimal? Intekp { get; set; }

    public decimal? Intbek { get; set; }

    public decimal? Intvkp { get; set; }

    public decimal? Intvkpnet { get; set; }

    public bool LLagfehler { get; set; }

    public decimal? Extmenge { get; set; }

    public decimal? Extekp { get; set; }

    public decimal? Extekpkorr { get; set; }

    public decimal? Extbek { get; set; }

    public decimal? Extbekkorr { get; set; }

    public decimal? Extvkp { get; set; }

    public decimal? Extvkpkorr { get; set; }

    public bool LFestpreis { get; set; }

    public string? Kassierid { get; set; }

    public string? Bedienerid { get; set; }

    public bool LLagerbew { get; set; }

    public bool LLagerabs { get; set; }

    public bool LUmsatz { get; set; }

    public int Faktorlag { get; set; }

    public int Faktorums { get; set; }

    public int? LiefstIdb { get; set; }

    public decimal? Extmenkorr { get; set; }

    public bool LFolgebew { get; set; }

    public string? Flag01 { get; set; }

    public string? Flag02 { get; set; }

    public decimal? Refmenge { get; set; }

    public decimal? Intekpeinz { get; set; }

    public decimal? Intbekeinz { get; set; }

    public decimal? Intvkpeinz { get; set; }

    public string? Anmerkung { get; set; }

    public virtual AgruSt? Agrust { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual BarcSt? Barcst { get; set; }

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual BewDbw? BewdbwIdlNavigation { get; set; }

    public virtual BewKbw Bewkbw { get; set; } = null!;

    public virtual FiliSt Filist { get; set; } = null!;

    public virtual GeFil? GeFil { get; set; }

    public virtual HagrSt? Hagrst { get; set; }

    public virtual ICollection<BewDbw> InverseBewdbwIdlNavigation { get; set; } = new List<BewDbw>();

    public virtual LageSt? Lagest { get; set; }

    public virtual LiefSt? Liefst { get; set; }

    public virtual LiefSt? LiefstIdbNavigation { get; set; }

    public virtual MpgrSt? Mpgrst { get; set; }

    public virtual SteuSt? Steust { get; set; }

    public virtual VaLie? VaLie { get; set; }

    public virtual VariSt Varist { get; set; } = null!;

    public virtual VteDst? Vtedst { get; set; }

    public virtual VteKst? Vtekst { get; set; }

    public virtual WagrSt? Wagrst { get; set; }
}
