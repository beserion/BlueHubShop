using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class GnlCompany
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public bool? OffShore { get; set; }

    public bool? GroupCompany { get; set; }

    public string? OwnerName { get; set; }

    public string? CompanyType { get; set; }

    public string? CompanyColor { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? ShortName { get; set; }

    public string? GroupName { get; set; }

    public string? Manager { get; set; }

    public string? Description { get; set; }

    public string? EmailAddress { get; set; }

    public string? TaxOffice { get; set; }

    public string? TaxNumber { get; set; }

    public string? InvoiceAddress { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? OperationManager { get; set; }

    public string? AccountManager { get; set; }

    public string? OfficePhone { get; set; }

    public string? OfficeFax { get; set; }

    public string? WebAddress { get; set; }

    public string? OfficeAddress { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Currency { get; set; }

    public string? BankAccountDescription { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? PurchaseOrderNote { get; set; }

    public string? Remark { get; set; }

    public string? Logo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<AppApprovalLevel> AppApprovalLevels { get; set; } = new List<AppApprovalLevel>();

    public virtual ICollection<AppApprovalMatrix> AppApprovalMatrices { get; set; } = new List<AppApprovalMatrix>();

    public virtual ICollection<AppApprovalMatrixStep> AppApprovalMatrixSteps { get; set; } = new List<AppApprovalMatrixStep>();

    public virtual ICollection<AppAuthorizationAuditLog> AppAuthorizationAuditLogs { get; set; } = new List<AppAuthorizationAuditLog>();

    public virtual ICollection<AppClaim> AppClaims { get; set; } = new List<AppClaim>();

    public virtual ICollection<AppDelegation> AppDelegations { get; set; } = new List<AppDelegation>();

    public virtual ICollection<AppDocumentApprovalState> AppDocumentApprovalStates { get; set; } = new List<AppDocumentApprovalState>();

    public virtual ICollection<AppModule> AppModules { get; set; } = new List<AppModule>();

    public virtual ICollection<AppPage> AppPages { get; set; } = new List<AppPage>();

    public virtual ICollection<AppPermissionType> AppPermissionTypes { get; set; } = new List<AppPermissionType>();

    public virtual ICollection<AppRoleClaim> AppRoleClaims { get; set; } = new List<AppRoleClaim>();

    public virtual ICollection<AppRoleScope> AppRoleScopes { get; set; } = new List<AppRoleScope>();

    public virtual ICollection<AppTemporaryPermission> AppTemporaryPermissions { get; set; } = new List<AppTemporaryPermission>();

    public virtual ICollection<AppUserClaim> AppUserClaims { get; set; } = new List<AppUserClaim>();

    public virtual ICollection<AppUserScope> AppUserScopes { get; set; } = new List<AppUserScope>();

    public virtual ICollection<AspNetFeaturePermission> AspNetFeaturePermissions { get; set; } = new List<AspNetFeaturePermission>();

    public virtual ICollection<AspNetFeature> AspNetFeatures { get; set; } = new List<AspNetFeature>();

    public virtual ICollection<GibTaxCode> GibTaxCodes { get; set; } = new List<GibTaxCode>();

    public virtual ICollection<GnlCargoCompany> GnlCargoCompanies { get; set; } = new List<GnlCargoCompany>();

    public virtual ICollection<GnlPartnerContact> GnlPartnerContacts { get; set; } = new List<GnlPartnerContact>();

    public virtual ICollection<GnlPartnerGroupAssignment> GnlPartnerGroupAssignments { get; set; } = new List<GnlPartnerGroupAssignment>();

    public virtual ICollection<GnlPartnerGroup> GnlPartnerGroups { get; set; } = new List<GnlPartnerGroup>();

    public virtual ICollection<GnlPartnerSegmentAssignment> GnlPartnerSegmentAssignments { get; set; } = new List<GnlPartnerSegmentAssignment>();

    public virtual ICollection<GnlPartnerSegment> GnlPartnerSegments { get; set; } = new List<GnlPartnerSegment>();

    public virtual ICollection<GnlPrinter> GnlPrinters { get; set; } = new List<GnlPrinter>();

    public virtual ICollection<GnlProductPrice> GnlProductPrices { get; set; } = new List<GnlProductPrice>();

    public virtual ICollection<GnlWorkflowDelegation> GnlWorkflowDelegations { get; set; } = new List<GnlWorkflowDelegation>();

    public virtual ICollection<GnlWorkflowStep> GnlWorkflowSteps { get; set; } = new List<GnlWorkflowStep>();

    public virtual ICollection<GnlWorkflowTemplate> GnlWorkflowTemplates { get; set; } = new List<GnlWorkflowTemplate>();

    public virtual ICollection<HrApplication> HrApplications { get; set; } = new List<HrApplication>();

    public virtual ICollection<HrAttendance> HrAttendances { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrBonusIncentive> HrBonusIncentives { get; set; } = new List<HrBonusIncentive>();

    public virtual ICollection<HrCandidate> HrCandidates { get; set; } = new List<HrCandidate>();

    public virtual ICollection<HrCertificate> HrCertificates { get; set; } = new List<HrCertificate>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDiscipline> HrDisciplines { get; set; } = new List<HrDiscipline>();

    public virtual ICollection<HrDocument> HrDocuments { get; set; } = new List<HrDocument>();

    public virtual ICollection<HrEmployeeSalaryDefinition> HrEmployeeSalaryDefinitions { get; set; } = new List<HrEmployeeSalaryDefinition>();

    public virtual ICollection<HrEmployeeShift> HrEmployeeShifts { get; set; } = new List<HrEmployeeShift>();

    public virtual ICollection<HrEmployeeTraining> HrEmployeeTrainings { get; set; } = new List<HrEmployeeTraining>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrInterview> HrInterviews { get; set; } = new List<HrInterview>();

    public virtual ICollection<HrJobPosting> HrJobPostings { get; set; } = new List<HrJobPosting>();

    public virtual ICollection<HrLeaveBalance> HrLeaveBalances { get; set; } = new List<HrLeaveBalance>();

    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrOffer> HrOffers { get; set; } = new List<HrOffer>();

    public virtual ICollection<HrOnboardingChecklist> HrOnboardingChecklists { get; set; } = new List<HrOnboardingChecklist>();

    public virtual ICollection<HrOnboardingTask> HrOnboardingTasks { get; set; } = new List<HrOnboardingTask>();

    public virtual ICollection<HrOnboarding> HrOnboardings { get; set; } = new List<HrOnboarding>();

    public virtual ICollection<HrPayrollDetail> HrPayrollDetails { get; set; } = new List<HrPayrollDetail>();

    public virtual ICollection<HrPayrollItem> HrPayrollItems { get; set; } = new List<HrPayrollItem>();

    public virtual ICollection<HrPayroll> HrPayrolls { get; set; } = new List<HrPayroll>();

    public virtual ICollection<HrPerformancePeriod> HrPerformancePeriods { get; set; } = new List<HrPerformancePeriod>();

    public virtual ICollection<HrPerformance> HrPerformances { get; set; } = new List<HrPerformance>();

    public virtual ICollection<HrPosition> HrPositions { get; set; } = new List<HrPosition>();

    public virtual ICollection<HrSalaryComponent> HrSalaryComponents { get; set; } = new List<HrSalaryComponent>();

    public virtual ICollection<HrSalaryGrade> HrSalaryGrades { get; set; } = new List<HrSalaryGrade>();

    public virtual ICollection<HrShift> HrShifts { get; set; } = new List<HrShift>();

    public virtual ICollection<HrTraining> HrTrainings { get; set; } = new List<HrTraining>();

    public virtual ICollection<InvAnnualCountLine> InvAnnualCountLines { get; set; } = new List<InvAnnualCountLine>();

    public virtual ICollection<InvAnnualCount> InvAnnualCounts { get; set; } = new List<InvAnnualCount>();

    public virtual ICollection<InvBarcode> InvBarcodes { get; set; } = new List<InvBarcode>();

    public virtual ICollection<InvBatchSerial> InvBatchSerials { get; set; } = new List<InvBatchSerial>();

    public virtual ICollection<InvCostRecalculation> InvCostRecalculations { get; set; } = new List<InvCostRecalculation>();

    public virtual ICollection<InvCycleCountLine> InvCycleCountLines { get; set; } = new List<InvCycleCountLine>();

    public virtual ICollection<InvCycleCount> InvCycleCounts { get; set; } = new List<InvCycleCount>();

    public virtual ICollection<InvExpiryTracking> InvExpiryTrackings { get; set; } = new List<InvExpiryTracking>();

    public virtual ICollection<InvFifolot> InvFifolots { get; set; } = new List<InvFifolot>();

    public virtual ICollection<InvGoodsIssueLine> InvGoodsIssueLines { get; set; } = new List<InvGoodsIssueLine>();

    public virtual ICollection<InvGoodsIssue> InvGoodsIssues { get; set; } = new List<InvGoodsIssue>();

    public virtual ICollection<InvGoodsReceiptLine> InvGoodsReceiptLines { get; set; } = new List<InvGoodsReceiptLine>();

    public virtual ICollection<InvGoodsReceipt> InvGoodsReceipts { get; set; } = new List<InvGoodsReceipt>();

    public virtual ICollection<InvInterDepotTransferLine> InvInterDepotTransferLines { get; set; } = new List<InvInterDepotTransferLine>();

    public virtual ICollection<InvInterDepotTransfer> InvInterDepotTransfers { get; set; } = new List<InvInterDepotTransfer>();

    public virtual ICollection<InvLandedCostDistribution> InvLandedCostDistributions { get; set; } = new List<InvLandedCostDistribution>();

    public virtual ICollection<InvLandedCost> InvLandedCosts { get; set; } = new List<InvLandedCost>();

    public virtual ICollection<InvMinimumStockAlert> InvMinimumStockAlerts { get; set; } = new List<InvMinimumStockAlert>();

    public virtual ICollection<InvReturnFromVesselLine> InvReturnFromVesselLines { get; set; } = new List<InvReturnFromVesselLine>();

    public virtual ICollection<InvReturnToSupplierLine> InvReturnToSupplierLines { get; set; } = new List<InvReturnToSupplierLine>();

    public virtual ICollection<InvReturnsFromVessel> InvReturnsFromVessels { get; set; } = new List<InvReturnsFromVessel>();

    public virtual ICollection<InvReturnsToSupplier> InvReturnsToSuppliers { get; set; } = new List<InvReturnsToSupplier>();

    public virtual ICollection<InvStockMovement> InvStockMovements { get; set; } = new List<InvStockMovement>();

    public virtual ICollection<InvStockOnHand> InvStockOnHands { get; set; } = new List<InvStockOnHand>();

    public virtual ICollection<InvStockTransferLine> InvStockTransferLines { get; set; } = new List<InvStockTransferLine>();

    public virtual ICollection<InvStockTransfer> InvStockTransfers { get; set; } = new List<InvStockTransfer>();

    public virtual ICollection<InvUnitsOfMeasure> InvUnitsOfMeasures { get; set; } = new List<InvUnitsOfMeasure>();

    public virtual ICollection<InvValuationMethod> InvValuationMethods { get; set; } = new List<InvValuationMethod>();

    public virtual ICollection<InvVarianceReportLine> InvVarianceReportLines { get; set; } = new List<InvVarianceReportLine>();

    public virtual ICollection<InvVarianceReport> InvVarianceReports { get; set; } = new List<InvVarianceReport>();

    public virtual ICollection<InvVesselWarehouse> InvVesselWarehouses { get; set; } = new List<InvVesselWarehouse>();

    public virtual ICollection<InvWarehouse> InvWarehouses { get; set; } = new List<InvWarehouse>();

    public virtual ICollection<MailAppConfig> MailAppConfigs { get; set; } = new List<MailAppConfig>();

    public virtual ICollection<OprProjectBudget> OprProjectBudgets { get; set; } = new List<OprProjectBudget>();

    public virtual ICollection<OprProjectDeliverable> OprProjectDeliverables { get; set; } = new List<OprProjectDeliverable>();

    public virtual ICollection<OprProjectPhase> OprProjectPhases { get; set; } = new List<OprProjectPhase>();

    public virtual ICollection<OprProjectTeamMember> OprProjectTeamMembers { get; set; } = new List<OprProjectTeamMember>();

    public virtual ICollection<OprProject> OprProjects { get; set; } = new List<OprProject>();

    public virtual ICollection<ReqEmailTracking> ReqEmailTrackings { get; set; } = new List<ReqEmailTracking>();

    public virtual ICollection<ScmAppointment> ScmAppointments { get; set; } = new List<ScmAppointment>();

    public virtual ICollection<ScmAssetCategory> ScmAssetCategories { get; set; } = new List<ScmAssetCategory>();

    public virtual ICollection<ScmAsset> ScmAssets { get; set; } = new List<ScmAsset>();
}
