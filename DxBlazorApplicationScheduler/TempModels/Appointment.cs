using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class Appointment
{
    public int Id { get; set; }

    public string Caption { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public int? Label { get; set; }

    public int Status { get; set; }

    public bool AllDay { get; set; }

    public string? Recurrence { get; set; }

    public int ResourceId { get; set; }

    public string? Resources { get; set; }

    public bool? Accepted { get; set; }

    public string? AppointmentType { get; set; }

    public virtual Resource Resource { get; set; } = null!;
}
