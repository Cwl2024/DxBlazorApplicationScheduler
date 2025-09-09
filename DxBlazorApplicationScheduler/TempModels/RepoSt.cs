using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class RepoSt
{
    public int RepostId { get; set; }

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public int? ReposyId { get; set; }

    public string Repofile { get; set; } = null!;

    public string Beschreib { get; set; } = null!;

    public string? Anmerkung { get; set; }

    public bool LAktiv { get; set; }

    public string Flaglist { get; set; } = null!;

    public virtual RepoSy? Reposy { get; set; }
}
