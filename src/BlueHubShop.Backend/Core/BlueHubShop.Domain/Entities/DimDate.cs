using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class DimDate
{
    public DateOnly Date { get; set; }

    public string DateKey { get; set; } = null!;

    public short? DayOfMonth { get; set; }

    public string? DaySuffix { get; set; }

    public string? DayName { get; set; }

    public string? DayNameTr { get; set; }

    public short? DayOfWeek { get; set; }

    public short? WeekOfMonth { get; set; }

    public short? DayOfYear { get; set; }

    public short IsWeekend { get; set; }

    public short? WeekOfYear { get; set; }

    public short? WeekOfYearIso { get; set; }

    public DateOnly? FirstOfWeek { get; set; }

    public DateOnly? LastOfWeek { get; set; }

    public short? Month { get; set; }

    public string? MonthName { get; set; }

    public string? MonthNameTr { get; set; }

    public DateOnly? FirstOfMonth { get; set; }

    public DateOnly? LastOfMonth { get; set; }

    public short? Quarter { get; set; }

    public DateOnly? FirstOfQuarter { get; set; }

    public DateOnly? LastOfQuarter { get; set; }

    public int? Year { get; set; }

    public bool? IsLeapYear { get; set; }

    public bool? IsHoliday { get; set; }

    public string? HolidayName { get; set; }

    public string? HolidayNameTr { get; set; }

    public int? MonthYear { get; set; }

    public int? YearMonth { get; set; }

    public string? Date1 { get; set; }

    public string? Date2 { get; set; }
}
