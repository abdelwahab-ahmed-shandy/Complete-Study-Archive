using System;
using System.Collections.Generic;

namespace Bikestore_task_11.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Accessories { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
