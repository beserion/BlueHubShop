using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class ErrorLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Message { get; set; }

    public string? ExceptionType { get; set; }

    public string? InnerExceptionMessage { get; set; }

    public string? StackTrace { get; set; }

    public string? Path { get; set; }

    public string? RequestMethod { get; set; }

    public string? QueryString { get; set; }

    public string? Headers { get; set; }

    public string? RequestBody { get; set; }

    public string? ClientIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Referer { get; set; }

    public string? Host { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Solved { get; set; }

    public bool Reported { get; set; }
}
