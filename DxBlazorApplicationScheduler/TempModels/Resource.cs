using System;
using System.Collections.Generic;
using DxBlazorApplicationScheduler.Models;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Resource
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsGroup { get; set; }

    public int? GroupId { get; set; }

    public string? TextCss { get; set; }

    public string? BackgroundCss { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User User { get; set; } = null!;
}
