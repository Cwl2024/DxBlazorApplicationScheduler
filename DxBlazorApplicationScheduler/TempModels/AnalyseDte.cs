using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class AnalyseDte
{
    public int BewdteId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? BewkbwId { get; set; }

    public int? FilistId { get; set; }

    public int? VaristId { get; set; }

    public int? LiefstId { get; set; }

    public int? GeFilId { get; set; }

    public int? LagestId { get; set; }

    public int? VaLieId { get; set; }

    public int? BarcstId { get; set; }

    public DateTime Datzeit { get; set; }

    public string Bedienerid { get; set; } = null!;

    public string Kassierid { get; set; } = null!;

    public decimal? Extbek { get; set; }

    public decimal? Extbekkorr { get; set; }

    public decimal? Extekp { get; set; }

    public decimal? Extekpkorr { get; set; }

    public decimal? Extmenge { get; set; }

    public decimal? Extmenkorr { get; set; }

    public decimal? Extvkp { get; set; }

    public decimal? Extvkpkorr { get; set; }

    public int Faktorlag { get; set; }

    public int Faktorums { get; set; }

    public decimal? Intbek { get; set; }

    public decimal? Intekp { get; set; }

    public decimal? Intvkp { get; set; }

    public decimal? Intvkpnet { get; set; }

    public decimal? Lagerabs { get; set; }

    public decimal? Lagerbew { get; set; }

    public bool LFestpreis { get; set; }

    public bool LLagerabs { get; set; }

    public bool LLagerbew { get; set; }

    public bool LLagfehler { get; set; }

    public bool LUmsatz { get; set; }

    public int? LiefstIdb { get; set; }

    public bool LUnterdr { get; set; }

    public decimal? Num01 { get; set; }

    public decimal? Num02 { get; set; }

    public decimal? Num03 { get; set; }

    public decimal? Num04 { get; set; }

    public decimal? Num05 { get; set; }

    public decimal? Num06 { get; set; }

    public decimal? Num07 { get; set; }

    public decimal? Num08 { get; set; }

    public decimal? Num09 { get; set; }

    public decimal? Num10 { get; set; }

    public DateOnly? Datum01 { get; set; }

    public DateOnly? Datum02 { get; set; }

    public bool LFolgebew { get; set; }

    public int? BewdbwId { get; set; }

    public string? Flag01 { get; set; }

    public string? Flag02 { get; set; }

    public decimal? Intbekeinz { get; set; }

    public decimal? Intekpeinz { get; set; }

    public decimal? Intvkpeinz { get; set; }

    public decimal? Refmenge { get; set; }

    public string? Anmerkung { get; set; }

    public decimal? Vkstk00 { get; set; }

    public decimal? Vkstk01 { get; set; }

    public decimal? Vkstk02 { get; set; }

    public decimal? Vkstk03 { get; set; }

    public decimal? Vkstk04 { get; set; }

    public decimal? Vkstk05 { get; set; }

    public decimal? Vkstk06 { get; set; }

    public decimal? Vkstk07 { get; set; }

    public decimal? Vkstk08 { get; set; }

    public decimal? Vkstk09 { get; set; }

    public decimal? Vkstk10 { get; set; }

    public decimal? Vkstk11 { get; set; }

    public decimal? Vkstk12 { get; set; }

    public virtual BarcSt? Barcst { get; set; }

    public virtual BewDbw? Bewdbw { get; set; }

    public virtual AnalyseKbw? Bewkbw { get; set; }

    public virtual FiliSt? Filist { get; set; }

    public virtual GeFil? GeFil { get; set; }

    public virtual LageSt? Lagest { get; set; }

    public virtual LiefSt? Liefst { get; set; }

    public virtual LiefSt? LiefstIdbNavigation { get; set; }

    public virtual VaLie? VaLie { get; set; }

    public virtual VariSt? Varist { get; set; }
}
