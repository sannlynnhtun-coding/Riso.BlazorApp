using System;
using System.Collections.Generic;

namespace Riso.Database.AppDbContextModels;

public partial class TblProductCategory
{
    public int ProductCategoryId { get; set; }

    public string ProductCategoryName { get; set; } = null!;

    public string ProductCategoryCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedByDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDelete { get; set; }
}
