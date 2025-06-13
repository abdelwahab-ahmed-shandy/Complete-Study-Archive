using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace Quick_Tickets.Models;

public partial class Actor
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string FirstName { get; set; } = null!;
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string LastName { get; set; } = null!;

    [Required]
    [StringLength(500, MinimumLength = 8)]
    public string Bio { get; set; } = null!;

    public string? ProfilePicture { get; set; } = null!;

    [Required]
    [StringLength(500, MinimumLength = 8)]
    public string News { get; set; } = null!;

    [ValidateNever]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
