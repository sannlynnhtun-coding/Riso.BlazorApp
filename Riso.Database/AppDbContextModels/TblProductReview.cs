using System;
using System.Collections.Generic;

namespace Riso.Database.AppDbContextModels;

public partial class TblProductReview
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int Rating { get; set; }

    public string? ReviewTitle { get; set; }

    public string? ReviewText { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsApproved { get; set; }
}
