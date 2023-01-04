using System;
using System.Collections.Generic;

namespace Backend.Database.TransactionDB2Entities;

public partial class TrBpkb
{
    public string AgreementNumber { get; set; } = null!;

    public string? BpkbNo { get; set; }

    public string? BranchId { get; set; }

    public DateTime? BpkbDate { get; set; }

    public string? FakturNo { get; set; }

    public DateTime? FakturDate { get; set; }

    public string? LocationId { get; set; }

    public string? PoliceNo { get; set; }

    public DateTime? BpkbDateIn { get; set; }
}
