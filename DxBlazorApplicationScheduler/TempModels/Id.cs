using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Id
{
    public string Keyname { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Incrementprocedure { get; set; } = null!;

    public int Maxlength { get; set; }

    public string Type { get; set; } = null!;
}
