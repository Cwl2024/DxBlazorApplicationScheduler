using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VteDst
{
    public int VtedstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int VtekstId { get; set; }

    public int? MpgrstId { get; set; }

    public decimal? Anzeti1 { get; set; }

    public decimal? Anzeti2 { get; set; }

    public decimal? Anzeti3 { get; set; }

    public string? Kabezeichn { get; set; }

    public decimal? Vk1 { get; set; }

    public decimal? Vk2 { get; set; }

    public decimal? Vk3 { get; set; }

    public decimal? Vk4 { get; set; }

    public decimal? Vk5 { get; set; }

    public decimal? Vk6 { get; set; }

    public decimal? Vk7 { get; set; }

    public decimal? Vk8 { get; set; }

    public decimal? Vk9 { get; set; }

    public int VaFilId { get; set; }

    public decimal? Gpeinheit { get; set; }

    public bool? Laktiv { get; set; }

    public decimal? Netinh { get; set; }

    public string? Netinhbez { get; set; }

    public int? SteustId { get; set; }

    public decimal? Ekp { get; set; }

    public decimal? Bek { get; set; }

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual MpgrSt? Mpgrst { get; set; }

    public virtual SteuSt? Steust { get; set; }

    public virtual VaFil VaFil { get; set; } = null!;

    public virtual VteKst Vtekst { get; set; } = null!;
}
