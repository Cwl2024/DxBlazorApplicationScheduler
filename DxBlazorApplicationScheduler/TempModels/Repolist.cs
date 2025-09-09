using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Repolist
{
    public string Cdosname { get; set; } = null!;

    public string Cfullname { get; set; } = null!;

    public string Ctype { get; set; } = null!;

    public bool Ldaterange { get; set; }

    public bool Lnoexcel { get; set; }
}
