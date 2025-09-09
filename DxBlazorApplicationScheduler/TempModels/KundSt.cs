using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class KundSt
{
    public int KundstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? KunastId { get; set; }

    public string Kundnr { get; set; } = null!;

    public string? Anrede { get; set; }

    public string? Vorname { get; set; }

    public string? Nachname { get; set; }

    public string? Anschrift1 { get; set; }

    public string? Anschrift2 { get; set; }

    public string? Plz { get; set; }

    public string? Ort { get; set; }

    public string? Land { get; set; }

    public string Kabezeichn { get; set; } = null!;

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Telefon3 { get; set; }

    public string? Blz { get; set; }

    public string? Kto { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public string? Matchcode { get; set; }

    public decimal Preisebene { get; set; }

    public DateOnly? Datablauf { get; set; }

    public decimal? Sperrlimit { get; set; }

    public string? Bank { get; set; }

    public string? Uidnr { get; set; }

    public string? Anmerkung { get; set; }

    public string? Titel { get; set; }

    public DateOnly? Gebdatum { get; set; }

    public virtual ICollection<AnalyseKbw> AnalyseKbws { get; set; } = new List<AnalyseKbw>();

    public virtual ICollection<BewKbw> BewKbws { get; set; } = new List<BewKbw>();

    public virtual ICollection<FaktBw> FaktBws { get; set; } = new List<FaktBw>();

    public virtual KunAst? Kunast { get; set; }
}
