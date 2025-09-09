using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VaFil
{
    public int VaFilId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int VaristId { get; set; }

    public int FilistId { get; set; }

    public int? SteustId { get; set; }

    public int? MpgrstId { get; set; }

    public int? VteDstId { get; set; }

    public string Kabezeichn { get; set; } = null!;

    public bool Laktiv { get; set; }

    public decimal Gpeinheit { get; set; }

    public decimal Netinh { get; set; }

    public string Netinhbez { get; set; } = null!;

    public decimal Anzeti1 { get; set; }

    public decimal Anzeti2 { get; set; }

    public decimal Anzeti3 { get; set; }

    public decimal Vk1 { get; set; }

    public decimal Vk2 { get; set; }

    public decimal Vk3 { get; set; }

    public decimal Vk4 { get; set; }

    public decimal Vk5 { get; set; }

    public decimal Vk6 { get; set; }

    public decimal Vk7 { get; set; }

    public decimal Vk8 { get; set; }

    public decimal Vk9 { get; set; }

    public int? EtiastId { get; set; }

    public decimal Minlagmeng { get; set; }

    public decimal Sollagmeng { get; set; }

    public virtual EtiaSt? Etiast { get; set; }

    public virtual FiliSt Filist { get; set; } = null!;

    public virtual MpgrSt? Mpgrst { get; set; }

    public virtual SteuSt? Steust { get; set; }

    public virtual VariSt Varist { get; set; } = null!;

    public virtual ICollection<VteDst> VteDsts { get; set; } = new List<VteDst>();
}
