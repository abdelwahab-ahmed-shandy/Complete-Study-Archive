using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace Quick_Tickets.Models;

public partial class Cinema
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; } = null!;


    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string Description { get; set; } = null!;

    public string? CinemaLogo { get; set; } = null!;

    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string Address { get; set; } = null!;

    public string? CinemaPhonto { get; set; }
    [ValidateNever]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
