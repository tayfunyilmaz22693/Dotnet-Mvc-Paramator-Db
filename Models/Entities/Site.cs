using System;
using System.Collections.Generic;

namespace occupy.Models.Entities;

public partial class Site
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Facebook { get; set; }

    public string? Twitter { get; set; }

    public string? Instagram { get; set; }

    public string? Youtube { get; set; }

    public string? Logo { get; set; }

    public string? Favicon { get; set; }
}
