using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BewKbw
{
    public int BewkbwId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int BewastId { get; set; }

    public int? FilistId { get; set; }

    public int? LagestId { get; set; }

    public int? LiefstId { get; set; }

    public int? GeFilId { get; set; }

    public DateTime? Datzeit { get; set; }

    public DateTime? Datbuchung { get; set; }

    public string Bezeichn { get; set; } = null!;

    public string Kassierid { get; set; } = null!;

    public string Bedienerid { get; set; } = null!;

    public string Extid { get; set; } = null!;

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

    public string? Flag01 { get; set; }

    public string? Flag02 { get; set; }

    public string? Flag03 { get; set; }

    public string? Flag04 { get; set; }

    public string? Flag05 { get; set; }

    public bool LIntemp { get; set; }

    public int? KundstId { get; set; }

    public int? FaktbwId { get; set; }

    public int? LiefstIdb { get; set; }

    public DateOnly? Datum01 { get; set; }

    public DateOnly? Datum02 { get; set; }

    public bool LErl0meng { get; set; }

    public bool LFolgegebu { get; set; }

    public bool LFolgebew { get; set; }

    public int? RechbwId { get; set; }

    public DateOnly? Datorgdok { get; set; }

    public bool LVlieinf { get; set; }

    public DateTime? Datzeit01 { get; set; }

    public DateTime? Datzeit02 { get; set; }

    public decimal Bearbstat { get; set; }

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual BewAst Bewast { get; set; } = null!;

    public virtual FaktBw? Faktbw { get; set; }

    public virtual FiliSt? Filist { get; set; }

    public virtual GeFil? GeFil { get; set; }

    public virtual KundSt? Kundst { get; set; }

    public virtual LageSt? Lagest { get; set; }

    public virtual LiefSt? Liefst { get; set; }

    public virtual LiefSt? LiefstIdbNavigation { get; set; }

    public virtual RechBw? Rechbw { get; set; }
}
