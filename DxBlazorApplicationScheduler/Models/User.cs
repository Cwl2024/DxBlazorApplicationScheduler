using System;
using System.Collections.Generic;

namespace DxBlazorApplicationScheduler.Models;

public partial class User
{
    public int Iid { get; set; }

    public string Cuserid { get; set; } = null!;

    public string Cpassword { get; set; } = null!;

    public string? Cfullname { get; set; }

    public bool? Idatabaseutilities { get; set; }

    public bool? Iprintreports { get; set; }

    public bool? Isystemsettings { get; set; }

    public bool? Iusergroups { get; set; }

    public bool? Iuserpreferences { get; set; }

    public bool? Iusers { get; set; }

    public DateTime? Tlastupd { get; set; }

    public string? Clastupdid { get; set; }

    public bool? Lusedplist { get; set; }

    public int? FilistId { get; set; }

    public string? Email { get; set; }

    public string? Smtpsender { get; set; }

    public string? Smtpuser { get; set; }

    public string? Smtppassw { get; set; }

    public string? Sendmailcc { get; set; }

    public DateTime Aendat { get; set; }

    public string Aenuserid { get; set; } = null!;

    public DateTime Anldat { get; set; }

    public string Anluserid { get; set; } = null!;

    public bool? Lwgrsperr { get; set; }

    public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();

    public virtual ICollection<Usgrlink> Usgrlinks { get; set; } = new List<Usgrlink>();
}
