using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DxBlazorApplicationScheduler.Models;

public partial class Resource
{
    public int Id { get; set; }
    [Required(ErrorMessage = "A UserId is required")]
    public int UserId { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = null!;

    // Not necessary if using the ResourceGroups collection instead -DEPRECATED -Replaced by collections
    public bool IsGroup { get; set; }
    public int? GroupId { get; set; }

    // Formatting
    public string? TextCss { get; set; }
    public string? BackgroundCss { get; set; }

    // Collections for hierarchical structure
    public ICollection<Resource> Children { get; set; } = new List<Resource>();
    public ICollection<Resource> Parents { get; set; } = new List<Resource>();
    public ICollection<ResourceGroup> ResourceGroups { get; set; } = new List<ResourceGroup>();
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
