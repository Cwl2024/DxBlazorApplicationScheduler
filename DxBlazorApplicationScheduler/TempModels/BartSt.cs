using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BartSt
{
    public int BartstId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public decimal Prefixlen { get; set; }

    public decimal Codelen { get; set; }

    public string Codetype { get; set; } = null!;

    public string Codemaske { get; set; } = null!;

    public string Codekonv { get; set; } = null!;

    public decimal Nachkomma { get; set; }

    public decimal Kalktype { get; set; }

    public string Kuerzel { get; set; } = null!;
}
