using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class ArtiIm
{
    public int ArtiimId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int LiefstId { get; set; }

    public int? HagrstId { get; set; }

    public int? AgrustId { get; set; }

    public int? WagrstId { get; set; }

    public int? SteustId { get; set; }

    public string? Bezeichn { get; set; }

    public string? Kabezeichn { get; set; }

    public DateOnly? Abdatum { get; set; }

    public decimal? Vk { get; set; }

    public decimal? Ek { get; set; }

    public decimal? Bek { get; set; }

    public decimal? Ghe { get; set; }

    public string? Ghebez { get; set; }

    public decimal? Netinh { get; set; }

    public string? Netinhbez { get; set; }

    public string Liefartnr { get; set; } = null!;

    public string? Ghstatus { get; set; }

    public decimal? Gpeinheit { get; set; }

    public string? Barcode { get; set; }

    public decimal? Faktor { get; set; }

    public bool? Laktiv { get; set; }

    public string? Anmerkung { get; set; }

    public decimal? Anzeti1 { get; set; }

    public decimal? Anzeti2 { get; set; }

    public decimal? Anzeti3 { get; set; }

    public string? Matchcode { get; set; }

    public int FilistId { get; set; }

    public string? Merkmal01 { get; set; }

    public string? Merkmal02 { get; set; }

    public decimal? Gewichtnet { get; set; }

    public string? Isurspland { get; set; }

    public int? ErzestId { get; set; }

    public bool? Lwiegeart { get; set; }

    public string? Zbezeichn { get; set; }

    public DateOnly? Datumbis { get; set; }

    public DateOnly? Datumvon { get; set; }

    public string? Suslief { get; set; }

    public string? Updstatus { get; set; }

    public decimal? Stammbek { get; set; }

    public decimal? Stammvkp { get; set; }

    public decimal? Stammekp { get; set; }

    public decimal? Stammspanne { get; set; }

    public decimal? Neuspanne { get; set; }

    public string? Tempbezeichn { get; set; }

    public string? Ekuerzel { get; set; }

    public bool? Lanalysiert { get; set; }

    public bool? LgerzestId { get; set; }

    public bool? Lginaktion { get; set; }

    public bool? Lgvk { get; set; }

    public bool? Lgek { get; set; }

    public bool? Lgbarcode { get; set; }

    public bool? Lgisurspland { get; set; }

    public bool? Lgaktiv { get; set; }

    public bool? Lggewichtnet { get; set; }

    public bool? Lgmerkmal02 { get; set; }

    public bool? Lgmerkmal01 { get; set; }

    public bool? Lganzeti3 { get; set; }

    public bool? Lganzeti2 { get; set; }

    public bool? Lganzeti1 { get; set; }

    public bool? Lgghstatus { get; set; }

    public bool? Lgfaktor { get; set; }

    public bool? Lggpeinheit { get; set; }

    public bool? Lgnetinhbez { get; set; }

    public bool? Lgnetinh { get; set; }

    public bool? Lgghbez { get; set; }

    public bool? Lgghe { get; set; }

    public bool? Lgbek { get; set; }

    public bool? Lgkabezeichn { get; set; }

    public bool? LghagrstId { get; set; }

    public bool? LgwagrstId { get; set; }

    public bool? LgagrustId { get; set; }

    public bool? LgsteustId { get; set; }

    public bool? Lgmatchcode { get; set; }

    public bool? Lgbezeichn { get; set; }

    public bool? Lglwiegeart { get; set; }

    public bool? Lgzbezeichn { get; set; }

    public bool? Linaktion { get; set; }

    public bool? Lgghebez { get; set; }

    public bool? Lglaktiv { get; set; }

    public virtual AgruSt? Agrust { get; set; }

    public virtual ErzeSt? Erzest { get; set; }

    public virtual FiliSt Filist { get; set; } = null!;

    public virtual HagrSt? Hagrst { get; set; }

    public virtual LiefSt Liefst { get; set; } = null!;

    public virtual SteuSt? Steust { get; set; }

    public virtual WagrSt? Wagrst { get; set; }
}
