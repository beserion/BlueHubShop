using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class FinCurrency
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? XmlDate { get; set; }

    public string? XmlDateTr { get; set; }

    public string? BultenNo { get; set; }

    public int? CrossOrder { get; set; }

    public string? Code { get; set; }

    public string? CodeTr { get; set; }

    public int? Unit { get; set; }

    public string? Name { get; set; }

    public string? NameTr { get; set; }

    public decimal? ForexBuying { get; set; }

    public decimal? ForexSelling { get; set; }

    public decimal? BanknoteBuying { get; set; }

    public decimal? BanknoteSelling { get; set; }

    public decimal? CrossRateUsd { get; set; }

    public decimal? CrossRateOther { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Origin { get; set; }

    public decimal? ForexBuyingManual { get; set; }

    public decimal? ForexSellingManual { get; set; }

    public decimal? BanknoteBuyingManual { get; set; }

    public decimal? BanknoteSellingManual { get; set; }
}
