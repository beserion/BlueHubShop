using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class LojPortCall
{
    public int Id { get; set; }

    public string CallNo { get; set; } = null!;

    public int VesselId { get; set; }

    public int PortId { get; set; }

    public string? CallType { get; set; }

    public string? Status { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Ata { get; set; }

    public DateTime? Atd { get; set; }

    public DateTime? BerthingTime { get; set; }

    public DateTime? UnberthingTime { get; set; }

    public string? BerthNo { get; set; }

    public decimal? CargoLoaded { get; set; }

    public decimal? CargoDischarged { get; set; }

    public int? ContainersLoaded { get; set; }

    public int? ContainersDischarged { get; set; }

    public int? WaitingHours { get; set; }

    public string? WaitingReason { get; set; }

    public decimal? PortDues { get; set; }

    public decimal? PilotageCharges { get; set; }

    public decimal? TugCharges { get; set; }

    public decimal? BerthCharges { get; set; }

    public decimal? OtherCharges { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Currency { get; set; }

    public int? AgentId { get; set; }

    public string? Remarks { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual GnlPort Port { get; set; } = null!;

    public virtual GnlVessel Vessel { get; set; } = null!;
}
