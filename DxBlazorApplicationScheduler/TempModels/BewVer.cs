using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class BewVer
{
    public string BlockId { get; set; } = null!;

    public string? Daten { get; set; }

    public DateTime? AnlDat { get; set; }

    public string? Filiale { get; set; }

    public string? Beschreibung { get; set; }
}
