using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VariSt
{
    public int VaristId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Bezeichn { get; set; } = null!;

    public string? Matchcode { get; set; }

    public bool Lfestpreis { get; set; }

    public bool Lwiegeart { get; set; }

    public bool Lpfandart { get; set; }

    public bool Lpreiseing { get; set; }

    public int ArtistId { get; set; }

    public int? KapfstId { get; set; }

    public int? HagrstId { get; set; }

    public int? WagrstId { get; set; }

    public int? AgrustId { get; set; }

    public int? RadestIdx { get; set; }

    public int? RadestIdy { get; set; }

    public int? VaristIdp { get; set; }

    public int Lagekbew { get; set; }

    public int? ErzestId { get; set; }

    public bool LFlag01 { get; set; }

    public bool LFlag02 { get; set; }

    public string? Anmerkung { get; set; }

    public decimal Haltbtage { get; set; }

    public decimal Gewichtnet { get; set; }

    public string? Isurspland { get; set; }

    public string? Iskn8 { get; set; }

    public bool LIsexpostk { get; set; }

    public string? Merkmal01 { get; set; }

    public string? Merkmal02 { get; set; }

    public int? Extartnr { get; set; }

    public virtual AgruSt? Agrust { get; set; }

    public virtual ICollection<AnalyseDte> AnalyseDtes { get; set; } = new List<AnalyseDte>();

    public virtual ArtiSt Artist { get; set; } = null!;

    public virtual ICollection<BarcSt> BarcSts { get; set; } = new List<BarcSt>();

    public virtual ICollection<BewDbw> BewDbws { get; set; } = new List<BewDbw>();

    public virtual ICollection<BewDte> BewDtes { get; set; } = new List<BewDte>();

    public virtual ErzeSt? Erzest { get; set; }

    public virtual HagrSt? Hagrst { get; set; }

    public virtual ICollection<VariSt> InverseVaristIdpNavigation { get; set; } = new List<VariSt>();

    public virtual KaPfSt? Kapfst { get; set; }

    public virtual ICollection<Lstdbw> Lstdbws { get; set; } = new List<Lstdbw>();

    public virtual RadeSt? RadestIdxNavigation { get; set; }

    public virtual RadeSt? RadestIdyNavigation { get; set; }

    public virtual ICollection<Setsst> SetsstVaristIddNavigations { get; set; } = new List<Setsst>();

    public virtual ICollection<Setsst> SetsstVaristIdsNavigations { get; set; } = new List<Setsst>();

    public virtual ICollection<VaFil> VaFils { get; set; } = new List<VaFil>();

    public virtual ICollection<VaLie> VaLies { get; set; } = new List<VaLie>();

    public virtual VariSt? VaristIdpNavigation { get; set; }

    public virtual WagrSt? Wagrst { get; set; }
}
