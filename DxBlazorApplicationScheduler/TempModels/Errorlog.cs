using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Errorlog
{
    public int Iid { get; set; }

    public string Cuserid { get; set; } = null!;

    public DateTime Tdatetime { get; set; }

    public string Caerror1 { get; set; } = null!;

    public string Maerror2 { get; set; } = null!;

    public string Maerror3 { get; set; } = null!;

    public string Caerror4 { get; set; } = null!;

    public string Caerror5 { get; set; } = null!;

    public string Caerror6 { get; set; } = null!;

    public string Caerror7 { get; set; } = null!;

    public string Mcallchain { get; set; } = null!;

    public string Menviron { get; set; } = null!;
}
