using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace Quick_Tickets.Models;

public partial class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(500, MinimumLength = 8)]
    public string Description { get; set; } = null!;

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public double Price { get; set; }

    public string? ImgUrl { get; set; } = null!;

    [Required(ErrorMessage = "Ad link required.")]
    [StringLength(500, MinimumLength = 8, ErrorMessage = "Ad link must be between 8 and 500 characters.")]
    public string TrailerUrl { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int MovieStatus { get; set; }

    public List<int> CinemaIds { get; set; } = new List<int>();
    public List<int> CategoryIds { get; set; } = new List<int>();

    public virtual Category Category { get; set; } = null!;

    public virtual Cinema Cinema { get; set; } = null!;

    [ValidateNever]
    public virtual ICollection<Actor> Actors { get; set; } = new List<Actor>();
}
