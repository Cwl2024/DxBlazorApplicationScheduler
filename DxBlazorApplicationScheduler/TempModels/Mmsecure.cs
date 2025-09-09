using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Mmsecure
{
    public int Iid { get; set; }

    public int Icontrolid { get; set; }

    public int Iusrgroupid { get; set; }

    public string Ctype { get; set; } = null!;

    public int Iaccess { get; set; }
}
