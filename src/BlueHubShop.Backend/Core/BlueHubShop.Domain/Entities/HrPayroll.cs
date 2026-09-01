using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrPayroll
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public string? PayrollNo { get; set; }

    public decimal GrossSalary { get; set; }

    public decimal OvertimePay { get; set; }

    public decimal Bonus { get; set; }

    public decimal Allowances { get; set; }

    public decimal OtherEarnings { get; set; }

    public decimal TotalEarnings { get; set; }

    public decimal Sgkemployee { get; set; }

    public decimal Sgkemployer { get; set; }

    public decimal UnemploymentEmployee { get; set; }

    public decimal UnemploymentEmployer { get; set; }

    public decimal IncomeTax { get; set; }

    public decimal StampTax { get; set; }

    public decimal OtherDeductions { get; set; }

    public decimal TotalDeductions { get; set; }

    public decimal NetSalary { get; set; }

    public int Status { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentReference { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public decimal EmployerCost { get; set; }

    public int? VoucherId { get; set; }

    public int ApprovalStatus { get; set; }

    public virtual GnlCompany Company { get; set; } = null!;

    public virtual ICollection<HrBonusIncentive> HrBonusIncentives { get; set; } = new List<HrBonusIncentive>();

    public virtual ICollection<HrPayrollDetail> HrPayrollDetails { get; set; } = new List<HrPayrollDetail>();

    public virtual ICollection<HrPayrollItem> HrPayrollItems { get; set; } = new List<HrPayrollItem>();
}
