using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Tljournal
{
    public decimal Id { get; set; }

    public decimal Satzart { get; set; }

    public string Ean { get; set; } = null!;

    public decimal Eanfaktor { get; set; }

    public string Eanint { get; set; } = null!;

    public string Titel { get; set; } = null!;

    public decimal Anzahl { get; set; }

    public decimal Vkpreis { get; set; }

    public decimal Ekpreis { get; set; }

    public decimal Mwst { get; set; }

    public decimal Einauszahl { get; set; }

    public DateTime Vkdatum { get; set; }

    public decimal Kassanr { get; set; }

    public decimal Kassiernr { get; set; }

    public decimal Kundennr { get; set; }

    public decimal Bonposit { get; set; }

    public string Bonnr { get; set; } = null!;

    public decimal Regmodus { get; set; }

    public decimal Lageralt { get; set; }

    public DateTime Zwinvdat { get; set; }

    public decimal Zwinvstand { get; set; }

    public decimal Zwinvwert { get; set; }

    public DateTime Aktzeit { get; set; }
}
