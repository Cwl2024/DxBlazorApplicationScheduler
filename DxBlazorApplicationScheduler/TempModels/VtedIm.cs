using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class VtedIm
{
    public int VtedimId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public string Liefartnr { get; set; } = null!;

    public int LiefstId { get; set; }

    public string Aktbez { get; set; } = null!;

    public decimal? Ek { get; set; }

    public decimal? Vk { get; set; }

    public string? Anmerkung { get; set; }

    public int FilistId { get; set; }

    public virtual FiliSt Filist { get; set; } = null!;
}
