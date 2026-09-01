using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using BlueHubShop.Domain.Entities;
namespace BlueHubShop.Persistence.Contexts;

public partial class BlueHubShopDbContext : DbContext
{
    public BlueHubShopDbContext()
    {
    }

    public BlueHubShopDbContext(DbContextOptions<BlueHubShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AiAccessRule> AiAccessRules { get; set; }

    public virtual DbSet<AiAgent> AiAgents { get; set; }

    public virtual DbSet<AiApproval> AiApprovals { get; set; }

    public virtual DbSet<AiApprovalQueue> AiApprovalQueues { get; set; }

    public virtual DbSet<AiConversation> AiConversations { get; set; }

    public virtual DbSet<AiConversationMessage> AiConversationMessages { get; set; }

    public virtual DbSet<AiFeedbackLog> AiFeedbackLogs { get; set; }

    public virtual DbSet<AiKnowledgeBasis> AiKnowledgeBases { get; set; }

    public virtual DbSet<AiKnowledgeChunk> AiKnowledgeChunks { get; set; }

    public virtual DbSet<AiModel> AiModels { get; set; }

    public virtual DbSet<AiPromptTemplate> AiPromptTemplates { get; set; }

    public virtual DbSet<AiProvider> AiProviders { get; set; }

    public virtual DbSet<AiUsageLog> AiUsageLogs { get; set; }

    public virtual DbSet<AipdfTemplate> AipdfTemplates { get; set; }

    public virtual DbSet<AppApprovalLevel> AppApprovalLevels { get; set; }

    public virtual DbSet<AppApprovalMatrix> AppApprovalMatrices { get; set; }

    public virtual DbSet<AppApprovalMatrixStep> AppApprovalMatrixSteps { get; set; }

    public virtual DbSet<AppAuthorizationAuditLog> AppAuthorizationAuditLogs { get; set; }

    public virtual DbSet<AppClaim> AppClaims { get; set; }

    public virtual DbSet<AppDelegation> AppDelegations { get; set; }

    public virtual DbSet<AppDocumentApprovalState> AppDocumentApprovalStates { get; set; }

    public virtual DbSet<AppModule> AppModules { get; set; }

    public virtual DbSet<AppPage> AppPages { get; set; }

    public virtual DbSet<AppPermissionType> AppPermissionTypes { get; set; }

    public virtual DbSet<AppRoleClaim> AppRoleClaims { get; set; }

    public virtual DbSet<AppRoleScope> AppRoleScopes { get; set; }

    public virtual DbSet<AppTemporaryPermission> AppTemporaryPermissions { get; set; }

    public virtual DbSet<AppUserClaim> AppUserClaims { get; set; }

    public virtual DbSet<AppUserScope> AppUserScopes { get; set; }

    public virtual DbSet<AspNetFeature> AspNetFeatures { get; set; }

    public virtual DbSet<AspNetFeaturePermission> AspNetFeaturePermissions { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<ChatCallLog> ChatCallLogs { get; set; }

    public virtual DbSet<ChatGroup> ChatGroups { get; set; }

    public virtual DbSet<ChatGroupMember> ChatGroupMembers { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<ChatMessageAttachment> ChatMessageAttachments { get; set; }

    public virtual DbSet<ChatMessageStatus> ChatMessageStatuses { get; set; }

    public virtual DbSet<Container> Containers { get; set; }

    public virtual DbSet<CtgLevel1> CtgLevel1s { get; set; }

    public virtual DbSet<CtgLevel2> CtgLevel2s { get; set; }

    public virtual DbSet<CtgLevel3> CtgLevel3s { get; set; }

    public virtual DbSet<CtgLevel4> CtgLevel4s { get; set; }

    public virtual DbSet<DimDate> DimDates { get; set; }

    public virtual DbSet<DocFile> DocFiles { get; set; }

    public virtual DbSet<DocFileLink> DocFileLinks { get; set; }

    public virtual DbSet<EmailQueue> EmailQueues { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ExcelTemplate> ExcelTemplates { get; set; }

    public virtual DbSet<FinAccountMapping> FinAccountMappings { get; set; }

    public virtual DbSet<FinAccountPlan> FinAccountPlans { get; set; }

    public virtual DbSet<FinAccountTransaction> FinAccountTransactions { get; set; }

    public virtual DbSet<FinBankAccount> FinBankAccounts { get; set; }

    public virtual DbSet<FinBankTran> FinBankTrans { get; set; }

    public virtual DbSet<FinCashTran> FinCashTrans { get; set; }

    public virtual DbSet<FinCheque> FinCheques { get; set; }

    public virtual DbSet<FinChequeTransaction> FinChequeTransactions { get; set; }

    public virtual DbSet<FinCreditCard> FinCreditCards { get; set; }

    public virtual DbSet<FinCreditCardTransaction> FinCreditCardTransactions { get; set; }

    public virtual DbSet<FinCurrency> FinCurrencies { get; set; }

    public virtual DbSet<FinCurrencyHistory> FinCurrencyHistories { get; set; }

    public virtual DbSet<FinCustomCurrency> FinCustomCurrencies { get; set; }

    public virtual DbSet<FinEinvoiceSetting> FinEinvoiceSettings { get; set; }

    public virtual DbSet<FinGlMapping> FinGlMappings { get; set; }

    public virtual DbSet<FinInvoice> FinInvoices { get; set; }

    public virtual DbSet<FinInvoiceLine> FinInvoiceLines { get; set; }

    public virtual DbSet<FinInvoicePayment> FinInvoicePayments { get; set; }

    public virtual DbSet<FinInvoiceSettlement> FinInvoiceSettlements { get; set; }

    public virtual DbSet<FinPaymentHeader> FinPaymentHeaders { get; set; }

    public virtual DbSet<FinVoucher> FinVouchers { get; set; }

    public virtual DbSet<FinVoucherLine> FinVoucherLines { get; set; }

    public virtual DbSet<FncAccountTransaction> FncAccountTransactions { get; set; }

    public virtual DbSet<GibTaxCode> GibTaxCodes { get; set; }

    public virtual DbSet<GnlAddress> GnlAddresses { get; set; }

    public virtual DbSet<GnlAttachment> GnlAttachments { get; set; }

    public virtual DbSet<GnlBank> GnlBanks { get; set; }

    public virtual DbSet<GnlBranch> GnlBranchs { get; set; }

    public virtual DbSet<GnlBrand> GnlBrands { get; set; }

    public virtual DbSet<GnlCargoCompany> GnlCargoCompanies { get; set; }

    public virtual DbSet<GnlCatalogue> GnlCatalogues { get; set; }

    public virtual DbSet<GnlCategory> GnlCategories { get; set; }

    public virtual DbSet<GnlCategory1> GnlCategories1 { get; set; }

    public virtual DbSet<GnlCertificate> GnlCertificates { get; set; }

    public virtual DbSet<GnlCity> GnlCities { get; set; }

    public virtual DbSet<GnlCompany> GnlCompanies { get; set; }

    public virtual DbSet<GnlCompanyVehicle> GnlCompanyVehicles { get; set; }

    public virtual DbSet<GnlContact> GnlContacts { get; set; }

    public virtual DbSet<GnlContactDetail> GnlContactDetails { get; set; }

    public virtual DbSet<GnlCounter> GnlCounters { get; set; }

    public virtual DbSet<GnlCountry> GnlCountries { get; set; }

    public virtual DbSet<GnlCurrency> GnlCurrencies { get; set; }

    public virtual DbSet<GnlDefination> GnlDefinations { get; set; }

    public virtual DbSet<GnlDocument> GnlDocuments { get; set; }

    public virtual DbSet<GnlEmail> GnlEmails { get; set; }

    public virtual DbSet<GnlEmailAccount> GnlEmailAccounts { get; set; }

    public virtual DbSet<GnlEquipment> GnlEquipments { get; set; }

    public virtual DbSet<GnlImage> GnlImages { get; set; }

    public virtual DbSet<GnlMailSablon> GnlMailSablons { get; set; }

    public virtual DbSet<GnlMailSign> GnlMailSigns { get; set; }

    public virtual DbSet<GnlMenuItem> GnlMenuItems { get; set; }

    public virtual DbSet<GnlModel> GnlModels { get; set; }

    public virtual DbSet<GnlModule> GnlModules { get; set; }

    public virtual DbSet<GnlNotification> GnlNotifications { get; set; }

    public virtual DbSet<GnlNotificationRecipient> GnlNotificationRecipients { get; set; }

    public virtual DbSet<GnlParameter> GnlParameters { get; set; }

    public virtual DbSet<GnlPartner> GnlPartners { get; set; }

    public virtual DbSet<GnlPartnerContact> GnlPartnerContacts { get; set; }

    public virtual DbSet<GnlPartnerGroup> GnlPartnerGroups { get; set; }

    public virtual DbSet<GnlPartnerGroupAssignment> GnlPartnerGroupAssignments { get; set; }

    public virtual DbSet<GnlPartnerSegment> GnlPartnerSegments { get; set; }

    public virtual DbSet<GnlPartnerSegmentAssignment> GnlPartnerSegmentAssignments { get; set; }

    public virtual DbSet<GnlPartnerServiceArea> GnlPartnerServiceAreas { get; set; }

    public virtual DbSet<GnlPort> GnlPorts { get; set; }

    public virtual DbSet<GnlPrinter> GnlPrinters { get; set; }

    public virtual DbSet<GnlProcedure> GnlProcedures { get; set; }

    public virtual DbSet<GnlProcedureLog> GnlProcedureLogs { get; set; }

    public virtual DbSet<GnlProduct> GnlProducts { get; set; }

    public virtual DbSet<GnlProductCategory> GnlProductCategories { get; set; }

    public virtual DbSet<GnlProductFile> GnlProductFiles { get; set; }

    public virtual DbSet<GnlProductGroup> GnlProductGroups { get; set; }

    public virtual DbSet<GnlProductPrice> GnlProductPrices { get; set; }

    public virtual DbSet<GnlProductSupplier> GnlProductSuppliers { get; set; }

    public virtual DbSet<GnlProductSupplierPrice> GnlProductSupplierPrices { get; set; }

    public virtual DbSet<GnlResource> GnlResources { get; set; }

    public virtual DbSet<GnlSayac> GnlSayacs { get; set; }

    public virtual DbSet<GnlServiceArea> GnlServiceAreas { get; set; }

    public virtual DbSet<GnlStockDiscountList> GnlStockDiscountLists { get; set; }

    public virtual DbSet<GnlStore> GnlStores { get; set; }

    public virtual DbSet<GnlSubCategory> GnlSubCategories { get; set; }

    public virtual DbSet<GnlSubItem> GnlSubItems { get; set; }

    public virtual DbSet<GnlTown> GnlTowns { get; set; }

    public virtual DbSet<GnlUtility> GnlUtilities { get; set; }

    public virtual DbSet<GnlVessel> GnlVessels { get; set; }

    public virtual DbSet<GnlVesselCategory> GnlVesselCategories { get; set; }

    public virtual DbSet<GnlWorkflowDelegation> GnlWorkflowDelegations { get; set; }

    public virtual DbSet<GnlWorkflowHistory> GnlWorkflowHistories { get; set; }

    public virtual DbSet<GnlWorkflowStep> GnlWorkflowSteps { get; set; }

    public virtual DbSet<GnlWorkflowTemplate> GnlWorkflowTemplates { get; set; }

    public virtual DbSet<HrApplication> HrApplications { get; set; }

    public virtual DbSet<HrAttendance> HrAttendances { get; set; }

    public virtual DbSet<HrBonusIncentive> HrBonusIncentives { get; set; }

    public virtual DbSet<HrCandidate> HrCandidates { get; set; }

    public virtual DbSet<HrCertificate> HrCertificates { get; set; }

    public virtual DbSet<HrContract> HrContracts { get; set; }

    public virtual DbSet<HrDepartment> HrDepartments { get; set; }

    public virtual DbSet<HrDiscipline> HrDisciplines { get; set; }

    public virtual DbSet<HrDocument> HrDocuments { get; set; }

    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    public virtual DbSet<HrEmployeeSalaryDefinition> HrEmployeeSalaryDefinitions { get; set; }

    public virtual DbSet<HrEmployeeShift> HrEmployeeShifts { get; set; }

    public virtual DbSet<HrEmployeeTraining> HrEmployeeTrainings { get; set; }

    public virtual DbSet<HrInterview> HrInterviews { get; set; }

    public virtual DbSet<HrJobPosting> HrJobPostings { get; set; }

    public virtual DbSet<HrLeave> HrLeaves { get; set; }

    public virtual DbSet<HrLeaveBalance> HrLeaveBalances { get; set; }

    public virtual DbSet<HrLeaveType> HrLeaveTypes { get; set; }

    public virtual DbSet<HrOffer> HrOffers { get; set; }

    public virtual DbSet<HrOnboarding> HrOnboardings { get; set; }

    public virtual DbSet<HrOnboardingChecklist> HrOnboardingChecklists { get; set; }

    public virtual DbSet<HrOnboardingTask> HrOnboardingTasks { get; set; }

    public virtual DbSet<HrPayroll> HrPayrolls { get; set; }

    public virtual DbSet<HrPayrollDetail> HrPayrollDetails { get; set; }

    public virtual DbSet<HrPayrollItem> HrPayrollItems { get; set; }

    public virtual DbSet<HrPerformance> HrPerformances { get; set; }

    public virtual DbSet<HrPerformancePeriod> HrPerformancePeriods { get; set; }

    public virtual DbSet<HrPosition> HrPositions { get; set; }

    public virtual DbSet<HrSalaryComponent> HrSalaryComponents { get; set; }

    public virtual DbSet<HrSalaryGrade> HrSalaryGrades { get; set; }

    public virtual DbSet<HrShift> HrShifts { get; set; }

    public virtual DbSet<HrTraining> HrTrainings { get; set; }

    public virtual DbSet<IntProcureShipInbox> IntProcureShipInboxes { get; set; }

    public virtual DbSet<IntProcureShipLog> IntProcureShipLogs { get; set; }

    public virtual DbSet<IntShipServDocument> IntShipServDocuments { get; set; }

    public virtual DbSet<IntShipServIncomingOrder> IntShipServIncomingOrders { get; set; }

    public virtual DbSet<IntShipServIncomingRfq> IntShipServIncomingRfqs { get; set; }

    public virtual DbSet<IntShipServIncomingRfqline> IntShipServIncomingRfqlines { get; set; }

    public virtual DbSet<IntShipServSentQuotation> IntShipServSentQuotations { get; set; }

    public virtual DbSet<InvAnnualCount> InvAnnualCounts { get; set; }

    public virtual DbSet<InvAnnualCountLine> InvAnnualCountLines { get; set; }

    public virtual DbSet<InvBarcode> InvBarcodes { get; set; }

    public virtual DbSet<InvBatchSerial> InvBatchSerials { get; set; }

    public virtual DbSet<InvCostRecalculation> InvCostRecalculations { get; set; }

    public virtual DbSet<InvCycleCount> InvCycleCounts { get; set; }

    public virtual DbSet<InvCycleCountLine> InvCycleCountLines { get; set; }

    public virtual DbSet<InvDeliveryHeader> InvDeliveryHeaders { get; set; }

    public virtual DbSet<InvDeliveryLine> InvDeliveryLines { get; set; }

    public virtual DbSet<InvExpiryTracking> InvExpiryTrackings { get; set; }

    public virtual DbSet<InvFifolot> InvFifolots { get; set; }

    public virtual DbSet<InvGoodsIssue> InvGoodsIssues { get; set; }

    public virtual DbSet<InvGoodsIssueLine> InvGoodsIssueLines { get; set; }

    public virtual DbSet<InvGoodsIssueLineImage> InvGoodsIssueLineImages { get; set; }

    public virtual DbSet<InvGoodsReceipt> InvGoodsReceipts { get; set; }

    public virtual DbSet<InvGoodsReceiptLine> InvGoodsReceiptLines { get; set; }

    public virtual DbSet<InvGoodsReceiptLineImage> InvGoodsReceiptLineImages { get; set; }

    public virtual DbSet<InvInterDepotTransfer> InvInterDepotTransfers { get; set; }

    public virtual DbSet<InvInterDepotTransferLine> InvInterDepotTransferLines { get; set; }

    public virtual DbSet<InvLandedCost> InvLandedCosts { get; set; }

    public virtual DbSet<InvLandedCostDistribution> InvLandedCostDistributions { get; set; }

    public virtual DbSet<InvMinimumStockAlert> InvMinimumStockAlerts { get; set; }

    public virtual DbSet<InvReturnFromVesselLine> InvReturnFromVesselLines { get; set; }

    public virtual DbSet<InvReturnToSupplierLine> InvReturnToSupplierLines { get; set; }

    public virtual DbSet<InvReturnsFromVessel> InvReturnsFromVessels { get; set; }

    public virtual DbSet<InvReturnsToSupplier> InvReturnsToSuppliers { get; set; }

    public virtual DbSet<InvStock> InvStocks { get; set; }

    public virtual DbSet<InvStockImage> InvStockImages { get; set; }

    public virtual DbSet<InvStockMovement> InvStockMovements { get; set; }

    public virtual DbSet<InvStockOnHand> InvStockOnHands { get; set; }

    public virtual DbSet<InvStockTran> InvStockTrans { get; set; }

    public virtual DbSet<InvStockTransfer> InvStockTransfers { get; set; }

    public virtual DbSet<InvStockTransferLine> InvStockTransferLines { get; set; }

    public virtual DbSet<InvStore> InvStores { get; set; }

    public virtual DbSet<InvUnitsOfMeasure> InvUnitsOfMeasures { get; set; }

    public virtual DbSet<InvValuationMethod> InvValuationMethods { get; set; }

    public virtual DbSet<InvVarianceReport> InvVarianceReports { get; set; }

    public virtual DbSet<InvVarianceReportLine> InvVarianceReportLines { get; set; }

    public virtual DbSet<InvVesselWarehouse> InvVesselWarehouses { get; set; }

    public virtual DbSet<InvWarehouse> InvWarehouses { get; set; }

    public virtual DbSet<LojBillsOfLading> LojBillsOfLadings { get; set; }

    public virtual DbSet<LojBondedWarehouse> LojBondedWarehouses { get; set; }

    public virtual DbSet<LojCargo> LojCargos { get; set; }

    public virtual DbSet<LojContainer> LojContainers { get; set; }

    public virtual DbSet<LojContainerDamageReport> LojContainerDamageReports { get; set; }

    public virtual DbSet<LojCustomsDeclaration> LojCustomsDeclarations { get; set; }

    public virtual DbSet<LojCustomsDeclarationItem> LojCustomsDeclarationItems { get; set; }

    public virtual DbSet<LojFreightInvoice> LojFreightInvoices { get; set; }

    public virtual DbSet<LojFreightInvoiceItem> LojFreightInvoiceItems { get; set; }

    public virtual DbSet<LojLogisticsAlert> LojLogisticsAlerts { get; set; }

    public virtual DbSet<LojPortCall> LojPortCalls { get; set; }

    public virtual DbSet<LojRoutePort> LojRoutePorts { get; set; }

    public virtual DbSet<LojShipment> LojShipments { get; set; }

    public virtual DbSet<LojShipmentCargo> LojShipmentCargos { get; set; }

    public virtual DbSet<LojShipmentContainer> LojShipmentContainers { get; set; }

    public virtual DbSet<LojShipmentCost> LojShipmentCosts { get; set; }

    public virtual DbSet<LojShipmentDocument> LojShipmentDocuments { get; set; }

    public virtual DbSet<LojShippingRoute> LojShippingRoutes { get; set; }

    public virtual DbSet<LojSupplierPerformance> LojSupplierPerformances { get; set; }

    public virtual DbSet<LojVesselFuelConsumption> LojVesselFuelConsumptions { get; set; }

    public virtual DbSet<LojVoyageProfitability> LojVoyageProfitabilities { get; set; }

    public virtual DbSet<MailAccount> MailAccounts { get; set; }

    public virtual DbSet<MailAppConfig> MailAppConfigs { get; set; }

    public virtual DbSet<MailAttachment> MailAttachments { get; set; }

    public virtual DbSet<MailCategory> MailCategories { get; set; }

    public virtual DbSet<MailFolder> MailFolders { get; set; }

    public virtual DbSet<MailMessage> MailMessages { get; set; }

    public virtual DbSet<MailMessageCategory> MailMessageCategories { get; set; }

    public virtual DbSet<MailTracking> MailTrackings { get; set; }

    public virtual DbSet<MsgNotification> MsgNotifications { get; set; }

    public virtual DbSet<MsgNotificationUser> MsgNotificationUsers { get; set; }

    public virtual DbSet<OfferApprovalToken> OfferApprovalTokens { get; set; }

    public virtual DbSet<OprProject> OprProjects { get; set; }

    public virtual DbSet<OprProjectBudget> OprProjectBudgets { get; set; }

    public virtual DbSet<OprProjectDeliverable> OprProjectDeliverables { get; set; }

    public virtual DbSet<OprProjectPhase> OprProjectPhases { get; set; }

    public virtual DbSet<OprProjectTask> OprProjectTasks { get; set; }

    public virtual DbSet<OprProjectTeamMember> OprProjectTeamMembers { get; set; }

    public virtual DbSet<OprToDo> OprToDos { get; set; }

    public virtual DbSet<OprVesselVisit> OprVesselVisits { get; set; }

    public virtual DbSet<PdfVisualTemplate> PdfVisualTemplates { get; set; }

    public virtual DbSet<PentestOut> PentestOuts { get; set; }

    public virtual DbSet<ReqDiscountList> ReqDiscountLists { get; set; }

    public virtual DbSet<ReqEmailTracking> ReqEmailTrackings { get; set; }

    public virtual DbSet<ReqOffer> ReqOffers { get; set; }

    public virtual DbSet<ReqOfferDetail> ReqOfferDetails { get; set; }

    public virtual DbSet<ReqOrder> ReqOrders { get; set; }

    public virtual DbSet<ReqOrderDetail> ReqOrderDetails { get; set; }

    public virtual DbSet<ReqPicker> ReqPickers { get; set; }

    public virtual DbSet<ReqPickerDetail> ReqPickerDetails { get; set; }

    public virtual DbSet<ReqPriceList> ReqPriceLists { get; set; }

    public virtual DbSet<ReqProforma> ReqProformas { get; set; }

    public virtual DbSet<ReqProformaDetail> ReqProformaDetails { get; set; }

    public virtual DbSet<ReqRequest> ReqRequests { get; set; }

    public virtual DbSet<ReqRequestDetail> ReqRequestDetails { get; set; }

    public virtual DbSet<ReqRequestItem> ReqRequestItems { get; set; }

    public virtual DbSet<ReqRequestSupplierProduct> ReqRequestSupplierProducts { get; set; }

    public virtual DbSet<ReqRequestSupplierProductFile> ReqRequestSupplierProductFiles { get; set; }

    public virtual DbSet<ScmAppointment> ScmAppointments { get; set; }

    public virtual DbSet<ScmAsset> ScmAssets { get; set; }

    public virtual DbSet<ScmAssetCategory> ScmAssetCategories { get; set; }

    public virtual DbSet<ScmAssetType> ScmAssetTypes { get; set; }

    public virtual DbSet<ScmCalibration> ScmCalibrations { get; set; }

    public virtual DbSet<ScmCalibrationMeasurement> ScmCalibrationMeasurements { get; set; }

    public virtual DbSet<ScmCertificate> ScmCertificates { get; set; }

    public virtual DbSet<ScmCertificateRenewal> ScmCertificateRenewals { get; set; }

    public virtual DbSet<ScmCertificateType> ScmCertificateTypes { get; set; }

    public virtual DbSet<ScmCertificateVersion> ScmCertificateVersions { get; set; }

    public virtual DbSet<ScmCustomerCommunication> ScmCustomerCommunications { get; set; }

    public virtual DbSet<ScmCustomerSite> ScmCustomerSites { get; set; }

    public virtual DbSet<ScmInspection> ScmInspections { get; set; }

    public virtual DbSet<ScmInspectionDetail> ScmInspectionDetails { get; set; }

    public virtual DbSet<ScmNonConformity> ScmNonConformities { get; set; }

    public virtual DbSet<ScmNotification> ScmNotifications { get; set; }

    public virtual DbSet<ScmNotificationTemplate> ScmNotificationTemplates { get; set; }

    public virtual DbSet<ScmReminder> ScmReminders { get; set; }

    public virtual DbSet<ScmReminderRule> ScmReminderRules { get; set; }

    public virtual DbSet<ScmServiceChecklist> ScmServiceChecklists { get; set; }

    public virtual DbSet<ScmServiceChecklistItem> ScmServiceChecklistItems { get; set; }

    public virtual DbSet<ScmServiceChecklistResult> ScmServiceChecklistResults { get; set; }

    public virtual DbSet<ScmServiceContract> ScmServiceContracts { get; set; }

    public virtual DbSet<ScmServiceContractAsset> ScmServiceContractAssets { get; set; }

    public virtual DbSet<ScmServiceJob> ScmServiceJobs { get; set; }

    public virtual DbSet<ScmServiceJobActivity> ScmServiceJobActivities { get; set; }

    public virtual DbSet<ScmServicePlan> ScmServicePlans { get; set; }

    public virtual DbSet<ScmServiceRequest> ScmServiceRequests { get; set; }

    public virtual DbSet<ScmServiceRequestDetail> ScmServiceRequestDetails { get; set; }

    public virtual DbSet<ScmServiceType> ScmServiceTypes { get; set; }

    public virtual DbSet<ScmTechnician> ScmTechnicians { get; set; }

    public virtual DbSet<ScmTechnicianQualification> ScmTechnicianQualifications { get; set; }

    public virtual DbSet<ScmTechnicianSkill> ScmTechnicianSkills { get; set; }

    public virtual DbSet<ScmWorkOrder> ScmWorkOrders { get; set; }

    public virtual DbSet<ScmWorkOrderDetail> ScmWorkOrderDetails { get; set; }

    public virtual DbSet<SrvServiceCatalog> SrvServiceCatalogs { get; set; }

    public virtual DbSet<SrvServiceCategory> SrvServiceCategories { get; set; }

    public virtual DbSet<SrvServiceContract> SrvServiceContracts { get; set; }

    public virtual DbSet<SrvServiceRequest> SrvServiceRequests { get; set; }

    public virtual DbSet<SrvServiceVisit> SrvServiceVisits { get; set; }

    public virtual DbSet<SrvSlatemplate> SrvSlatemplates { get; set; }

    public virtual DbSet<SysObjectChecksum> SysObjectChecksums { get; set; }

    public virtual DbSet<SysParam> SysParams { get; set; }

    public virtual DbSet<TelegramMessage> TelegramMessages { get; set; }

    public virtual DbSet<VCatchError> VCatchErrors { get; set; }

    public virtual DbSet<VFirstLastDayOfMonth> VFirstLastDayOfMonths { get; set; }

    public virtual DbSet<VInvoiceAll> VInvoiceAlls { get; set; }

    public virtual DbSet<VNotification> VNotifications { get; set; }

    public virtual DbSet<VPurOffer> VPurOffers { get; set; }

    public virtual DbSet<VPurOfferCount> VPurOfferCounts { get; set; }

    public virtual DbSet<VPurRequest> VPurRequests { get; set; }

    public virtual DbSet<VResource> VResources { get; set; }

    public virtual DbSet<VStockBrand> VStockBrands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=149.34.201.53; Database=GEMINI_TEST; User ID=sa; Password=Oryx123!; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AiAccessRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Acces__3214EC07D3D75E0F");

            entity.ToTable("AI_AccessRules");

            entity.Property(e => e.AllowUse).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AiAgent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Agent__3214EC0704DEE459");

            entity.ToTable("AI_Agents");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AgentName).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(100);

            entity.HasOne(d => d.DefaultModel).WithMany(p => p.AiAgents)
                .HasForeignKey(d => d.DefaultModelId)
                .HasConstraintName("FK_AI_Agents_Model");
        });

        modelBuilder.Entity<AiApproval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Appro__3214EC072C813167");

            entity.ToTable("AI_Approvals");

            entity.Property(e => e.Aioutput).HasColumnName("AIOutput");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.ReviewedBy).HasMaxLength(100);
            entity.Property(e => e.ReviewedDate).HasColumnType("datetime");
            entity.Property(e => e.ReviewerNote).HasMaxLength(1000);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");
        });

        modelBuilder.Entity<AiApprovalQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Appro__3214EC07DFF50B35");

            entity.ToTable("AI_ApprovalQueue");

            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RejectedReason).HasMaxLength(1000);
        });

        modelBuilder.Entity<AiConversation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Conve__3214EC07986B50B4");

            entity.ToTable("AI_Conversations");

            entity.Property(e => e.ConversationGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        modelBuilder.Entity<AiConversationMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Conve__3214EC0766062691");

            entity.ToTable("AI_ConversationMessages");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MessageRole).HasMaxLength(20);
        });

        modelBuilder.Entity<AiFeedbackLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Feedb__3214EC07431CE0DE");

            entity.ToTable("AI_FeedbackLogs");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeedbackText).HasMaxLength(1000);
        });

        modelBuilder.Entity<AiKnowledgeBasis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Knowl__3214EC071AE08326");

            entity.ToTable("AI_KnowledgeBases");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.KnowledgeType).HasMaxLength(50);
            entity.Property(e => e.LanguageCode).HasMaxLength(10);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(100);
            entity.Property(e => e.SourceName).HasMaxLength(250);
            entity.Property(e => e.SourcePath).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.VersionNo).HasDefaultValue(1);
        });

        modelBuilder.Entity<AiKnowledgeChunk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Knowl__3214EC07928BB42B");

            entity.ToTable("AI_KnowledgeChunks");

            entity.Property(e => e.ChunkSummary).HasMaxLength(1000);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Keywords).HasMaxLength(1000);

            entity.HasOne(d => d.KnowledgeBase).WithMany(p => p.AiKnowledgeChunks)
                .HasForeignKey(d => d.KnowledgeBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AI_KnowledgeChunks_KnowledgeBase");
        });

        modelBuilder.Entity<AiModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Model__3214EC0765E4F26E");

            entity.ToTable("AI_Models");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InputTokenPrice).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModelCode).HasMaxLength(100);
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OutputTokenPrice).HasColumnType("decimal(18, 8)");

            entity.HasOne(d => d.Provider).WithMany(p => p.AiModels)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AI_Models_Provider");
        });

        modelBuilder.Entity<AiPromptTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Promp__3214EC071BE2331A");

            entity.ToTable("AI_PromptTemplates");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LanguageCode).HasMaxLength(10);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateCode).HasMaxLength(100);
            entity.Property(e => e.TemplateName).HasMaxLength(150);
            entity.Property(e => e.VersionNo).HasDefaultValue(1);
        });

        modelBuilder.Entity<AiProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Provi__3214EC071BCD8775");

            entity.ToTable("AI_Providers");

            entity.Property(e => e.BaseUrl).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProviderCode).HasMaxLength(50);
            entity.Property(e => e.ProviderName).HasMaxLength(100);
        });

        modelBuilder.Entity<AiUsageLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AI_Usage__3214EC0730FE8919");

            entity.ToTable("AI_UsageLogs");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EstimatedCost).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.ExecutionStatus).HasMaxLength(20);
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<AipdfTemplate>(entity =>
        {
            entity.ToTable("AIPdfTemplate");

            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.IdentifierKeywords).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TemplateName).HasMaxLength(200);
        });

        modelBuilder.Entity<AppApprovalLevel>(entity =>
        {
            entity.ToTable("App_ApprovalLevels");

            entity.HasIndex(e => e.Code, "IX_App_ApprovalLevels_Code").IsUnique();

            entity.HasIndex(e => e.CompanyId, "IX_App_ApprovalLevels_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.AppApprovalLevels).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppApprovalMatrix>(entity =>
        {
            entity.ToTable("App_ApprovalMatrices");

            entity.HasIndex(e => new { e.CompanyId, e.ModuleCode, e.DocumentType }, "IX_App_ApprovalMatrices_CompanyId_ModuleCode_DocumentType");

            entity.Property(e => e.CurrencyCode).HasMaxLength(3);
            entity.Property(e => e.DocumentType).HasMaxLength(100);
            entity.Property(e => e.MaximumAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MinimumAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModuleCode).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.AppApprovalMatrices).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppApprovalMatrixStep>(entity =>
        {
            entity.ToTable("App_ApprovalMatrixSteps");

            entity.HasIndex(e => e.ApprovalLevelId, "IX_App_ApprovalMatrixSteps_ApprovalLevelId");

            entity.HasIndex(e => new { e.ApprovalMatrixId, e.Sequence }, "IX_App_ApprovalMatrixSteps_ApprovalMatrixId_Sequence").IsUnique();

            entity.HasIndex(e => e.CompanyId, "IX_App_ApprovalMatrixSteps_CompanyId");

            entity.HasIndex(e => e.RequiredClaimId, "IX_App_ApprovalMatrixSteps_RequiredClaimId");

            entity.Property(e => e.RequiredRoleId).HasMaxLength(450);
            entity.Property(e => e.StepName).HasMaxLength(100);

            entity.HasOne(d => d.ApprovalLevel).WithMany(p => p.AppApprovalMatrixSteps).HasForeignKey(d => d.ApprovalLevelId);

            entity.HasOne(d => d.ApprovalMatrix).WithMany(p => p.AppApprovalMatrixSteps).HasForeignKey(d => d.ApprovalMatrixId);

            entity.HasOne(d => d.Company).WithMany(p => p.AppApprovalMatrixSteps).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.RequiredClaim).WithMany(p => p.AppApprovalMatrixSteps).HasForeignKey(d => d.RequiredClaimId);
        });

        modelBuilder.Entity<AppAuthorizationAuditLog>(entity =>
        {
            entity.ToTable("App_AuthorizationAuditLogs");

            entity.HasIndex(e => new { e.CompanyId, e.UserId, e.CreatedDate }, "IX_App_AuthorizationAuditLogs_CompanyId_UserId_CreatedDate");

            entity.Property(e => e.Action).HasMaxLength(100);
            entity.Property(e => e.EntityId).HasMaxLength(100);
            entity.Property(e => e.EntityType).HasMaxLength(100);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.RequestPath).HasMaxLength(500);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.AppAuthorizationAuditLogs).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppClaim>(entity =>
        {
            entity.ToTable("App_Claims");

            entity.HasIndex(e => e.ClaimValue, "IX_App_Claims_ClaimValue").IsUnique();

            entity.HasIndex(e => e.CompanyId, "IX_App_Claims_CompanyId");

            entity.HasIndex(e => new { e.ModuleId, e.PageId, e.PermissionTypeId }, "IX_App_Claims_ModuleId_PageId_PermissionTypeId");

            entity.HasIndex(e => e.PageId, "IX_App_Claims_PageId");

            entity.HasIndex(e => e.PermissionTypeId, "IX_App_Claims_PermissionTypeId");

            entity.Property(e => e.ClaimValue).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.AppClaims).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Module).WithMany(p => p.AppClaims).HasForeignKey(d => d.ModuleId);

            entity.HasOne(d => d.Page).WithMany(p => p.AppClaims).HasForeignKey(d => d.PageId);

            entity.HasOne(d => d.PermissionType).WithMany(p => p.AppClaims).HasForeignKey(d => d.PermissionTypeId);
        });

        modelBuilder.Entity<AppDelegation>(entity =>
        {
            entity.ToTable("App_Delegations");

            entity.HasIndex(e => e.CompanyId, "IX_App_Delegations_CompanyId");

            entity.HasIndex(e => new { e.DelegatorUserId, e.DelegateeUserId, e.Active }, "IX_App_Delegations_DelegatorUserId_DelegateeUserId_Active");

            entity.Property(e => e.Reason).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.AppDelegations).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppDocumentApprovalState>(entity =>
        {
            entity.HasIndex(e => e.ApprovalMatrixId, "IX_AppDocumentApprovalStates_ApprovalMatrixId");

            entity.HasIndex(e => e.CompanyId, "IX_AppDocumentApprovalStates_CompanyId");

            entity.Property(e => e.ModuleCode).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);

            entity.HasOne(d => d.ApprovalMatrix).WithMany(p => p.AppDocumentApprovalStates).HasForeignKey(d => d.ApprovalMatrixId);

            entity.HasOne(d => d.Company).WithMany(p => p.AppDocumentApprovalStates).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppModule>(entity =>
        {
            entity.ToTable("App_Modules");

            entity.HasIndex(e => e.Code, "IX_App_Modules_Code").IsUnique();

            entity.HasIndex(e => new { e.CompanyId, e.Active, e.IsDeleted }, "IX_App_Modules_CompanyId_Active_IsDeleted");

            entity.Property(e => e.Area).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Route).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.AppModules).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppPage>(entity =>
        {
            entity.ToTable("App_Pages");

            entity.HasIndex(e => new { e.CompanyId, e.Active, e.IsDeleted }, "IX_App_Pages_CompanyId_Active_IsDeleted");

            entity.HasIndex(e => new { e.ModuleId, e.Code }, "IX_App_Pages_ModuleId_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Controller).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Route).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.AppPages).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Module).WithMany(p => p.AppPages)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AppPermissionType>(entity =>
        {
            entity.ToTable("App_PermissionTypes");

            entity.HasIndex(e => e.Code, "IX_App_PermissionTypes_Code").IsUnique();

            entity.HasIndex(e => e.CompanyId, "IX_App_PermissionTypes_CompanyId");

            entity.HasIndex(e => e.PermissionCode, "IX_App_PermissionTypes_PermissionCode").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.AppPermissionTypes).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppRoleClaim>(entity =>
        {
            entity.ToTable("App_RoleClaims");

            entity.HasIndex(e => e.ClaimId, "IX_App_RoleClaims_ClaimId");

            entity.HasIndex(e => e.CompanyId, "IX_App_RoleClaims_CompanyId");

            entity.HasIndex(e => new { e.RoleId, e.ClaimId }, "IX_App_RoleClaims_RoleId_ClaimId").IsUnique();

            entity.HasOne(d => d.Claim).WithMany(p => p.AppRoleClaims)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Company).WithMany(p => p.AppRoleClaims).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppRoleScope>(entity =>
        {
            entity.ToTable("App_RoleScopes");

            entity.HasIndex(e => e.CompanyId, "IX_App_RoleScopes_CompanyId");

            entity.HasIndex(e => new { e.RoleId, e.ScopeType, e.ScopeId }, "IX_App_RoleScopes_RoleId_ScopeType_ScopeId")
                .IsUnique()
                .HasFilter("([ScopeId] IS NOT NULL)");

            entity.Property(e => e.ScopeType).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.AppRoleScopes).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppTemporaryPermission>(entity =>
        {
            entity.ToTable("App_TemporaryPermissions");

            entity.HasIndex(e => e.ClaimId, "IX_App_TemporaryPermissions_ClaimId");

            entity.HasIndex(e => e.CompanyId, "IX_App_TemporaryPermissions_CompanyId");

            entity.HasIndex(e => new { e.UserId, e.ClaimId, e.Active }, "IX_App_TemporaryPermissions_UserId_ClaimId_Active");

            entity.Property(e => e.Reason).HasMaxLength(500);

            entity.HasOne(d => d.Claim).WithMany(p => p.AppTemporaryPermissions)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Company).WithMany(p => p.AppTemporaryPermissions).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppUserClaim>(entity =>
        {
            entity.ToTable("App_UserClaims");

            entity.HasIndex(e => e.ClaimId, "IX_App_UserClaims_ClaimId");

            entity.HasIndex(e => e.CompanyId, "IX_App_UserClaims_CompanyId");

            entity.HasIndex(e => new { e.UserId, e.ClaimId }, "IX_App_UserClaims_UserId_ClaimId").IsUnique();

            entity.HasOne(d => d.Claim).WithMany(p => p.AppUserClaims)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Company).WithMany(p => p.AppUserClaims).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AppUserScope>(entity =>
        {
            entity.ToTable("App_UserScopes");

            entity.HasIndex(e => e.CompanyId, "IX_App_UserScopes_CompanyId");

            entity.HasIndex(e => new { e.UserId, e.ScopeType, e.ScopeId }, "IX_App_UserScopes_UserId_ScopeType_ScopeId")
                .IsUnique()
                .HasFilter("([ScopeId] IS NOT NULL)");

            entity.Property(e => e.ScopeType).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.AppUserScopes).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AspNetFeature>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_AspNetFeatures_CompanyId");

            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.FeatureKey).HasMaxLength(100);
            entity.Property(e => e.Module).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.AspNetFeatures).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<AspNetFeaturePermission>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_AspNetFeaturePermissions_CompanyId");

            entity.HasIndex(e => e.FeatureId, "IX_AspNetFeaturePermissions_FeatureId");

            entity.Property(e => e.DecimalValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RoleId).HasMaxLength(450);
            entity.Property(e => e.StringValue).HasMaxLength(500);
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Company).WithMany(p => p.AspNetFeaturePermissions).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Feature).WithMany(p => p.AspNetFeaturePermissions).HasForeignKey(d => d.FeatureId);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Action).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(100);
            entity.Property(e => e.ClaimValue).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Module).HasMaxLength(100);
            entity.Property(e => e.RoleId).HasMaxLength(450);
            entity.Property(e => e.VesselId).HasDefaultValue(99);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.HasIndex(e => e.Name, "UQ_AspNetUsers_Name").IsUnique();

            entity.Property(e => e.Admin).HasDefaultValue(false);
            entity.Property(e => e.BranchId).HasDefaultValue(0);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.ContactId).HasDefaultValue(0);
            entity.Property(e => e.CurrentSessionKey).HasMaxLength(450);
            entity.Property(e => e.DateCreated).HasPrecision(3);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Discriminator).HasDefaultValue("");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PartnerName).HasMaxLength(255);
            entity.Property(e => e.Pswd).HasColumnName("pswd");
            entity.Property(e => e.RefId).HasDefaultValue(0);
            entity.Property(e => e.RefName).HasMaxLength(256);
            entity.Property(e => e.RefType).HasMaxLength(30);
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey }).HasFillFactor(85);

            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId }).HasFillFactor(85);
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AuditLog__3214EC07C6982C54");

            entity.ToTable("AuditLog");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.DocumentNumber).HasMaxLength(50);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.TransactionCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ChatCallLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatCall__3214EC076277C525");

            entity.Property(e => e.CallType).HasMaxLength(20);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.StartedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Initiated");
        });

        modelBuilder.Entity<ChatGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatGrou__3214EC07EBD2E775");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.GroupName).HasMaxLength(150);
        });

        modelBuilder.Entity<ChatGroupMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatGrou__3214EC0734B4CA85");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.JoinedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasDefaultValue("Member");
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Group).WithMany(p => p.ChatGroupMembers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_ChatGroupMembers_ChatGroups");
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatMess__3214EC076B95D59B");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.MessageType)
                .HasMaxLength(50)
                .HasDefaultValue("Text");
            entity.Property(e => e.SentAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.TargetGroup).WithMany(p => p.ChatMessages)
                .HasForeignKey(d => d.TargetGroupId)
                .HasConstraintName("FK_ChatMessages_ChatGroups");
        });

        modelBuilder.Entity<ChatMessageAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatMess__3214EC0778757C59");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FilePath).HasMaxLength(500);

            entity.HasOne(d => d.Message).WithMany(p => p.ChatMessageAttachments)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_ChatMessageAttachments_ChatMessages");
        });

        modelBuilder.Entity<ChatMessageStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChatMess__3214EC07A4D10FC0");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Message).WithMany(p => p.ChatMessageStatuses)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_ChatMessageStatuses_ChatMessages");
        });

        modelBuilder.Entity<Container>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Containe__3214EC07378EEEAB");

            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.ContainerNo).HasMaxLength(20);
            entity.Property(e => e.ContainerSize).HasMaxLength(50);
            entity.Property(e => e.ContainerType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentLocation).HasMaxLength(200);
            entity.Property(e => e.CurrentTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DamageDescription).HasMaxLength(500);
            entity.Property(e => e.InternalVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxGrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxPayload).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SetTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TareWeight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CtgLevel1>(entity =>
        {
            entity.ToTable("Ctg_Level1");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Tkey)
                .HasMaxLength(50)
                .HasColumnName("TKey");
        });

        modelBuilder.Entity<CtgLevel2>(entity =>
        {
            entity.ToTable("Ctg_Level2");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Level1Id).HasDefaultValue(0);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Tkey)
                .HasMaxLength(50)
                .HasColumnName("TKey");
        });

        modelBuilder.Entity<CtgLevel3>(entity =>
        {
            entity.ToTable("Ctg_Level3");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Level1Id).HasDefaultValue(0);
            entity.Property(e => e.Level2Id).HasDefaultValue(0);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Tkey)
                .HasMaxLength(50)
                .HasColumnName("TKey");
        });

        modelBuilder.Entity<CtgLevel4>(entity =>
        {
            entity.ToTable("Ctg_Level4");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Level1Id).HasDefaultValue(0);
            entity.Property(e => e.Level2Id).HasDefaultValue(0);
            entity.Property(e => e.Level3Id).HasDefaultValue(0);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Tkey)
                .HasMaxLength(50)
                .HasColumnName("TKey");
        });

        modelBuilder.Entity<DimDate>(entity =>
        {
            entity.HasKey(e => e.Date).HasFillFactor(85);

            entity.ToTable("DIM_Date");

            entity.Property(e => e.Date1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Date2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateKey)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DayName).HasMaxLength(255);
            entity.Property(e => e.DayNameTr).HasMaxLength(255);
            entity.Property(e => e.DaySuffix)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HolidayName).HasMaxLength(255);
            entity.Property(e => e.HolidayNameTr).HasMaxLength(255);
            entity.Property(e => e.MonthName).HasMaxLength(255);
            entity.Property(e => e.MonthNameTr).HasMaxLength(255);
            entity.Property(e => e.WeekOfYearIso).HasColumnName("WeekOfYearISO");
        });

        modelBuilder.Entity<DocFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DOC_File__3214EC07E48E8045");

            entity.ToTable("DOC_File");

            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FileHash).HasMaxLength(64);
            entity.Property(e => e.FileName).HasMaxLength(260);
            entity.Property(e => e.OriginalName).HasMaxLength(260);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.StoragePath).HasMaxLength(500);
            entity.Property(e => e.StorageType).HasDefaultValue((byte)2);
        });

        modelBuilder.Entity<DocFileLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DOC_File__3214EC07A1C7FD6D");

            entity.ToTable("DOC_FileLink");

            entity.HasIndex(e => new { e.CompanyId, e.EntityName, e.EntityId }, "IX_DOC_FileLink_Entity");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.EntityName).HasMaxLength(80);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.File).WithMany(p => p.DocFileLinks)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOC_FileLink_File");
        });

        modelBuilder.Entity<EmailQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("EMailQueue");

            entity.Property(e => e.AppendQueryError).HasColumnName("append_query_error");
            entity.Property(e => e.AttachQueryResultAsFile).HasColumnName("attach_query_result_as_file");
            entity.Property(e => e.BlindCopyRecipients)
                .IsUnicode(false)
                .HasColumnName("blind_copy_recipients");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.BodyFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("body_format");
            entity.Property(e => e.CopyRecipients)
                .IsUnicode(false)
                .HasColumnName("copy_recipients");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.ExcludeQueryOutput).HasColumnName("exclude_query_output");
            entity.Property(e => e.ExecuteQueryDatabase)
                .HasMaxLength(128)
                .HasColumnName("execute_query_database");
            entity.Property(e => e.FileAttachments).HasColumnName("file_attachments");
            entity.Property(e => e.FromAddress)
                .IsUnicode(false)
                .HasColumnName("from_address");
            entity.Property(e => e.Group).HasMaxLength(510);
            entity.Property(e => e.Importance)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("importance");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsReported)
                .HasDefaultValue(false)
                .HasColumnName("isReported");
            entity.Property(e => e.MailitemId).HasColumnName("mailitem_id");
            entity.Property(e => e.Partnerid)
                .HasDefaultValue(0)
                .HasColumnName("partnerid");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("profile_name");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.QueryAttachmentFilename)
                .HasMaxLength(510)
                .HasColumnName("query_attachment_filename");
            entity.Property(e => e.QueryNoTruncate).HasColumnName("query_no_truncate");
            entity.Property(e => e.QueryResultHeader).HasColumnName("query_result_header");
            entity.Property(e => e.QueryResultNoPadding).HasColumnName("query_result_no_padding");
            entity.Property(e => e.QueryResultSeparator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("query_result_separator");
            entity.Property(e => e.QueryResultWidth).HasColumnName("query_result_width");
            entity.Property(e => e.Recipients)
                .IsUnicode(false)
                .HasColumnName("recipients");
            entity.Property(e => e.Refcode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("refcode");
            entity.Property(e => e.ReplyTo)
                .IsUnicode(false)
                .HasColumnName("reply_to");
            entity.Property(e => e.RetryAttempts)
                .HasDefaultValue(0)
                .HasColumnName("retry_attempts");
            entity.Property(e => e.SendAttempts)
                .HasDefaultValue(0)
                .HasColumnName("send_attempts");
            entity.Property(e => e.Sensitivity)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("sensitivity");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.SentStatus)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sent_status");
            entity.Property(e => e.Starred).HasDefaultValue(false);
            entity.Property(e => e.Status).HasMaxLength(510);
            entity.Property(e => e.Subject)
                .HasMaxLength(510)
                .HasColumnName("subject");
            entity.Property(e => e.UnRead).HasDefaultValue(true);
            entity.Property(e => e.User).HasMaxLength(510);
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ErrorLog__3214EC07AD6985E6");

            entity.Property(e => e.ClientIp).HasMaxLength(45);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExceptionType).HasMaxLength(200);
            entity.Property(e => e.Host).HasMaxLength(200);
            entity.Property(e => e.Path).HasMaxLength(2000);
            entity.Property(e => e.QueryString).HasMaxLength(2000);
            entity.Property(e => e.Referer).HasMaxLength(1000);
            entity.Property(e => e.RequestMethod).HasMaxLength(10);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserId).HasMaxLength(80);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ExcelTemplate>(entity =>
        {
            entity.ToTable("ExcelTemplate");

            entity.Property(e => e.IdentifierKeywords).HasMaxLength(500);
            entity.Property(e => e.SampleExcelPath).HasMaxLength(500);
            entity.Property(e => e.TemplateName).HasMaxLength(200);
        });

        modelBuilder.Entity<FinAccountMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_GlMa__3214EC078C5C5CAD");

            entity.ToTable("FIN_AccountMapping");

            entity.Property(e => e.ApaccountCode)
                .HasMaxLength(50)
                .HasColumnName("APAccountCode");
            entity.Property(e => e.AraccountCode)
                .HasMaxLength(50)
                .HasColumnName("ARAccountCode");
            entity.Property(e => e.BankAccountCode).HasMaxLength(50);
            entity.Property(e => e.CashAccountCode).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(50);
            entity.Property(e => e.ExpenseAccountCode).HasMaxLength(50);
            entity.Property(e => e.GrniaccountCode)
                .HasMaxLength(50)
                .HasColumnName("GRNIAccountCode");
            entity.Property(e => e.InventoryAccountCode).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.RevenueAccountCode).HasMaxLength(50);
            entity.Property(e => e.VatPurchaseAccountCode).HasMaxLength(50);
            entity.Property(e => e.VatSalesAccountCode).HasMaxLength(50);
        });

        modelBuilder.Entity<FinAccountPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Fin_AccountPlan");

            entity.ToTable("FIN_AccountPlan");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountType).HasMaxLength(50);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Balance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BalanceEur)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BalanceEUR");
            entity.Property(e => e.BalanceTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BalanceTL");
            entity.Property(e => e.BalanceUsd)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BalanceUSD");
            entity.Property(e => e.Budget)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hide).HasDefaultValue(false);
            entity.Property(e => e.InitialBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InitialBalanceDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.InitialBalanceTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("InitialBalanceTL");
            entity.Property(e => e.InitialBalanceType).HasMaxLength(10);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsGroup).HasDefaultValue(false);
            entity.Property(e => e.IsSelectable).HasDefaultValue(true);
            entity.Property(e => e.Kdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Level).HasDefaultValue(1);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentCode).HasMaxLength(20);
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.TransactionCount).HasDefaultValue(0);
        });

        modelBuilder.Entity<FinAccountTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Acco__3214EC077172BC3E");

            entity.ToTable("FIN_AccountTransaction");

            entity.HasIndex(e => e.CompanyId, "IX_FIN_AccountTransaction_CompanyId");

            entity.HasIndex(e => e.IsDeleted, "IX_FIN_AccountTransaction_IsDeleted");

            entity.HasIndex(e => e.PartnerId, "IX_FIN_AccountTransaction_PartnerId");

            entity.HasIndex(e => e.TransDate, "IX_FIN_AccountTransaction_TransDate");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AccountPlanId).HasDefaultValue(0);
            entity.Property(e => e.AmountTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CreditTL");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DebitTL");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.VoucherLineId).HasDefaultValue(0);
        });

        modelBuilder.Entity<FinBankAccount>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__GNL_Bank__3214EC07AF8F6A54")
                .HasFillFactor(85);

            entity.ToTable("FIN_BankAccounts");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.Balance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankCode).HasMaxLength(20);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(250);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.IbanNo).HasMaxLength(50);
            entity.Property(e => e.IconName).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LastBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Logo).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.SwiftCode).HasMaxLength(50);
        });

        modelBuilder.Entity<FinBankTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Bank__3214EC07993C84A4");

            entity.ToTable("FIN_BankTrans");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.BankAccountCode).HasMaxLength(50);
            entity.Property(e => e.BankAccountName).HasMaxLength(250);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
        });

        modelBuilder.Entity<FinCashTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Cash__3214EC07A2680B8F");

            entity.ToTable("FIN_CashTrans");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.CashAccountCode).HasMaxLength(50);
            entity.Property(e => e.CashAccountName).HasMaxLength(250);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
        });

        modelBuilder.Entity<FinCheque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FIN_Cheq__3214EC078789BA90");

            entity.ToTable("FIN_Cheque");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ChequeType).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(10m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CurrentStatus).HasMaxLength(30);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.GlAccountCode).HasMaxLength(50);
            entity.Property(e => e.IbanNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.IssuerName).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiverName).HasMaxLength(150);
        });

        modelBuilder.Entity<FinChequeTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FIN_Cheq__3214EC07C8488456");

            entity.ToTable("FIN_ChequeTransaction");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.FromStatus).HasMaxLength(30);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ToStatus).HasMaxLength(30);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FinCreditCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FIN_Cred__3214EC0764B55673");

            entity.ToTable("FIN_CreditCard");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.AvailableLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.CardNo).HasMaxLength(20);
            entity.Property(e => e.CardType).HasMaxLength(20);
            entity.Property(e => e.CardholderName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TL");
            entity.Property(e => e.GlAccountCode).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FinCreditCardTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FIN_Cred__3214EC07B755531E");

            entity.ToTable("FIN_CreditCardTransaction");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(10m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType).HasMaxLength(20);
        });

        modelBuilder.Entity<FinCurrency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FIN_Currency", tb => tb.HasTrigger("trLog_FNC_Currency"));

            entity.Property(e => e.BanknoteBuying).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteBuyingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteSelling).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteSellingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BultenNo).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CodeTr).HasMaxLength(255);
            entity.Property(e => e.CreatedOn)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CrossRateOther).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CrossRateUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CrossRateUSD");
            entity.Property(e => e.ForexBuying).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexBuyingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexSelling).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexSellingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameTr).HasMaxLength(255);
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.XmlDate).HasMaxLength(255);
            entity.Property(e => e.XmlDateTr).HasMaxLength(255);
        });

        modelBuilder.Entity<FinCurrencyHistory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_FNC_CurrencyHistory")
                .HasFillFactor(85);

            entity.ToTable("FIN_CurrencyHistory");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BanknoteBuying).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteBuyingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteSelling).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BanknoteSellingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BultenNo).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CodeTr).HasMaxLength(255);
            entity.Property(e => e.CreatedOn)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CrossRateOther).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CrossRateUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CrossRateUSD");
            entity.Property(e => e.ForexBuying).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexBuyingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexSelling).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ForexSellingManual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameTr).HasMaxLength(255);
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.XmlDate).HasMaxLength(255);
            entity.Property(e => e.XmlDateTr).HasMaxLength(255);
        });

        modelBuilder.Entity<FinCustomCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FNC_Cust__3214EC07BC1122A4");

            entity.ToTable("FIN_CustomCurrency");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<FinEinvoiceSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FIN_EInv__3214EC075B9B5C4F");

            entity.ToTable("FIN_EInvoiceSettings");

            entity.Property(e => e.ApiKey).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EarchiveXsltFileName)
                .HasMaxLength(250)
                .HasColumnName("EArchiveXsltFileName");
            entity.Property(e => e.EdmEnvironment).HasMaxLength(20);
            entity.Property(e => e.EdmPassword).HasMaxLength(100);
            entity.Property(e => e.EdmSessionId).HasMaxLength(200);
            entity.Property(e => e.EdmUsername).HasMaxLength(100);
            entity.Property(e => e.Environment)
                .HasMaxLength(20)
                .HasDefaultValue("Test");
            entity.Property(e => e.Integrator).HasMaxLength(50);
            entity.Property(e => e.InvoiceXsltFileName).HasMaxLength(250);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SecretKey).HasMaxLength(100);
            entity.Property(e => e.TokenExpiry).HasColumnType("datetime");
        });

        modelBuilder.Entity<FinGlMapping>(entity =>
        {
            entity.ToTable("FIN_GlMapping");

            entity.Property(e => e.ApaccountCode).HasColumnName("APAccountCode");
            entity.Property(e => e.AraccountCode).HasColumnName("ARAccountCode");
            entity.Property(e => e.GrniaccountCode).HasColumnName("GRNIAccountCode");
            entity.Property(e => e.WithholdingPurchaseAccountCode).HasMaxLength(50);
            entity.Property(e => e.WithholdingSalesAccountCode).HasMaxLength(50);
        });

        modelBuilder.Entity<FinInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Fin_Invoice");

            entity.ToTable("FIN_Invoice");

            entity.HasIndex(e => new { e.CompanyId, e.PartnerId, e.VesselId, e.InvoiceDate }, "IX_Fin_Invoice_Aging");

            entity.HasIndex(e => e.ProjectId, "IX_Fin_Invoice_ProjectId");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.DscTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GnlTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceProfile).HasMaxLength(20);
            entity.Property(e => e.InvoiceScenario).HasMaxLength(20);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsPaid).HasComputedColumnSql("(case when ([GnlTotal]-[PaidAmount])<=(0) then (1) else (0) end)", false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.RemainingAmount)
                .HasComputedColumnSql("([GnlTotal]-[PaidAmount])", false)
                .HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RfqNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VatTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VesselId).HasDefaultValue(0);
            entity.Property(e => e.VoucherId).HasDefaultValue(0);
            entity.Property(e => e.VoucherType).HasDefaultValue(0);

            entity.HasOne(d => d.Project).WithMany(p => p.FinInvoices)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_Fin_Invoice_Project");
        });

        modelBuilder.Entity<FinInvoiceLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Invo__3214EC07C760D5A0");

            entity.ToTable("FIN_InvoiceLine");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DscRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.InvoiceId).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxExemptionCode).HasMaxLength(10);
            entity.Property(e => e.VatRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.WithholdingTaxCode).HasMaxLength(10);
            entity.Property(e => e.WithholdingTaxRate).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<FinInvoicePayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Invo__3214EC07C2B00AA2");

            entity.ToTable("FIN_InvoicePayment");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(255);
        });

        modelBuilder.Entity<FinInvoiceSettlement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Invo__3214EC07BA2C74C1");

            entity.ToTable("FIN_InvoiceSettlement");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<FinPaymentHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Paym__3214EC07F5FB9076");

            entity.ToTable("FIN_PaymentHeader");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AccountId).HasDefaultValue(0);
            entity.Property(e => e.AccountName).HasMaxLength(400);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.BankAccountCode).HasMaxLength(50);
            entity.Property(e => e.BankAccountName).HasMaxLength(250);
            entity.Property(e => e.CariAccountId).HasDefaultValue(0);
            entity.Property(e => e.CashAccountCode).HasMaxLength(50);
            entity.Property(e => e.CashAccountName).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PaymentDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PaymentType).HasDefaultValue(0);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.VoucherId).HasDefaultValue(0);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<FinVoucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Vouc__3214EC078C011348");

            entity.ToTable("FIN_Voucher");

            entity.HasIndex(e => e.VoucherDate, "IX_FinVH_Date");

            entity.HasIndex(e => new { e.InvoiceId, e.VoucherDate }, "IX_Fin_Receipt_Aging");

            entity.HasIndex(e => e.ProjectId, "IX_Fin_Voucher_ProjectId");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceId).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsLocked).HasDefaultValue(false);
            entity.Property(e => e.IsPosted).HasDefaultValue(false);
            entity.Property(e => e.IsReversal).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RefId).HasDefaultValue(0);
            entity.Property(e => e.RefModule).HasDefaultValue(0);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalCredit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDebit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
            entity.Property(e => e.VoucherType).HasDefaultValue(0);

            entity.HasOne(d => d.Project).WithMany(p => p.FinVouchers)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_Fin_Voucher_Project");
        });

        modelBuilder.Entity<FinVoucherLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fin_Vouc__3214EC07CB533F5E");

            entity.ToTable("FIN_VoucherLine");

            entity.HasIndex(e => e.AccountCode, "IX_FinVL_AccountCode");

            entity.HasIndex(e => e.VoucherId, "IX_FinVL_HeaderId");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountPlanId).HasDefaultValue(0);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BalanceTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BalanceTL");
            entity.Property(e => e.CounterAccount).HasMaxLength(250);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("system");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CreditTL");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitTl)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DebitTL");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.Explanation).HasMaxLength(300);
            entity.Property(e => e.IsCounterAccount).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("system");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Remarks).HasMaxLength(300);

            entity.HasOne(d => d.Voucher).WithMany(p => p.FinVoucherLines)
                .HasForeignKey(d => d.VoucherId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinVL_Header");
        });

        modelBuilder.Entity<FncAccountTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FNC_AccountTransactions");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CreditTL");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DebitTL");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
        });

        modelBuilder.Entity<GibTaxCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GibTaxCo__3214EC07FAA2A29F");

            entity.HasIndex(e => e.CompanyId, "IX_GibTaxCodes_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeType).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.GibTaxCodes)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__GibTaxCod__Compa__33DA44F9");
        });

        modelBuilder.Entity<GnlAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Address");

            entity.HasIndex(e => e.PartnerId, "IX_GNL_Address_PartnerId").HasFillFactor(85);

            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Latitude).HasMaxLength(100);
            entity.Property(e => e.Longitude).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Pk)
                .HasMaxLength(100)
                .HasColumnName("PK");
            entity.Property(e => e.RefCode).HasMaxLength(20);
            entity.Property(e => e.ShortName).HasMaxLength(100);
        });

        modelBuilder.Entity<GnlAttachment>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Attachments")
                .HasFillFactor(85);

            entity.ToTable("GNL_Attachments");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.RefCode).HasMaxLength(100);
            entity.Property(e => e.RefId).HasDefaultValue(0L);
            entity.Property(e => e.RefName).HasMaxLength(50);
            entity.Property(e => e.RefParentId).HasDefaultValue(0L);
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        modelBuilder.Entity<GnlBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Bank__3214EC07CB3B54A6");

            entity.ToTable("GNL_Banks");

            entity.Property(e => e.BankCode).HasMaxLength(20);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GnlBranch>(entity =>
        {
            entity.ToTable("GNL_Branchs");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BranchName).HasMaxLength(250);
            entity.Property(e => e.BranchType).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<GnlBrand>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_CRM_Brands")
                .HasFillFactor(85);

            entity.ToTable("GNL_Brands");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BrandCode).HasMaxLength(50);
            entity.Property(e => e.BrandName).HasMaxLength(250);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Logo).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.ServiceArea).HasMaxLength(250);
            entity.Property(e => e.VesselId).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlCargoCompany>(entity =>
        {
            entity.ToTable("GNL_CargoCompanies");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_CargoCompanies_CompanyId");

            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.TaxNumber).HasMaxLength(50);
            entity.Property(e => e.TrackingUrlTemplate).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlCargoCompanies).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<GnlCatalogue>(entity =>
        {
            entity.ToTable("Gnl_Catalogues");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CatalogueName).HasMaxLength(150);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<GnlCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gnl_Cate__3214EC07A443DF6D");

            entity.ToTable("Gnl_Categories");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.CategoryName).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
        });

        modelBuilder.Entity<GnlCategory1>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Category");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlCertificate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GNL_Certificates");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CertificateName).HasMaxLength(250);
            entity.Property(e => e.CertificateNo).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DocumentNo).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IssuedBy).HasMaxLength(250);
            entity.Property(e => e.IssuedDate).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.ServiceId).HasDefaultValue(0);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TempFileName).HasMaxLength(150);
            entity.Property(e => e.ValidDate).HasPrecision(3);
            entity.Property(e => e.VesselId).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GNL_Cities");

            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.CityCode).HasMaxLength(10);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.DeclaredCode).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Lat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Lng).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlCompany>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_CRM_Company")
                .HasFillFactor(85);

            entity.ToTable("GNL_Company");

            entity.Property(e => e.AccountManager).HasMaxLength(250);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.BankAccountDescription).HasMaxLength(3000);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyCode).HasMaxLength(20);
            entity.Property(e => e.CompanyColor).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.CompanyType).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.InvoiceAddress).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Logo).HasMaxLength(150);
            entity.Property(e => e.Manager).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.OfficeAddress).HasMaxLength(250);
            entity.Property(e => e.OfficeFax).HasMaxLength(50);
            entity.Property(e => e.OfficePhone).HasMaxLength(50);
            entity.Property(e => e.OperationManager).HasMaxLength(250);
            entity.Property(e => e.OwnerName).HasMaxLength(250);
            entity.Property(e => e.PurchaseOrderNote).HasMaxLength(1000);
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.TaxNumber).HasMaxLength(50);
            entity.Property(e => e.TaxOffice).HasMaxLength(100);
            entity.Property(e => e.WebAddress).HasMaxLength(100);
        });

        modelBuilder.Entity<GnlCompanyVehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Comp__3214EC071B8DA9EF");

            entity.ToTable("GNL_CompanyVehicles");

            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerName).HasMaxLength(100);
            entity.Property(e => e.PlateNo).HasMaxLength(20);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("ACTIVE");
        });

        modelBuilder.Entity<GnlContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Contact");

            entity.HasIndex(e => e.RefCode, "IX_GNL_Contact_CompanyId").HasFillFactor(85);

            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactActive).HasDefaultValueSql("(CONVERT([bit],(0),(0)))");
            entity.Property(e => e.ContactCode).HasMaxLength(20);
            entity.Property(e => e.ContactName).HasMaxLength(100);
            entity.Property(e => e.ContactRank).HasMaxLength(50);
            entity.Property(e => e.ContactTitle).HasMaxLength(50);
            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Facebook).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.JoiningDate).HasPrecision(3);
            entity.Property(e => e.MobilPhone).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PhotoFile).HasMaxLength(150);
            entity.Property(e => e.PostCode).HasMaxLength(10);
            entity.Property(e => e.RefCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Salery)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(50);
            entity.Property(e => e.WhatsUp).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlContactDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_ContactDetails");

            entity.HasIndex(e => e.ContactId, "IX_GNL_ContactDetails_ContactId").HasFillFactor(85);

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlCounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gnl_Counters");

            entity.ToTable("GNL_Counters");

            entity.Property(e => e.BranchId).HasDefaultValue(0);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CountNo).HasDefaultValue(0);
            entity.Property(e => e.CounterName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.HeadPrefix).HasMaxLength(10);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RefLenght).HasDefaultValue(0);
            entity.Property(e => e.RefNo).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlCountry>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_GNL_Country")
                .HasFillFactor(85);

            entity.ToTable("GNL_Countries");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CountryName).HasMaxLength(100);
            entity.Property(e => e.CountryNameEn)
                .HasMaxLength(100)
                .HasColumnName("CountryNameEN");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CurrencySymbol).HasMaxLength(10);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.PhoneCode).HasMaxLength(10);
        });

        modelBuilder.Entity<GnlCurrency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gnl_Currency");

            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasDefaultValue(0);
            entity.Property(e => e.Symbol).HasMaxLength(10);
        });

        modelBuilder.Entity<GnlDefination>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_GNL_Tanimlar")
                .HasFillFactor(85);

            entity.ToTable("GNL_Definations");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("ADMIN");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DefGroup).HasMaxLength(50);
            entity.Property(e => e.DefKey).HasMaxLength(75);
            entity.Property(e => e.DefOrder).HasDefaultValue(0);
            entity.Property(e => e.DefText).HasMaxLength(50);
            entity.Property(e => e.DefValue).HasMaxLength(30);
            entity.Property(e => e.Icon).HasMaxLength(150);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("ADMIN");
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<GnlDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Documents");

            entity.Property(e => e.ActionDate).HasPrecision(3);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DocumentCode).HasMaxLength(50);
            entity.Property(e => e.DocumentName).HasMaxLength(250);
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.FileType).HasMaxLength(30);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.SubCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gnl_EMai__3214EC07346AEAB0");

            entity.ToTable("Gnl_EMails");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.MailFrom).HasMaxLength(150);
            entity.Property(e => e.MailSubject).HasMaxLength(150);
            entity.Property(e => e.MailTitle).HasMaxLength(50);
            entity.Property(e => e.MailTo).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RefPrm).HasMaxLength(50);
            entity.Property(e => e.Sfile)
                .HasMaxLength(50)
                .HasColumnName("SFile");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UnRead).HasDefaultValue(true);
            entity.Property(e => e.UserImage)
                .HasMaxLength(50)
                .HasDefaultValue("default.png");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserSign).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlEmailAccount>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_GNL_EMailAccounts")
                .HasFillFactor(85);

            entity.ToTable("GNL_EMailAccount");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Pop3Address).HasMaxLength(50);
            entity.Property(e => e.Pop3Port).HasDefaultValue(0);
            entity.Property(e => e.Profile).HasMaxLength(50);
            entity.Property(e => e.SmtpAddress).HasMaxLength(50);
            entity.Property(e => e.SmtpPort).HasDefaultValue(0);
            entity.Property(e => e.Ssl)
                .HasDefaultValue(false)
                .HasColumnName("SSL");
        });

        modelBuilder.Entity<GnlEquipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Equipments");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EquipmentName).HasMaxLength(250);
            entity.Property(e => e.Marka).HasMaxLength(250);
            entity.Property(e => e.Model).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.PartnerCode).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.SerialNo).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VesselCode).HasMaxLength(50);
            entity.Property(e => e.VesselId).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlImage>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Images")
                .HasFillFactor(85);

            entity.ToTable("GNL_Images");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.RefCode).HasMaxLength(20);
        });

        modelBuilder.Entity<GnlMailSablon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GNL_MailSablon_1");

            entity.ToTable("GNL_MailSablon");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Template).HasMaxLength(100);
        });

        modelBuilder.Entity<GnlMailSign>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_MailSign");

            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.UserMail).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserRank).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlMenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_MenuItem");
        });

        modelBuilder.Entity<GnlModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Models");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModelName).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlModule>(entity =>
        {
            entity.ToTable("Gnl_Modules");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(100);
        });

        modelBuilder.Entity<GnlNotification>(entity =>
        {
            entity.ToTable("Gnl_Notifications");

            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.LinkUrl).HasMaxLength(512);
            entity.Property(e => e.TargetId).HasMaxLength(450);
            entity.Property(e => e.TargetType).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValue("info");
        });

        modelBuilder.Entity<GnlNotificationRecipient>(entity =>
        {
            entity.ToTable("Gnl_NotificationRecipients");

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.Notification).WithMany(p => p.GnlNotificationRecipients).HasForeignKey(d => d.NotificationId);
        });

        modelBuilder.Entity<GnlParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gnl_Para__75256058D3E5914C");

            entity.ToTable("Gnl_Parameters");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);
            entity.Property(e => e.ValueType).HasMaxLength(255);
            entity.Property(e => e.VesselId).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlPartner>(entity =>
        {
            entity.ToTable("GNL_Partners");

            entity.HasIndex(e => e.SectorId, "IX_CRM_Partner_SectorId").HasFillFactor(85);

            entity.HasIndex(e => e.SubSectorId, "IX_CRM_Partner_SubSectorId").HasFillFactor(85);

            entity.Property(e => e.Abroad).HasDefaultValue(false);
            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountCodeBuyer).HasMaxLength(20);
            entity.Property(e => e.AccountCodeSupplier).HasMaxLength(20);
            entity.Property(e => e.AccountEmail).HasMaxLength(250);
            entity.Property(e => e.AccountManager).HasMaxLength(250);
            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountRole).HasMaxLength(20);
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.ApprovedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Balance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.CompanyCode).HasMaxLength(20);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.ContactEmail).HasMaxLength(150);
            entity.Property(e => e.ContactPerson).HasMaxLength(150);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.ContactTitle).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.DueDays).HasMaxLength(100);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasDefaultValue(0);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GroupPartner).HasDefaultValue(false);
            entity.Property(e => e.IdentityNo).HasMaxLength(255);
            entity.Property(e => e.InvoiceAddress).HasMaxLength(250);
            entity.Property(e => e.InvoiceType).HasMaxLength(20);
            entity.Property(e => e.IsAbroad).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.JoiningDate).HasPrecision(3);
            entity.Property(e => e.Kind).HasMaxLength(50);
            entity.Property(e => e.Mail).HasMaxLength(100);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.OfficeFax).HasMaxLength(50);
            entity.Property(e => e.OfficePhone).HasMaxLength(50);
            entity.Property(e => e.OwnerName).HasMaxLength(250);
            entity.Property(e => e.PartnerCode).HasMaxLength(50);
            entity.Property(e => e.PartnerInfo).HasMaxLength(100);
            entity.Property(e => e.PartnerName).HasMaxLength(250);
            entity.Property(e => e.PartnerType).HasDefaultValue(0);
            entity.Property(e => e.PaymentTerm).HasDefaultValue(0);
            entity.Property(e => e.PaymentTerms).HasDefaultValue(0);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Phone1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Photo).HasMaxLength(255);
            entity.Property(e => e.Rating).HasDefaultValue(0);
            entity.Property(e => e.RelevantPerson).HasMaxLength(250);
            entity.Property(e => e.RelevantPersonGender).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(150);
            entity.Property(e => e.SectorId).HasDefaultValue(0);
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(5);
            entity.Property(e => e.SubSectorId).HasDefaultValue(0);
            entity.Property(e => e.TaxNumber).HasMaxLength(50);
            entity.Property(e => e.TaxOffice).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.WebAddress).HasMaxLength(100);
        });

        modelBuilder.Entity<GnlPartnerContact>(entity =>
        {
            entity.ToTable("GNL_PartnerContacts");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_PartnerContacts_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_GNL_PartnerContacts_PartnerId");

            entity.Property(e => e.ContactName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPartnerContacts).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Partner).WithMany(p => p.GnlPartnerContacts).HasForeignKey(d => d.PartnerId);
        });

        modelBuilder.Entity<GnlPartnerGroup>(entity =>
        {
            entity.ToTable("GNL_PartnerGroups");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_PartnerGroups_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.GroupCode }, "IX_GNL_PartnerGroups_CompanyId_GroupCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.GroupCode, "IX_GNL_PartnerGroups_GroupCode");

            entity.HasIndex(e => e.IsActive, "IX_GNL_PartnerGroups_IsActive");

            entity.HasIndex(e => e.IsDeleted, "IX_GNL_PartnerGroups_IsDeleted");

            entity.HasIndex(e => e.ParentGroupId, "IX_GNL_PartnerGroups_ParentGroupId");

            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .HasDefaultValue("#007bff");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultCreditLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultCurrency).HasMaxLength(5);
            entity.Property(e => e.DefaultDiscountRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPartnerGroups)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerGroups_Company");

            entity.HasOne(d => d.ParentGroup).WithMany(p => p.InverseParentGroup)
                .HasForeignKey(d => d.ParentGroupId)
                .HasConstraintName("FK_GNL_PartnerGroups_ParentGroup");
        });

        modelBuilder.Entity<GnlPartnerGroupAssignment>(entity =>
        {
            entity.ToTable("GNL_PartnerGroupAssignments");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_PartnerGroupAssignments_CompanyId");

            entity.HasIndex(e => e.GroupId, "IX_GNL_PartnerGroupAssignments_GroupId");

            entity.HasIndex(e => e.IsDeleted, "IX_GNL_PartnerGroupAssignments_IsDeleted");

            entity.HasIndex(e => e.IsPrimary, "IX_GNL_PartnerGroupAssignments_IsPrimary");

            entity.HasIndex(e => e.PartnerId, "IX_GNL_PartnerGroupAssignments_PartnerId");

            entity.HasIndex(e => new { e.PartnerId, e.GroupId }, "IX_GNL_PartnerGroupAssignments_PartnerId_GroupId")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.Property(e => e.AssignedBy).HasMaxLength(50);
            entity.Property(e => e.AssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPartnerGroupAssignments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerGroupAssignments_Company");

            entity.HasOne(d => d.Group).WithMany(p => p.GnlPartnerGroupAssignments)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerGroupAssignments_Group");
        });

        modelBuilder.Entity<GnlPartnerSegment>(entity =>
        {
            entity.ToTable("GNL_PartnerSegments");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_PartnerSegments_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.SegmentCode }, "IX_GNL_PartnerSegments_CompanyId_SegmentCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.IsActive, "IX_GNL_PartnerSegments_IsActive");

            entity.HasIndex(e => e.IsDeleted, "IX_GNL_PartnerSegments_IsDeleted");

            entity.HasIndex(e => e.SegmentCode, "IX_GNL_PartnerSegments_SegmentCode");

            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .HasDefaultValue("#007bff");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SegmentCode).HasMaxLength(50);
            entity.Property(e => e.SegmentName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPartnerSegments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerSegments_Company");
        });

        modelBuilder.Entity<GnlPartnerSegmentAssignment>(entity =>
        {
            entity.ToTable("GNL_PartnerSegmentAssignments");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_PartnerSegmentAssignments_CompanyId");

            entity.HasIndex(e => e.IsDeleted, "IX_GNL_PartnerSegmentAssignments_IsDeleted");

            entity.HasIndex(e => e.PartnerId, "IX_GNL_PartnerSegmentAssignments_PartnerId");

            entity.HasIndex(e => new { e.PartnerId, e.SegmentId }, "IX_GNL_PartnerSegmentAssignments_PartnerId_SegmentId")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.SegmentId, "IX_GNL_PartnerSegmentAssignments_SegmentId");

            entity.Property(e => e.AssignedBy)
                .HasMaxLength(50)
                .HasDefaultValue("Manuel");
            entity.Property(e => e.AssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPartnerSegmentAssignments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerSegmentAssignments_Company");

            entity.HasOne(d => d.Segment).WithMany(p => p.GnlPartnerSegmentAssignments)
                .HasForeignKey(d => d.SegmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GNL_PartnerSegmentAssignments_Segment");
        });

        modelBuilder.Entity<GnlPartnerServiceArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PartnerS__3214EC07B779B1EC");

            entity.ToTable("GNL_PartnerServiceArea");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlPort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gnl_PortList");

            entity.ToTable("GNL_Ports");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Authority).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.Latitude).HasMaxLength(255);
            entity.Property(e => e.Longitude).HasMaxLength(255);
            entity.Property(e => e.MainPort).HasMaxLength(255);
            entity.Property(e => e.MaxDraft).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.PortName).HasMaxLength(255);
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);
            entity.Property(e => e.Unctad).HasMaxLength(255);
            entity.Property(e => e.WebSide).HasMaxLength(255);
        });

        modelBuilder.Entity<GnlPrinter>(entity =>
        {
            entity.ToTable("GNL_Printers");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_Printers_CompanyId");

            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.PrinterName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlPrinters).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<GnlProcedure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Proc__3214EC07436C71B0");

            entity.ToTable("GNL_Procedures");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProcedureName).HasMaxLength(255);
        });

        modelBuilder.Entity<GnlProcedureLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Proc__3214EC07700BAD89");

            entity.ToTable("GNL_ProcedureLogs");

            entity.Property(e => e.ExecutedBy).HasMaxLength(100);
            entity.Property(e => e.ExecutedDate).HasColumnType("datetime");
            entity.Property(e => e.ResultMessage).HasMaxLength(500);
        });

        modelBuilder.Entity<GnlProduct>(entity =>
        {
            entity.ToTable("GNL_Products");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.B2bactive)
                .HasDefaultValue(false)
                .HasColumnName("B2BActive");
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(2000);
            entity.Property(e => e.CatalogueId).HasDefaultValue(0);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.CategoryId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DrawingNo).HasMaxLength(2000);
            entity.Property(e => e.Favorite).HasDefaultValue(false);
            entity.Property(e => e.Foto).HasMaxLength(250);
            entity.Property(e => e.Gtip)
                .HasDefaultValue(0)
                .HasColumnName("GTIP");
            entity.Property(e => e.Impacode)
                .HasMaxLength(20)
                .HasColumnName("IMPACode");
            entity.Property(e => e.Issacode)
                .HasMaxLength(20)
                .HasColumnName("ISSACode");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.MaxQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxQtyControl).HasDefaultValue(false);
            entity.Property(e => e.MinQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinQtyControl).HasDefaultValue(false);
            entity.Property(e => e.Model).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(100);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .HasDefaultValue("Code");
            entity.Property(e => e.ProductName).HasMaxLength(2000);
            entity.Property(e => e.ProductNameTr).HasMaxLength(2000);
            entity.Property(e => e.Rating)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaleActive).HasDefaultValue(false);
            entity.Property(e => e.ShowOnWeb).HasDefaultValue(false);
            entity.Property(e => e.SpecialCode).HasMaxLength(100);
            entity.Property(e => e.SubCategory).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.Volume)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Xml)
                .HasDefaultValue(false)
                .HasColumnName("XML");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.GnlProducts).HasForeignKey(d => d.ProductCategoryId);

            entity.HasOne(d => d.ProductGroup).WithMany(p => p.GnlProducts).HasForeignKey(d => d.ProductGroupId);
        });

        modelBuilder.Entity<GnlProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_B2B_ProductCategories")
                .HasFillFactor(85);

            entity.ToTable("GNL_ProductCategories");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(20);
            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlProductFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gnl_ProductFiles");

            entity.ToTable("GNL_ProductFiles");

            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.FileTitle).HasMaxLength(350);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
        });

        modelBuilder.Entity<GnlProductGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Prod__3214EC07B12DC7B8");

            entity.ToTable("GNL_ProductGroups");

            entity.Property(e => e.CatalogueId).HasDefaultValue(1);
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<GnlProductPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gnl_ProductPrices");

            entity.ToTable("GNL_ProductPrices");

            entity.HasIndex(e => e.CompanyId, "IX_Gnl_ProductPrices_CompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_Gnl_ProductPrices_CreatedDate");

            entity.HasIndex(e => e.Currency, "IX_Gnl_ProductPrices_Currency");

            entity.HasIndex(e => e.IsDeleted, "IX_Gnl_ProductPrices_IsDeleted");

            entity.HasIndex(e => e.StockId, "IX_Gnl_ProductPrices_ProductId");

            entity.HasIndex(e => new { e.StockId, e.Currency }, "IX_Gnl_ProductPrices_ProductId_Currency").HasFilter("([IsDeleted]=(0))");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TRY");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlProductPrices)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gnl_ProductPrices_Company");
        });

        modelBuilder.Entity<GnlProductSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Prod__3214EC07C288FAFC");

            entity.ToTable("GNL_ProductSuppliers");

            entity.HasIndex(e => new { e.ProductId, e.PartnerId }, "UK_ProductSuppliers").IsUnique();

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GnlProductSupplierPrice>(entity =>
        {
            entity.ToTable("GNL_ProductSupplierPrices");

            entity.HasIndex(e => new { e.StockId, e.PartnerId }, "IX_GNL_ProductSupplierPrices_ProductPartner");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PriceDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GnlResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Resources");

            entity.HasIndex(e => new { e.Lang, e.Name }, "UC_Name")
                .IsUnique()
                .HasFillFactor(85);

            entity.Property(e => e.CreatedOn)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Lang).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<GnlSayac>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Sayac");
        });

        modelBuilder.Entity<GnlServiceArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gnl_Serv__3214EC07638D26DF");

            entity.ToTable("Gnl_ServiceArea");

            entity.HasIndex(e => e.Code, "UX_Gnl_ServiceArea_Code")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.Property(e => e.Code).HasMaxLength(150);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ParentId).HasDefaultValue(0);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
        });

        modelBuilder.Entity<GnlStockDiscountList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GNL_Stoc__3214EC071DDEC08F");

            entity.ToTable("GNL_Stock_DiscountList");
        });

        modelBuilder.Entity<GnlStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Store");

            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMail");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Latitude).HasMaxLength(100);
            entity.Property(e => e.Longitude).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.StoreCode).HasMaxLength(20);
            entity.Property(e => e.StoreName).HasMaxLength(100);
            entity.Property(e => e.Town).HasMaxLength(50);
            entity.Property(e => e.Xmlshow)
                .HasDefaultValue(false)
                .HasColumnName("XMLShow");
        });

        modelBuilder.Entity<GnlSubCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_SubCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.SubCategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlSubItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_SubItem");

            entity.Property(e => e.CategoryId).HasDefaultValue(0);
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.SubCategoryName).HasMaxLength(150);
            entity.Property(e => e.SubItemName).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlTown>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gnl_Towns");

            entity.ToTable("GNL_Towns");

            entity.Property(e => e.CityCode).HasMaxLength(50);
            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TownCode).HasMaxLength(50);
            entity.Property(e => e.TownName).HasMaxLength(50);
        });

        modelBuilder.Entity<GnlUtility>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Utility");

            entity.Property(e => e.Class).HasMaxLength(255);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.CreatedOn)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<GnlVessel>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("GNL_Vessel");

            entity.HasIndex(e => e.RefCode, "IX_GNL_Vessel_CustomerId").HasFillFactor(85);

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BuildDate).HasMaxLength(20);
            entity.Property(e => e.BuildYard).HasMaxLength(50);
            entity.Property(e => e.CallSign).HasMaxLength(50);
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.DeadWeight).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DockYard).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMail");
            entity.Property(e => e.Flag).HasMaxLength(50);
            entity.Property(e => e.GrossTonnage)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.HullNumber).HasMaxLength(50);
            entity.Property(e => e.ImoNo).HasMaxLength(100);
            entity.Property(e => e.InternationalNumber).HasMaxLength(50);
            entity.Property(e => e.MiddleMan).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.OfficialNumber).HasMaxLength(50);
            entity.Property(e => e.OwnerName).HasMaxLength(250);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PoolId).HasDefaultValue(0);
            entity.Property(e => e.PortOfRegister).HasMaxLength(50);
            entity.Property(e => e.RefCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.VesselCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.VesselName).HasMaxLength(150);
            entity.Property(e => e.VesselPhoto).HasMaxLength(150);
            entity.Property(e => e.VesselSize).HasMaxLength(50);
            entity.Property(e => e.VesselType).HasMaxLength(70);
        });

        modelBuilder.Entity<GnlVesselCategory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_VesselCategory")
                .HasFillFactor(85);

            entity.ToTable("GNL_VesselCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(255);
        });

        modelBuilder.Entity<GnlWorkflowDelegation>(entity =>
        {
            entity.ToTable("GNL_WorkflowDelegation");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_WorkflowDelegation_CompanyId");

            entity.Property(e => e.DelegateeUserId).HasMaxLength(450);
            entity.Property(e => e.DelegatorUserId).HasMaxLength(450);
            entity.Property(e => e.Reason).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlWorkflowDelegations).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<GnlWorkflowHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ProjectHistory");

            entity.ToTable("GNL_WorkflowHistory");

            entity.Property(e => e.ActionBy).HasMaxLength(100);
            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.NewStatus).HasMaxLength(200);
            entity.Property(e => e.OldStatus).HasMaxLength(200);
        });

        modelBuilder.Entity<GnlWorkflowStep>(entity =>
        {
            entity.ToTable("GNL_WorkflowStep");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_WorkflowStep_CompanyId");

            entity.HasIndex(e => e.TemplateId, "IX_GNL_WorkflowStep_TemplateId");

            entity.Property(e => e.ApproverType).HasMaxLength(50);
            entity.Property(e => e.ConditionQuery).HasMaxLength(500);
            entity.Property(e => e.EscalationRoleName).HasMaxLength(100);
            entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RejectAction).HasMaxLength(20);
            entity.Property(e => e.RequiredRoleName).HasMaxLength(100);
            entity.Property(e => e.SpecificUserId).HasMaxLength(450);
            entity.Property(e => e.StepName).HasMaxLength(100);
            entity.Property(e => e.TimeoutAction).HasMaxLength(20);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlWorkflowSteps).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Template).WithMany(p => p.GnlWorkflowSteps).HasForeignKey(d => d.TemplateId);
        });

        modelBuilder.Entity<GnlWorkflowTemplate>(entity =>
        {
            entity.ToTable("GNL_WorkflowTemplate");

            entity.HasIndex(e => e.CompanyId, "IX_GNL_WorkflowTemplate_CompanyId");

            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.GnlWorkflowTemplates).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<HrApplication>(entity =>
        {
            entity.ToTable("HR_Application");

            entity.HasIndex(e => e.CandidateId, "IX_HR_Application_CandidateId");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Application_CompanyId");

            entity.HasIndex(e => e.JobPostingId, "IX_HR_Application_JobPostingId");

            entity.HasIndex(e => e.Status, "IX_HR_Application_Status");

            entity.Property(e => e.ApplicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CoverLetter).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EvaluationNotes).HasMaxLength(2000);
            entity.Property(e => e.ExpectedSalary).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RejectionReason).HasMaxLength(500);
            entity.Property(e => e.ReviewedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Candidate).WithMany(p => p.HrApplications)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Application_Candidate");

            entity.HasOne(d => d.Company).WithMany(p => p.HrApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Application_Company");

            entity.HasOne(d => d.JobPosting).WithMany(p => p.HrApplications)
                .HasForeignKey(d => d.JobPostingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Application_JobPosting");
        });

        modelBuilder.Entity<HrAttendance>(entity =>
        {
            entity.ToTable("HR_Attendance");

            entity.HasIndex(e => e.AttendanceDate, "IX_HR_Attendance_AttendanceDate");

            entity.HasIndex(e => new { e.EmployeeId, e.AttendanceDate }, "IX_HR_Attendance_EmployeeDate")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.Property(e => e.CheckInLocation).HasMaxLength(100);
            entity.Property(e => e.CheckInTime).HasColumnType("datetime");
            entity.Property(e => e.CheckOutLocation).HasMaxLength(100);
            entity.Property(e => e.CheckOutTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OvertimeHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.WorkedHours).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrAttendances)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Attendance_Company");
        });

        modelBuilder.Entity<HrBonusIncentive>(entity =>
        {
            entity.ToTable("HR_BonusIncentive");

            entity.HasIndex(e => e.BonusDate, "IX_HR_BonusIncentive_BonusDate");

            entity.HasIndex(e => e.BonusType, "IX_HR_BonusIncentive_BonusType");

            entity.HasIndex(e => e.CompanyId, "IX_HR_BonusIncentive_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.BonusNo }, "IX_HR_BonusIncentive_CompanyId_BonusNo")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_BonusIncentive_EmployeeId");

            entity.HasIndex(e => e.IsDeleted, "IX_HR_BonusIncentive_IsDeleted");

            entity.HasIndex(e => e.PayrollId, "IX_HR_BonusIncentive_PayrollId");

            entity.HasIndex(e => e.Status, "IX_HR_BonusIncentive_Status");

            entity.HasIndex(e => e.Year, "IX_HR_BonusIncentive_Year");

            entity.HasIndex(e => new { e.Year, e.Month }, "IX_HR_BonusIncentive_Year_Month");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AmountTL");
            entity.Property(e => e.BonusDate).HasColumnType("datetime");
            entity.Property(e => e.BonusNo).HasMaxLength(50);
            entity.Property(e => e.BonusType).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TRY");
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(10m)
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentReference).HasMaxLength(100);
            entity.Property(e => e.PeriodName).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrBonusIncentives)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_BonusIncentive_Company");

            entity.HasOne(d => d.Payroll).WithMany(p => p.HrBonusIncentives)
                .HasForeignKey(d => d.PayrollId)
                .HasConstraintName("FK_HR_BonusIncentive_Payroll");
        });

        modelBuilder.Entity<HrCandidate>(entity =>
        {
            entity.ToTable("HR_Candidate");

            entity.HasIndex(e => new { e.CompanyId, e.CandidateCode }, "IX_HR_Candidate_CandidateCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Candidate_CompanyId");

            entity.HasIndex(e => e.Status, "IX_HR_Candidate_Status");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BirthPlace).HasMaxLength(50);
            entity.Property(e => e.CandidateCode).HasMaxLength(20);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cvpath)
                .HasMaxLength(255)
                .HasColumnName("CVPath");
            entity.Property(e => e.EducationDepartment).HasMaxLength(100);
            entity.Property(e => e.EducationLevel).HasDefaultValue(3);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ExperienceSummary).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasDefaultValue(1);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LinkedInUrl).HasMaxLength(500);
            entity.Property(e => e.MaritalStatus).HasDefaultValue(1);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.PassportNo).HasMaxLength(15);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PortfolioUrl).HasMaxLength(500);
            entity.Property(e => e.ReferredBy).HasMaxLength(100);
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(15)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.University).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.HrCandidates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Candidate_Company");
        });

        modelBuilder.Entity<HrCertificate>(entity =>
        {
            entity.ToTable("HR_Certificate");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Certificate_EmployeeId");

            entity.HasIndex(e => e.ExpiryDate, "IX_HR_Certificate_ExpiryDate");

            entity.Property(e => e.CertificateName).HasMaxLength(200);
            entity.Property(e => e.CertificateNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IssuingAuthority).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.HrCertificates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Certificate_Company");
        });

        modelBuilder.Entity<HrContract>(entity =>
        {
            entity.ToTable("HR_Contract");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Contract_CompanyId");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Contract_EmployeeId");

            entity.Property(e => e.AnnualLeaveDays).HasDefaultValue(14);
            entity.Property(e => e.Benefits).HasMaxLength(500);
            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.ContractType).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TRY");
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasDefaultValue(1);
            entity.Property(e => e.SpecialTerms).HasMaxLength(500);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.WorkingHoursPerWeek).HasDefaultValue(45);

            entity.HasOne(d => d.Company).WithMany(p => p.HrContracts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Contract_Company");
        });

        modelBuilder.Entity<HrDepartment>(entity =>
        {
            entity.ToTable("HR_Department");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Department_CompanyId");

            entity.HasIndex(e => e.ParentDepartmentId, "IX_HR_Department_ParentDepartmentId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentCode).HasMaxLength(20);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrDepartments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Department_Company");

            entity.HasOne(d => d.ParentDepartment).WithMany(p => p.InverseParentDepartment)
                .HasForeignKey(d => d.ParentDepartmentId)
                .HasConstraintName("FK_HR_Department_ParentDepartment");
        });

        modelBuilder.Entity<HrDiscipline>(entity =>
        {
            entity.ToTable("HR_Discipline");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Discipline_EmployeeId");

            entity.HasIndex(e => e.IncidentDate, "IX_HR_Discipline_IncidentDate");

            entity.Property(e => e.Action).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisciplineType).HasDefaultValue(1);
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.EmployeeResponse).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrDisciplines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Discipline_Company");
        });

        modelBuilder.Entity<HrDocument>(entity =>
        {
            entity.ToTable("HR_Document");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Document_EmployeeId");

            entity.HasIndex(e => e.ExpiryDate, "IX_HR_Document_ExpiryDate");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DocumentName).HasMaxLength(200);
            entity.Property(e => e.DocumentType).HasDefaultValue(99);
            entity.Property(e => e.FilePath).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrDocuments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Document_Company");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.ToTable("HR_Employee");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Employee_CompanyId");

            entity.HasIndex(e => e.DepartmentId, "IX_HR_Employee_DepartmentId");

            entity.HasIndex(e => new { e.CompanyId, e.EmployeeCode }, "IX_HR_Employee_EmployeeCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.EmploymentStatus, "IX_HR_Employee_EmploymentStatus");

            entity.HasIndex(e => e.ManagerId, "IX_HR_Employee_ManagerId");

            entity.HasIndex(e => e.PositionId, "IX_HR_Employee_PositionId");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BankBranch).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BirthPlace).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.EducationDepartment).HasMaxLength(100);
            entity.Property(e => e.EducationLevel).HasDefaultValue(3);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EmergencyContact).HasMaxLength(100);
            entity.Property(e => e.EmergencyPhone).HasMaxLength(20);
            entity.Property(e => e.EmergencyRelation).HasMaxLength(50);
            entity.Property(e => e.EmployeeCode).HasMaxLength(20);
            entity.Property(e => e.EmploymentStatus).HasDefaultValue(1);
            entity.Property(e => e.EmploymentType).HasDefaultValue(1);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasDefaultValue(1);
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.MaritalStatus).HasDefaultValue(1);
            entity.Property(e => e.MilitaryStatus).HasDefaultValue(1);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NameSurname)
                .HasMaxLength(201)
                .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasDefaultValue("Türk");
            entity.Property(e => e.PassportNo).HasMaxLength(15);
            entity.Property(e => e.PersonalEmail).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Sgkno)
                .HasMaxLength(20)
                .HasColumnName("SGKNo");
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(15)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.TerminationReason).HasMaxLength(100);
            entity.Property(e => e.University).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_HR_Employee_Company");

            entity.HasOne(d => d.Department).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_HR_Employee_Department");

            entity.HasOne(d => d.Position).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_HR_Employee_Position");
        });

        modelBuilder.Entity<HrEmployeeSalaryDefinition>(entity =>
        {
            entity.ToTable("HR_EmployeeSalaryDefinition");

            entity.HasIndex(e => e.CompanyId, "IX_HR_EmployeeSalaryDefinition_CompanyId");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_EmployeeSalaryDefinition_EmployeeId");

            entity.HasIndex(e => e.SalaryComponentId, "IX_HR_EmployeeSalaryDefinition_SalaryComponentId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CalcType).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsFixed).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployeeSalaryDefinitions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeSalaryDefinition_Company");

            entity.HasOne(d => d.SalaryComponent).WithMany(p => p.HrEmployeeSalaryDefinitions)
                .HasForeignKey(d => d.SalaryComponentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeSalaryDefinition_SalaryComponent");
        });

        modelBuilder.Entity<HrEmployeeShift>(entity =>
        {
            entity.ToTable("HR_EmployeeShift");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_EmployeeShift_EmployeeId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployeeShifts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeShift_Company");

            entity.HasOne(d => d.Shift).WithMany(p => p.HrEmployeeShifts)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeShift_Shift");
        });

        modelBuilder.Entity<HrEmployeeTraining>(entity =>
        {
            entity.ToTable("HR_EmployeeTraining");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_EmployeeTraining_EmployeeId");

            entity.HasIndex(e => e.TrainingId, "IX_HR_EmployeeTraining_TrainingId");

            entity.Property(e => e.CertificatePath).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.Score).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployeeTrainings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeTraining_Company");

            entity.HasOne(d => d.Training).WithMany(p => p.HrEmployeeTrainings)
                .HasForeignKey(d => d.TrainingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_EmployeeTraining_Training");
        });

        modelBuilder.Entity<HrInterview>(entity =>
        {
            entity.ToTable("HR_Interview");

            entity.HasIndex(e => e.ApplicationId, "IX_HR_Interview_ApplicationId");

            entity.HasIndex(e => e.CandidateId, "IX_HR_Interview_CandidateId");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Interview_CompanyId");

            entity.HasIndex(e => e.ScheduledDate, "IX_HR_Interview_ScheduledDate");

            entity.Property(e => e.ActualEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActualStartDate).HasColumnType("datetime");
            entity.Property(e => e.CommunicationSkills).HasMaxLength(2000);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CulturalFit).HasMaxLength(2000);
            entity.Property(e => e.InterviewNotes).HasMaxLength(2000);
            entity.Property(e => e.InterviewType).HasDefaultValue(1);
            entity.Property(e => e.InterviewerIds).HasMaxLength(500);
            entity.Property(e => e.InterviewerNames).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.MeetingLink).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NextStep).HasMaxLength(500);
            entity.Property(e => e.ScheduledDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.Strengths).HasMaxLength(2000);
            entity.Property(e => e.TechnicalSkills).HasMaxLength(2000);
            entity.Property(e => e.Weaknesses).HasMaxLength(2000);

            entity.HasOne(d => d.Application).WithMany(p => p.HrInterviews)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Interview_Application");

            entity.HasOne(d => d.Candidate).WithMany(p => p.HrInterviews)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Interview_Candidate");

            entity.HasOne(d => d.Company).WithMany(p => p.HrInterviews)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Interview_Company");
        });

        modelBuilder.Entity<HrJobPosting>(entity =>
        {
            entity.ToTable("HR_JobPosting");

            entity.HasIndex(e => e.CompanyId, "IX_HR_JobPosting_CompanyId");

            entity.HasIndex(e => e.DepartmentId, "IX_HR_JobPosting_DepartmentId");

            entity.HasIndex(e => new { e.CompanyId, e.JobCode }, "IX_HR_JobPosting_JobCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.Status, "IX_HR_JobPosting_Status");

            entity.Property(e => e.ClosingDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmploymentType).HasDefaultValue(1);
            entity.Property(e => e.JobCode).HasMaxLength(50);
            entity.Property(e => e.JobDescription).HasMaxLength(2000);
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.MaxSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OtherChannels).HasMaxLength(500);
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Requirements).HasMaxLength(2000);
            entity.Property(e => e.Responsibilities).HasMaxLength(1000);
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrJobPostings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_JobPosting_Company");

            entity.HasOne(d => d.Department).WithMany(p => p.HrJobPostings)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_HR_JobPosting_Department");

            entity.HasOne(d => d.Position).WithMany(p => p.HrJobPostings)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_HR_JobPosting_Position");
        });

        modelBuilder.Entity<HrLeave>(entity =>
        {
            entity.ToTable("HR_Leave");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Leave_EmployeeId");

            entity.HasIndex(e => e.LeaveTypeId, "IX_HR_Leave_LeaveTypeId");

            entity.HasIndex(e => e.StartDate, "IX_HR_Leave_StartDate");

            entity.HasIndex(e => e.Status, "IX_HR_Leave_Status");

            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovalNotes).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.TotalDays)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaves)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Leave_Company");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.HrLeaves)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Leave_LeaveType");
        });

        modelBuilder.Entity<HrLeaveBalance>(entity =>
        {
            entity.ToTable("HR_LeaveBalance");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_LeaveBalance_EmployeeId");

            entity.HasIndex(e => new { e.EmployeeId, e.LeaveTypeId, e.Year }, "UQ_HR_LeaveBalance").IsUnique();

            entity.Property(e => e.CarriedForwardDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EntitledDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UsedDays).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaveBalances)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveBalance_Company");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.HrLeaveBalances)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveBalance_LeaveType");
        });

        modelBuilder.Entity<HrLeaveType>(entity =>
        {
            entity.ToTable("HR_LeaveType");

            entity.HasIndex(e => e.CompanyId, "IX_HR_LeaveType_CompanyId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsPaid).HasDefaultValue(true);
            entity.Property(e => e.LeaveTypeCode).HasMaxLength(20);
            entity.Property(e => e.LeaveTypeName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RequiresApproval).HasDefaultValue(true);

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaveTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveType_Company");
        });

        modelBuilder.Entity<HrOffer>(entity =>
        {
            entity.ToTable("HR_Offer");

            entity.HasIndex(e => e.ApplicationId, "IX_HR_Offer_ApplicationId");

            entity.HasIndex(e => e.CandidateId, "IX_HR_Offer_CandidateId");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Offer_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.OfferCode }, "IX_HR_Offer_OfferCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.Status, "IX_HR_Offer_Status");

            entity.Property(e => e.BaseSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Benefits).HasMaxLength(1000);
            entity.Property(e => e.CandidateResponseDate).HasColumnType("datetime");
            entity.Property(e => e.CandidateResponseNotes).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmploymentType).HasDefaultValue(1);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.OfferCode).HasMaxLength(50);
            entity.Property(e => e.OfferDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OfferDetails).HasMaxLength(2000);
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Application).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Offer_Application");

            entity.HasOne(d => d.Candidate).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Offer_Candidate");

            entity.HasOne(d => d.Company).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Offer_Company");

            entity.HasOne(d => d.Department).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_HR_Offer_Department");

            entity.HasOne(d => d.JobPosting).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.JobPostingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Offer_JobPosting");

            entity.HasOne(d => d.Position).WithMany(p => p.HrOffers)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_HR_Offer_Position");
        });

        modelBuilder.Entity<HrOnboarding>(entity =>
        {
            entity.ToTable("HR_Onboarding");

            entity.HasIndex(e => e.CandidateId, "IX_HR_Onboarding_CandidateId");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Onboarding_CompanyId");

            entity.HasIndex(e => e.OfferId, "IX_HR_Onboarding_OfferId");

            entity.HasIndex(e => new { e.CompanyId, e.OnboardingCode }, "IX_HR_Onboarding_OnboardingCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.Status, "IX_HR_Onboarding_Status");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(2000);
            entity.Property(e => e.OnboardingCode).HasMaxLength(50);
            entity.Property(e => e.OnboardingManagerName).HasMaxLength(200);
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Candidate).WithMany(p => p.HrOnboardings)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Onboarding_Candidate");

            entity.HasOne(d => d.Company).WithMany(p => p.HrOnboardings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Onboarding_Company");

            entity.HasOne(d => d.Offer).WithMany(p => p.HrOnboardings)
                .HasForeignKey(d => d.OfferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Onboarding_Offer");
        });

        modelBuilder.Entity<HrOnboardingChecklist>(entity =>
        {
            entity.ToTable("HR_OnboardingChecklist");

            entity.HasIndex(e => e.CompanyId, "IX_HR_OnboardingChecklist_CompanyId");

            entity.HasIndex(e => e.OnboardingId, "IX_HR_OnboardingChecklist_OnboardingId");

            entity.Property(e => e.CompletedByName).HasMaxLength(200);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.IsRequired).HasDefaultValue(true);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.ItemType).HasDefaultValue(1);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.HrOnboardingChecklists)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_OnboardingChecklist_Company");

            entity.HasOne(d => d.Onboarding).WithMany(p => p.HrOnboardingChecklists)
                .HasForeignKey(d => d.OnboardingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_OnboardingChecklist_Onboarding");
        });

        modelBuilder.Entity<HrOnboardingTask>(entity =>
        {
            entity.ToTable("HR_OnboardingTask");

            entity.HasIndex(e => e.CompanyId, "IX_HR_OnboardingTask_CompanyId");

            entity.HasIndex(e => e.OnboardingId, "IX_HR_OnboardingTask_OnboardingId");

            entity.Property(e => e.AssignedToName).HasMaxLength(200);
            entity.Property(e => e.CompletedByName).HasMaxLength(200);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.TaskName).HasMaxLength(200);
            entity.Property(e => e.TaskType).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrOnboardingTasks)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_OnboardingTask_Company");

            entity.HasOne(d => d.Onboarding).WithMany(p => p.HrOnboardingTasks)
                .HasForeignKey(d => d.OnboardingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_OnboardingTask_Onboarding");
        });

        modelBuilder.Entity<HrPayroll>(entity =>
        {
            entity.ToTable("HR_Payroll");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Payroll_EmployeeId");

            entity.HasIndex(e => e.VoucherId, "IX_HR_Payroll_VoucherId");

            entity.HasIndex(e => new { e.Year, e.Month }, "IX_HR_Payroll_YearMonth");

            entity.HasIndex(e => new { e.EmployeeId, e.Year, e.Month }, "UQ_HR_Payroll_EmployeeMonth").IsUnique();

            entity.Property(e => e.Allowances).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployerCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDeductions).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherEarnings).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OvertimePay).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentReference).HasMaxLength(50);
            entity.Property(e => e.PayrollNo).HasMaxLength(20);
            entity.Property(e => e.Sgkemployee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SGKEmployee");
            entity.Property(e => e.Sgkemployer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SGKEmployer");
            entity.Property(e => e.StampTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.TotalDeductions).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalEarnings).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnemploymentEmployee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnemploymentEmployer).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPayrolls)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Payroll_Company");
        });

        modelBuilder.Entity<HrPayrollDetail>(entity =>
        {
            entity.ToTable("HR_PayrollDetail");

            entity.HasIndex(e => e.CompanyId, "IX_HR_PayrollDetail_CompanyId");

            entity.HasIndex(e => e.PayrollId, "IX_HR_PayrollDetail_PayrollId");

            entity.HasIndex(e => e.SalaryComponentId, "IX_HR_PayrollDetail_SalaryComponentId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPayrollDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_PayrollDetail_Company");

            entity.HasOne(d => d.Payroll).WithMany(p => p.HrPayrollDetails)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_PayrollDetail_Payroll");

            entity.HasOne(d => d.SalaryComponent).WithMany(p => p.HrPayrollDetails)
                .HasForeignKey(d => d.SalaryComponentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_PayrollDetail_SalaryComponent");
        });

        modelBuilder.Entity<HrPayrollItem>(entity =>
        {
            entity.ToTable("HR_PayrollItem");

            entity.HasIndex(e => e.PayrollId, "IX_HR_PayrollItem_PayrollId");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemType).HasDefaultValue(1);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPayrollItems)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_HR_PayrollItem_Company");

            entity.HasOne(d => d.Payroll).WithMany(p => p.HrPayrollItems)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_PayrollItem_Payroll");
        });

        modelBuilder.Entity<HrPerformance>(entity =>
        {
            entity.ToTable("HR_Performance");

            entity.HasIndex(e => e.EmployeeId, "IX_HR_Performance_EmployeeId");

            entity.HasIndex(e => e.PeriodId, "IX_HR_Performance_PeriodId");

            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.Attendance).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Communication).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GoalAchievement).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Initiative).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.JobKnowledge).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OverallScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Productivity).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Quality).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Rating).HasDefaultValue(3);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            entity.Property(e => e.Teamwork).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPerformances)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Performance_Company");

            entity.HasOne(d => d.Period).WithMany(p => p.HrPerformances)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Performance_Period");
        });

        modelBuilder.Entity<HrPerformancePeriod>(entity =>
        {
            entity.ToTable("HR_PerformancePeriod");

            entity.HasIndex(e => e.CompanyId, "IX_HR_PerformancePeriod_CompanyId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PeriodName).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrPerformancePeriods)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_PerformancePeriod_Company");
        });

        modelBuilder.Entity<HrPosition>(entity =>
        {
            entity.ToTable("HR_Position");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Position_CompanyId");

            entity.HasIndex(e => e.DepartmentId, "IX_HR_Position_DepartmentId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Level).HasDefaultValue(1);
            entity.Property(e => e.MaxSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PositionCode).HasMaxLength(20);
            entity.Property(e => e.PositionName).HasMaxLength(100);
            entity.Property(e => e.Requirements).HasMaxLength(2000);

            entity.HasOne(d => d.Company).WithMany(p => p.HrPositions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Position_Company");

            entity.HasOne(d => d.Department).WithMany(p => p.HrPositions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_HR_Position_Department");
        });

        modelBuilder.Entity<HrSalaryComponent>(entity =>
        {
            entity.ToTable("HR_SalaryComponent");

            entity.HasIndex(e => e.CompanyId, "IX_HR_SalaryComponent_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.ComponentCode }, "IX_HR_SalaryComponent_CompanyId_ComponentCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.ComponentType, "IX_HR_SalaryComponent_ComponentType");

            entity.HasIndex(e => e.IsActive, "IX_HR_SalaryComponent_IsActive");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AffectsGross).HasDefaultValue(true);
            entity.Property(e => e.AffectsNet).HasDefaultValue(true);
            entity.Property(e => e.ComponentCode).HasMaxLength(20);
            entity.Property(e => e.ComponentName).HasMaxLength(100);
            entity.Property(e => e.ComponentType).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsSgk)
                .HasDefaultValue(true)
                .HasColumnName("IsSGK");
            entity.Property(e => e.IsTaxable).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrSalaryComponents)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_SalaryComponent_Company");
        });

        modelBuilder.Entity<HrSalaryGrade>(entity =>
        {
            entity.ToTable("HR_SalaryGrade");

            entity.HasIndex(e => e.CompanyId, "IX_HR_SalaryGrade_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.GradeCode }, "IX_HR_SalaryGrade_CompanyId_GradeCode")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.IsActive, "IX_HR_SalaryGrade_IsActive");

            entity.HasIndex(e => e.Level, "IX_HR_SalaryGrade_Level");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TRY");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.GradeCode).HasMaxLength(20);
            entity.Property(e => e.GradeName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Level).HasDefaultValue(1);
            entity.Property(e => e.MaxSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrSalaryGrades)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_SalaryGrade_Company");
        });

        modelBuilder.Entity<HrShift>(entity =>
        {
            entity.ToTable("HR_Shift");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Shift_CompanyId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ShiftCode).HasMaxLength(20);
            entity.Property(e => e.ShiftName).HasMaxLength(50);
            entity.Property(e => e.TotalHours)
                .HasDefaultValue(8m)
                .HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.HrShifts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Shift_Company");
        });

        modelBuilder.Entity<HrTraining>(entity =>
        {
            entity.ToTable("HR_Training");

            entity.HasIndex(e => e.CompanyId, "IX_HR_Training_CompanyId");

            entity.HasIndex(e => e.StartDate, "IX_HR_Training_StartDate");

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TRY");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Provider).HasMaxLength(200);
            entity.Property(e => e.TrainingCode).HasMaxLength(50);
            entity.Property(e => e.TrainingName).HasMaxLength(200);
            entity.Property(e => e.TrainingType).HasDefaultValue(1);

            entity.HasOne(d => d.Company).WithMany(p => p.HrTrainings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Training_Company");
        });

        modelBuilder.Entity<IntProcureShipInbox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INT_Proc__3214EC07F098FAC1");

            entity.ToTable("INT_ProcureShipInbox");

            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentType).HasMaxLength(100);
            entity.Property(e => e.ExternalId).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<IntProcureShipLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INT_Proc__3214EC07C46078AA");

            entity.ToTable("INT_ProcureShipLogs");

            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Direction).HasMaxLength(50);
            entity.Property(e => e.DocumentType).HasMaxLength(100);
            entity.Property(e => e.ExternalReferenceNo).HasMaxLength(250);
            entity.Property(e => e.LocalReferenceNo).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<IntShipServDocument>(entity =>
        {
            entity.ToTable("Int_ShipServDocuments");

            entity.HasIndex(e => e.CompanyId, "IX_Int_ShipServDocuments_CompanyId");

            entity.HasIndex(e => e.LocalDocumentId, "IX_Int_ShipServDocuments_LocalDocumentId");

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Direction).HasMaxLength(10);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.LocalDocumentNo).HasMaxLength(50);
            entity.Property(e => e.SentBy).HasMaxLength(100);
            entity.Property(e => e.ShipServDocumentId).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<IntShipServIncomingOrder>(entity =>
        {
            entity.ToTable("Int_ShipServIncomingOrder");

            entity.Property(e => e.BuyerCompany).HasMaxLength(250);
            entity.Property(e => e.BuyerContact).HasMaxLength(250);
            entity.Property(e => e.BuyerPhone).HasMaxLength(50);
            entity.Property(e => e.CaseCategory).HasMaxLength(100);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DeliveryPort).HasMaxLength(250);
            entity.Property(e => e.Imo)
                .HasMaxLength(50)
                .HasColumnName("IMO");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.Pono)
                .HasMaxLength(100)
                .HasColumnName("PONo");
            entity.Property(e => e.QuotationNo).HasMaxLength(100);
            entity.Property(e => e.ShipServStatus).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VesselName).HasMaxLength(250);
        });

        modelBuilder.Entity<IntShipServIncomingRfq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Int_Ship__3214EC078CD9393A");

            entity.ToTable("Int_ShipServIncomingRFQ");

            entity.Property(e => e.BuyerCompany).HasMaxLength(250);
            entity.Property(e => e.BuyerContact).HasMaxLength(150);
            entity.Property(e => e.BuyerPhone).HasMaxLength(50);
            entity.Property(e => e.CaseCategory).HasMaxLength(100);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliveryPort).HasMaxLength(150);
            entity.Property(e => e.HullNo).HasMaxLength(100);
            entity.Property(e => e.Imo)
                .HasMaxLength(50)
                .HasColumnName("IMO");
            entity.Property(e => e.QuoteBefore).HasColumnType("datetime");
            entity.Property(e => e.RequestNumber).HasMaxLength(100);
            entity.Property(e => e.Rfqdate)
                .HasColumnType("datetime")
                .HasColumnName("RFQDate");
            entity.Property(e => e.Rfqno)
                .HasMaxLength(100)
                .HasColumnName("RFQNo");
            entity.Property(e => e.ShipServRfqid)
                .HasMaxLength(100)
                .HasColumnName("ShipServRFQId");
            entity.Property(e => e.ShipYard).HasMaxLength(250);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("New");
            entity.Property(e => e.SupplierContact).HasMaxLength(150);
            entity.Property(e => e.SupplierName).HasMaxLength(250);
            entity.Property(e => e.SupplierPhone).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VesselEta)
                .HasColumnType("datetime")
                .HasColumnName("VesselETA");
            entity.Property(e => e.VesselEtd)
                .HasColumnType("datetime")
                .HasColumnName("VesselETD");
            entity.Property(e => e.VesselName).HasMaxLength(150);
        });

        modelBuilder.Entity<IntShipServIncomingRfqline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Int_Ship__3214EC07B58BBB0D");

            entity.ToTable("Int_ShipServIncomingRFQLine");

            entity.Property(e => e.Availability).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DrawingNo).HasMaxLength(100);
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("([Quantity]*isnull([UnitCost],(0))-(([Quantity]*isnull([UnitCost],(0)))*isnull([DiscountRate],(0)))/(100.0))", true)
                .HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.Rfqid).HasColumnName("RFQId");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UoM).HasMaxLength(50);
        });

        modelBuilder.Entity<IntShipServSentQuotation>(entity =>
        {
            entity.ToTable("Int_ShipServSentQuotation");

            entity.Property(e => e.BuyerCompany).HasMaxLength(250);
            entity.Property(e => e.BuyerContact).HasMaxLength(250);
            entity.Property(e => e.BuyerPhone).HasMaxLength(50);
            entity.Property(e => e.CaseCategory).HasMaxLength(100);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryPort).HasMaxLength(250);
            entity.Property(e => e.Imo)
                .HasMaxLength(50)
                .HasColumnName("IMO");
            entity.Property(e => e.QuotationNo).HasMaxLength(100);
            entity.Property(e => e.QuoteDate).HasColumnType("datetime");
            entity.Property(e => e.Rfqid).HasColumnName("RFQId");
            entity.Property(e => e.Rfqno)
                .HasMaxLength(100)
                .HasColumnName("RFQNo");
            entity.Property(e => e.ShipServStatus).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VesselName).HasMaxLength(250);
        });

        modelBuilder.Entity<InvAnnualCount>(entity =>
        {
            entity.ToTable("INV_AnnualCounts");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_AnnualCounts_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.CountDate, "IX_INV_AnnualCounts_CountDate");

            entity.HasIndex(e => e.Year, "IX_INV_AnnualCounts_Year");

            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CountDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");

            entity.HasOne(d => d.Company).WithMany(p => p.InvAnnualCounts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_AnnualCounts_Companies");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvAnnualCounts)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_AnnualCounts_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvAnnualCounts)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_AnnualCounts_Warehouse");
        });

        modelBuilder.Entity<InvAnnualCountLine>(entity =>
        {
            entity.ToTable("INV_AnnualCountLines");

            entity.HasIndex(e => e.AnnualCountId, "IX_INV_AnnualCountLines_AnnualCountId");

            entity.HasIndex(e => e.StockId, "IX_INV_AnnualCountLines_StockId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CountedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceQty).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AnnualCount).WithMany(p => p.InvAnnualCountLines)
                .HasForeignKey(d => d.AnnualCountId)
                .HasConstraintName("FK_INV_AnnualCountLines_AnnualCount");

            entity.HasOne(d => d.Company).WithMany(p => p.InvAnnualCountLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_AnnualCountLines_Companies");
        });

        modelBuilder.Entity<InvBarcode>(entity =>
        {
            entity.ToTable("INV_Barcodes");

            entity.HasIndex(e => e.BarcodeValue, "IX_INV_Barcodes_BarcodeValue").IsUnique();

            entity.HasIndex(e => e.StockId, "IX_INV_Barcodes_StockId");

            entity.Property(e => e.BarcodeType).HasDefaultValue(1);
            entity.Property(e => e.BarcodeValue).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsPrimary).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Qrcode)
                .HasMaxLength(50)
                .HasColumnName("QRCode");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.StockId).HasDefaultValue(0);

            entity.HasOne(d => d.Company).WithMany(p => p.InvBarcodes)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_INV_Barcodes_Companies");
        });

        modelBuilder.Entity<InvBatchSerial>(entity =>
        {
            entity.ToTable("INV_BatchSerials");

            entity.HasIndex(e => e.StockId, "IX_INV_BatchSerials_StockId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_BatchSerials_WarehouseId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.InitialQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.ProductionDate).HasColumnType("datetime");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("ACTIVE");
            entity.Property(e => e.StockId).HasDefaultValue(0);
            entity.Property(e => e.SupplierBatchNo).HasMaxLength(100);
            entity.Property(e => e.VesselWarehouseId).HasDefaultValue(0);
            entity.Property(e => e.WarehouseId).HasDefaultValue(0);

            entity.HasOne(d => d.Company).WithMany(p => p.InvBatchSerials)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_INV_BatchSerials_Companies");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvBatchSerials)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_BatchSerials_Warehouse");
        });

        modelBuilder.Entity<InvCostRecalculation>(entity =>
        {
            entity.ToTable("INV_CostRecalculations");

            entity.HasIndex(e => e.CompanyId, "IX_INV_CostRecalculations_CompanyId");

            entity.HasIndex(e => e.RecalcDate, "IX_INV_CostRecalculations_RecalcDate");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RecalcDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecalcType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.ToDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.InvCostRecalculations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_CostRecalculations_Companies");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvCostRecalculations)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_CostRecalculations_Warehouse");
        });

        modelBuilder.Entity<InvCycleCount>(entity =>
        {
            entity.ToTable("INV_CycleCounts");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_CycleCounts_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.CountDate, "IX_INV_CycleCounts_CountDate");

            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CountDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");

            entity.HasOne(d => d.Company).WithMany(p => p.InvCycleCounts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_CycleCounts_Companies");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvCycleCounts)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_CycleCounts_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvCycleCounts)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_CycleCounts_Warehouse");
        });

        modelBuilder.Entity<InvCycleCountLine>(entity =>
        {
            entity.ToTable("INV_CycleCountLines");

            entity.HasIndex(e => e.CycleCountId, "IX_INV_CycleCountLines_CycleCountId");

            entity.HasIndex(e => e.StockId, "IX_INV_CycleCountLines_StockId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CountedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.ShelfAddress).HasMaxLength(50);
            entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceQty).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvCycleCountLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_CycleCountLines_Companies");

            entity.HasOne(d => d.CycleCount).WithMany(p => p.InvCycleCountLines)
                .HasForeignKey(d => d.CycleCountId)
                .HasConstraintName("FK_INV_CycleCountLines_CycleCount");
        });

        modelBuilder.Entity<InvDeliveryHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Stk_DeliveryHeader");

            entity.ToTable("INV_DeliveryHeader");

            entity.HasIndex(e => new { e.CompanyId, e.DeliveryDate }, "IX_Stk_DeliveryHeader_Company_Date").IsDescending(false, true);

            entity.HasIndex(e => new { e.PartnerId, e.DeliveryDate }, "IX_Stk_DeliveryHeader_Partner").IsDescending(false, true);

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValue("TL");
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DeliveryDate).HasPrecision(0);
            entity.Property(e => e.DeliveryNo).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(0);
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RfqNo).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalAmountTL");
        });

        modelBuilder.Entity<InvDeliveryLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Stk_DeliveryLine");

            entity.ToTable("INV_DeliveryLine");

            entity.HasIndex(e => e.HeaderId, "IX_Stk_DeliveryLine_HeaderId");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.GnlTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(0);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.VatRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.VatTotal).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Header).WithMany(p => p.InvDeliveryLines)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stk_DeliveryLine_Header");
        });

        modelBuilder.Entity<InvExpiryTracking>(entity =>
        {
            entity.ToTable("INV_ExpiryTracking");

            entity.HasIndex(e => e.ExpiryDate, "IX_INV_ExpiryTracking_ExpiryDate");

            entity.HasIndex(e => e.StockId, "IX_INV_ExpiryTracking_StockId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.LastAlertDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductionDate).HasColumnType("datetime");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.InvExpiryTrackings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ExpiryTracking_Companies");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvExpiryTrackings)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_ExpiryTracking_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvExpiryTrackings)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_ExpiryTracking_Warehouse");
        });

        modelBuilder.Entity<InvFifolot>(entity =>
        {
            entity.ToTable("INV_FIFOLots");

            entity.HasIndex(e => e.EntryDate, "IX_INV_FIFOLots_EntryDate");

            entity.HasIndex(e => e.StockId, "IX_INV_FIFOLots_StockId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_FIFOLots_WarehouseId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvFifolots)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_FIFOLots_Companies");

            entity.HasOne(d => d.RefMovement).WithMany(p => p.InvFifolots)
                .HasForeignKey(d => d.RefMovementId)
                .HasConstraintName("FK_INV_FIFOLots_StockMovement");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvFifolots)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_FIFOLots_Warehouse");
        });

        modelBuilder.Entity<InvGoodsIssue>(entity =>
        {
            entity.ToTable("INV_GoodsIssues");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_GoodsIssues_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_GoodsIssues_DocumentDate");

            entity.HasIndex(e => e.ProjectId, "IX_INV_GoodsIssues_ProjectId");

            entity.Property(e => e.ApprovedByUserId).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveredBy).HasMaxLength(100);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.IssueType)
                .HasMaxLength(20)
                .HasDefaultValue("STANDARD");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedBy).HasMaxLength(100);
            entity.Property(e => e.ReceivedByName).HasMaxLength(100);
            entity.Property(e => e.RejectionReason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ShippingMethod).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.TrackingNumber).HasMaxLength(50);
            entity.Property(e => e.VehiclePlateNo).HasMaxLength(20);

            entity.HasOne(d => d.Company).WithMany(p => p.InvGoodsIssues)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_GoodsIssues_Companies");

            entity.HasOne(d => d.Project).WithMany(p => p.InvGoodsIssues)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_INV_GoodsIssues_Project");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvGoodsIssues)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_GoodsIssues_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvGoodsIssues)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_GoodsIssues_Warehouse");
        });

        modelBuilder.Entity<InvGoodsIssueLine>(entity =>
        {
            entity.ToTable("INV_GoodsIssueLines");

            entity.HasIndex(e => e.GoodsIssueId, "IX_INV_GoodsIssueLines_GoodsIssueId");

            entity.HasIndex(e => e.StockId, "IX_INV_GoodsIssueLines_StockId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IssuedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RequestedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvGoodsIssueLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_GoodsIssueLines_Companies");

            entity.HasOne(d => d.GoodsIssue).WithMany(p => p.InvGoodsIssueLines)
                .HasForeignKey(d => d.GoodsIssueId)
                .HasConstraintName("FK_INV_GoodsIssueLines_GoodsIssue");
        });

        modelBuilder.Entity<InvGoodsIssueLineImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INV_Good__3214EC07C47A8E5D");

            entity.ToTable("INV_GoodsIssueLineImages");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.GoodsIssueLine).WithMany(p => p.InvGoodsIssueLineImages)
                .HasForeignKey(d => d.GoodsIssueLineId)
                .HasConstraintName("FK_GILineImages_GILine");
        });

        modelBuilder.Entity<InvGoodsReceipt>(entity =>
        {
            entity.ToTable("INV_GoodsReceipts");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_GoodsReceipts_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_GoodsReceipts_DocumentDate");

            entity.HasIndex(e => e.ProjectId, "IX_INV_GoodsReceipts_ProjectId");

            entity.Property(e => e.ApprovedByUserId).HasMaxLength(450);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveredBy).HasMaxLength(100);
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.ReceivedBy).HasMaxLength(100);
            entity.Property(e => e.RejectionReason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RfqNo).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.SupplierInvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.SupplierInvoiceNo).HasMaxLength(50);
            entity.Property(e => e.WaybillNo).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.InvGoodsReceipts)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_INV_GoodsReceipts_Companies");

            entity.HasOne(d => d.Project).WithMany(p => p.InvGoodsReceipts)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_INV_GoodsReceipts_Project");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvGoodsReceipts)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_GoodsReceipts_Warehouse");
        });

        modelBuilder.Entity<InvGoodsReceiptLine>(entity =>
        {
            entity.ToTable("INV_GoodsReceiptLines");

            entity.HasIndex(e => e.GoodsReceiptId, "IX_INV_GoodsReceiptLines_GoodsReceiptId");

            entity.HasIndex(e => e.StockId, "IX_INV_GoodsReceiptLines_StockId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.LandedCostAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RejectedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TotalCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvGoodsReceiptLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_GoodsReceiptLines_Companies");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.InvGoodsReceiptLines)
                .HasForeignKey(d => d.GoodsReceiptId)
                .HasConstraintName("FK_INV_GoodsReceiptLines_GoodsReceipt");
        });

        modelBuilder.Entity<InvGoodsReceiptLineImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INV_Good__3214EC0750C64E86");

            entity.ToTable("INV_GoodsReceiptLineImages");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.GoodsReceiptLine).WithMany(p => p.InvGoodsReceiptLineImages)
                .HasForeignKey(d => d.GoodsReceiptLineId)
                .HasConstraintName("FK_GRLineImages_GRLine");
        });

        modelBuilder.Entity<InvInterDepotTransfer>(entity =>
        {
            entity.ToTable("INV_InterDepotTransfers");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_InterDepotTransfers_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_InterDepotTransfers_DocumentDate");

            entity.Property(e => e.ActualReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");

            entity.HasOne(d => d.Company).WithMany(p => p.InvInterDepotTransfers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_InterDepotTransfers_Companies");

            entity.HasOne(d => d.FromWarehouse).WithMany(p => p.InvInterDepotTransferFromWarehouses)
                .HasForeignKey(d => d.FromWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_InterDepotTransfers_FromWarehouse");

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.InvInterDepotTransferToWarehouses)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_InterDepotTransfers_ToWarehouse");
        });

        modelBuilder.Entity<InvInterDepotTransferLine>(entity =>
        {
            entity.ToTable("INV_InterDepotTransferLines");

            entity.HasIndex(e => e.InterDepotTransferId, "IX_INV_InterDepotTransferLines_InterDepotTransferId");

            entity.HasIndex(e => e.StockId, "IX_INV_InterDepotTransferLines_StockId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TransferQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvInterDepotTransferLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_InterDepotTransferLines_Companies");

            entity.HasOne(d => d.InterDepotTransfer).WithMany(p => p.InvInterDepotTransferLines)
                .HasForeignKey(d => d.InterDepotTransferId)
                .HasConstraintName("FK_INV_InterDepotTransferLines_InterDepotTransfer");
        });

        modelBuilder.Entity<InvLandedCost>(entity =>
        {
            entity.ToTable("INV_LandedCosts");

            entity.HasIndex(e => e.CompanyId, "IX_INV_LandedCosts_CompanyId");

            entity.HasIndex(e => e.GoodsReceiptId, "IX_INV_LandedCosts_GoodsReceiptId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CostType).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DistributionMethod).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.InvLandedCosts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_LandedCosts_Companies");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.InvLandedCosts)
                .HasForeignKey(d => d.GoodsReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_LandedCosts_GoodsReceipt");
        });

        modelBuilder.Entity<InvLandedCostDistribution>(entity =>
        {
            entity.ToTable("INV_LandedCostDistributions");

            entity.HasIndex(e => e.GoodsReceiptLineId, "IX_INV_LandedCostDistributions_GoodsReceiptLineId");

            entity.HasIndex(e => e.LandedCostId, "IX_INV_LandedCostDistributions_LandedCostId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DistributedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.InvLandedCostDistributions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_LandedCostDistributions_Companies");

            entity.HasOne(d => d.GoodsReceiptLine).WithMany(p => p.InvLandedCostDistributions)
                .HasForeignKey(d => d.GoodsReceiptLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_LandedCostDistributions_GoodsReceiptLine");

            entity.HasOne(d => d.LandedCost).WithMany(p => p.InvLandedCostDistributions)
                .HasForeignKey(d => d.LandedCostId)
                .HasConstraintName("FK_INV_LandedCostDistributions_LandedCost");
        });

        modelBuilder.Entity<InvMinimumStockAlert>(entity =>
        {
            entity.ToTable("INV_MinimumStockAlerts");

            entity.HasIndex(e => e.StockId, "IX_INV_MinimumStockAlerts_StockId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_MinimumStockAlerts_WarehouseId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastAlertDate).HasColumnType("datetime");
            entity.Property(e => e.MinQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ReorderQty).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvMinimumStockAlerts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_MinimumStockAlerts_Companies");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvMinimumStockAlerts)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_MinimumStockAlerts_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvMinimumStockAlerts)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_MinimumStockAlerts_Warehouse");
        });

        modelBuilder.Entity<InvReturnFromVesselLine>(entity =>
        {
            entity.ToTable("INV_ReturnFromVesselLines");

            entity.HasIndex(e => e.ReturnFromVesselId, "IX_INV_ReturnFromVesselLines_ReturnFromVesselId");

            entity.HasIndex(e => e.StockId, "IX_INV_ReturnFromVesselLines_StockId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvReturnFromVesselLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnFromVesselLines_Companies");

            entity.HasOne(d => d.ReturnFromVessel).WithMany(p => p.InvReturnFromVesselLines)
                .HasForeignKey(d => d.ReturnFromVesselId)
                .HasConstraintName("FK_INV_ReturnFromVesselLines_ReturnFromVessel");
        });

        modelBuilder.Entity<InvReturnToSupplierLine>(entity =>
        {
            entity.ToTable("INV_ReturnToSupplierLines");

            entity.HasIndex(e => e.ReturnToSupplierId, "IX_INV_ReturnToSupplierLines_ReturnToSupplierId");

            entity.HasIndex(e => e.StockId, "IX_INV_ReturnToSupplierLines_StockId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvReturnToSupplierLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnToSupplierLines_Companies");

            entity.HasOne(d => d.ReturnToSupplier).WithMany(p => p.InvReturnToSupplierLines)
                .HasForeignKey(d => d.ReturnToSupplierId)
                .HasConstraintName("FK_INV_ReturnToSupplierLines_ReturnToSupplier");
        });

        modelBuilder.Entity<InvReturnsFromVessel>(entity =>
        {
            entity.ToTable("INV_ReturnsFromVessel");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_ReturnsFromVessel_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_ReturnsFromVessel_DocumentDate");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");

            entity.HasOne(d => d.Company).WithMany(p => p.InvReturnsFromVessels)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnsFromVessel_Companies");

            entity.HasOne(d => d.GoodsIssue).WithMany(p => p.InvReturnsFromVessels)
                .HasForeignKey(d => d.GoodsIssueId)
                .HasConstraintName("FK_INV_ReturnsFromVessel_GoodsIssue");

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.InvReturnsFromVessels)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnsFromVessel_ToWarehouse");
        });

        modelBuilder.Entity<InvReturnsToSupplier>(entity =>
        {
            entity.ToTable("INV_ReturnsToSupplier");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_ReturnsToSupplier_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_ReturnsToSupplier_DocumentDate");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");

            entity.HasOne(d => d.Company).WithMany(p => p.InvReturnsToSuppliers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnsToSupplier_Companies");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.InvReturnsToSuppliers)
                .HasForeignKey(d => d.GoodsReceiptId)
                .HasConstraintName("FK_INV_ReturnsToSupplier_GoodsReceipt");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvReturnsToSuppliers)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ReturnsToSupplier_Warehouse");
        });

        modelBuilder.Entity<InvStock>(entity =>
        {
            entity.ToTable("INV_Stocks");

            entity.HasIndex(e => e.WarehouseId, "IX_GNL_Stocks_WarehouseId");

            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.Afkdvrate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AFKDVRate");
            entity.Property(e => e.B2bactive)
                .HasDefaultValue(false)
                .HasColumnName("B2BActive");
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.BoxNo).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(250);
            entity.Property(e => e.Bsfkdvrate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BSFKDVRate");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CostCalculate).HasDefaultValue(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyDealer)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyPurchase)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DealerSalesPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultValuationMethod).HasMaxLength(50);
            entity.Property(e => e.DiscountPrstg)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.DrawingNo).HasMaxLength(100);
            entity.Property(e => e.Dsc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSC");
            entity.Property(e => e.ExprDateControl).HasDefaultValue(false);
            entity.Property(e => e.Favorite).HasDefaultValue(false);
            entity.Property(e => e.Foto).HasMaxLength(250);
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.Gtip)
                .HasDefaultValue(0)
                .HasColumnName("GTIP");
            entity.Property(e => e.HasRecipe).HasDefaultValue(false);
            entity.Property(e => e.Impacode)
                .HasMaxLength(20)
                .HasColumnName("IMPACode");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Issacode)
                .HasMaxLength(20)
                .HasColumnName("ISSACode");
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.MaxQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxQtyControl).HasDefaultValue(false);
            entity.Property(e => e.MinQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinQtyControl).HasDefaultValue(false);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(100);
            entity.Property(e => e.PrchPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(1000);
            entity.Property(e => e.Profit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PurcahseAccountCode).HasMaxLength(50);
            entity.Property(e => e.PurcahseTaxCode).HasMaxLength(50);
            entity.Property(e => e.QrCode).HasMaxLength(3000);
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rating)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefCode).HasMaxLength(20);
            entity.Property(e => e.SaleActive).HasDefaultValue(false);
            entity.Property(e => e.SalePrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesAccountCode).HasMaxLength(50);
            entity.Property(e => e.SalesTaxCode).HasMaxLength(50);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.SerialNoActive).HasDefaultValue(false);
            entity.Property(e => e.Sfkdvrate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SFKDVRate");
            entity.Property(e => e.ShelfAddress).HasMaxLength(100);
            entity.Property(e => e.ShipmentId).HasDefaultValue(0);
            entity.Property(e => e.ShowOnWeb).HasDefaultValue(false);
            entity.Property(e => e.SpecialCode).HasMaxLength(50);
            entity.Property(e => e.StandardCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StockCode).HasMaxLength(50);
            entity.Property(e => e.StockName).HasMaxLength(1000);
            entity.Property(e => e.StockNameTr).HasMaxLength(1000);
            entity.Property(e => e.SubCategory).HasMaxLength(250);
            entity.Property(e => e.SubCategory2).HasMaxLength(250);
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.Volume)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Xml)
                .HasDefaultValue(false)
                .HasColumnName("XML");
        });

        modelBuilder.Entity<InvStockImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INV_Stoc__3214EC076EA5B3ED");

            entity.ToTable("INV_StockImages");

            entity.HasIndex(e => e.StockId, "IX_INV_StockImages_StockId");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .HasDefaultValue("Admin");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InvStockMovement>(entity =>
        {
            entity.ToTable("INV_StockMovements", tb => tb.HasTrigger("TRG_INV_StockMovements_UpdateStockQty"));

            entity.HasIndex(e => e.MovementDate, "IX_INV_StockMovements_MovementDate");

            entity.HasIndex(e => e.MovementType, "IX_INV_StockMovements_MovementType");

            entity.HasIndex(e => e.ProjectId, "IX_INV_StockMovements_ProjectId");

            entity.HasIndex(e => new { e.RefModule, e.RefId }, "IX_INV_StockMovements_RefModule_RefId");

            entity.HasIndex(e => e.StockId, "IX_INV_StockMovements_StockId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_StockMovements_WarehouseId");

            entity.Property(e => e.AfterCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AfterQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.BeforeCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BeforeQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CurrencyRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MovementDate).HasColumnType("datetime");
            entity.Property(e => e.MovementType).HasMaxLength(50);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ValuationMethod).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.InvStockMovements)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockMovements_Companies");

            entity.HasOne(d => d.Project).WithMany(p => p.InvStockMovements)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_INV_StockMovements_Project");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvStockMovements)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_StockMovements_Warehouse");
        });

        modelBuilder.Entity<InvStockOnHand>(entity =>
        {
            entity.ToTable("INV_StockOnHand");

            entity.HasIndex(e => e.StockId, "IX_INV_StockOnHand_StockId");

            entity.HasIndex(e => e.VesselWarehouseId, "IX_INV_StockOnHand_VesselWarehouseId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_StockOnHand_WarehouseId");

            entity.Property(e => e.AvailableQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AvgCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LastMovementDate).HasColumnType("datetime");
            entity.Property(e => e.LastRecalcDate).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReservedQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TotalValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValuationMethod).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.InvStockOnHands)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockOnHand_Companies");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvStockOnHands)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_StockOnHand_Warehouse");
        });

        modelBuilder.Entity<InvStockTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stk_Stoc__3214EC07D5B2F520");

            entity.ToTable("INV_StockTrans");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<InvStockTransfer>(entity =>
        {
            entity.ToTable("INV_StockTransfers");

            entity.HasIndex(e => new { e.CompanyId, e.DocumentNo }, "IX_INV_StockTransfers_CompanyId_DocumentNo").IsUnique();

            entity.HasIndex(e => e.DocumentDate, "IX_INV_StockTransfers_DocumentDate");

            entity.Property(e => e.ActualReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.TransferType)
                .HasMaxLength(50)
                .HasDefaultValue("WAREHOUSE_TO_VESSEL");

            entity.HasOne(d => d.Company).WithMany(p => p.InvStockTransfers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockTransfers_Companies");

            entity.HasOne(d => d.FromVesselWarehouse).WithMany(p => p.InvStockTransferFromVesselWarehouses)
                .HasForeignKey(d => d.FromVesselWarehouseId)
                .HasConstraintName("FK_INV_StockTransfers_FromVesselWarehouse");

            entity.HasOne(d => d.FromWarehouse).WithMany(p => p.InvStockTransferFromWarehouses)
                .HasForeignKey(d => d.FromWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockTransfers_FromWarehouse");

            entity.HasOne(d => d.ToVesselWarehouse).WithMany(p => p.InvStockTransferToVesselWarehouses)
                .HasForeignKey(d => d.ToVesselWarehouseId)
                .HasConstraintName("FK_INV_StockTransfers_ToVesselWarehouse");

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.InvStockTransferToWarehouses)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockTransfers_ToWarehouse");
        });

        modelBuilder.Entity<InvStockTransferLine>(entity =>
        {
            entity.ToTable("INV_StockTransferLines");

            entity.HasIndex(e => e.StockId, "IX_INV_StockTransferLines_StockId");

            entity.HasIndex(e => e.StockTransferId, "IX_INV_StockTransferLines_StockTransferId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.TransferQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvStockTransferLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_StockTransferLines_Companies");

            entity.HasOne(d => d.StockTransfer).WithMany(p => p.InvStockTransferLines)
                .HasForeignKey(d => d.StockTransferId)
                .HasConstraintName("FK_INV_StockTransferLines_StockTransfer");
        });

        modelBuilder.Entity<InvStore>(entity =>
        {
            entity.ToTable("INV_Stores");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMail");
            entity.Property(e => e.Latitude).HasMaxLength(100);
            entity.Property(e => e.Longitude).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.StoreCode).HasMaxLength(20);
            entity.Property(e => e.StoreName).HasMaxLength(100);
            entity.Property(e => e.Town).HasMaxLength(50);
            entity.Property(e => e.Xmlshow).HasColumnName("XMLShow");
        });

        modelBuilder.Entity<InvUnitsOfMeasure>(entity =>
        {
            entity.ToTable("INV_UnitsOfMeasure");

            entity.HasIndex(e => new { e.CompanyId, e.UoMcode }, "IX_INV_UnitsOfMeasure_CompanyId_UoMCode").IsUnique();

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BaseUoMid).HasColumnName("BaseUoMId");
            entity.Property(e => e.ConversionFactor).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Symbol).HasMaxLength(10);
            entity.Property(e => e.UoMcode)
                .HasMaxLength(10)
                .HasColumnName("UoMCode");
            entity.Property(e => e.UoMname)
                .HasMaxLength(50)
                .HasColumnName("UoMName");

            entity.HasOne(d => d.BaseUoM).WithMany(p => p.InverseBaseUoM)
                .HasForeignKey(d => d.BaseUoMid)
                .HasConstraintName("FK_INV_UnitsOfMeasure_BaseUoM");

            entity.HasOne(d => d.Company).WithMany(p => p.InvUnitsOfMeasures)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_UnitsOfMeasure_Companies");
        });

        modelBuilder.Entity<InvValuationMethod>(entity =>
        {
            entity.ToTable("INV_ValuationMethods");

            entity.HasIndex(e => e.CompanyId, "IX_INV_ValuationMethods_CompanyId");

            entity.HasIndex(e => e.StockId, "IX_INV_ValuationMethods_StockId");

            entity.HasIndex(e => e.WarehouseId, "IX_INV_ValuationMethods_WarehouseId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ValuationMethod).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.InvValuationMethods)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_ValuationMethods_Companies");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvValuationMethods)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_INV_ValuationMethods_Warehouse");
        });

        modelBuilder.Entity<InvVarianceReport>(entity =>
        {
            entity.ToTable("INV_VarianceReports");

            entity.HasIndex(e => new { e.CompanyId, e.ReportNo }, "IX_INV_VarianceReports_CompanyId_ReportNo").IsUnique();

            entity.HasIndex(e => e.ReportDate, "IX_INV_VarianceReports_ReportDate");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.ReportNo).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.TotalVarianceAmount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.AnnualCount).WithMany(p => p.InvVarianceReports)
                .HasForeignKey(d => d.AnnualCountId)
                .HasConstraintName("FK_INV_VarianceReports_AnnualCount");

            entity.HasOne(d => d.Company).WithMany(p => p.InvVarianceReports)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_VarianceReports_Companies");

            entity.HasOne(d => d.CycleCount).WithMany(p => p.InvVarianceReports)
                .HasForeignKey(d => d.CycleCountId)
                .HasConstraintName("FK_INV_VarianceReports_CycleCount");

            entity.HasOne(d => d.VesselWarehouse).WithMany(p => p.InvVarianceReports)
                .HasForeignKey(d => d.VesselWarehouseId)
                .HasConstraintName("FK_INV_VarianceReports_VesselWarehouse");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InvVarianceReports)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_VarianceReports_Warehouse");
        });

        modelBuilder.Entity<InvVarianceReportLine>(entity =>
        {
            entity.ToTable("INV_VarianceReportLines");

            entity.HasIndex(e => e.StockId, "IX_INV_VarianceReportLines_StockId");

            entity.HasIndex(e => e.VarianceReportId, "IX_INV_VarianceReportLines_VarianceReportId");

            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.CountedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.SystemQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VarianceQty).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvVarianceReportLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_VarianceReportLines_Companies");

            entity.HasOne(d => d.VarianceReport).WithMany(p => p.InvVarianceReportLines)
                .HasForeignKey(d => d.VarianceReportId)
                .HasConstraintName("FK_INV_VarianceReportLines_VarianceReport");
        });

        modelBuilder.Entity<InvVesselWarehouse>(entity =>
        {
            entity.ToTable("INV_VesselWarehouses");

            entity.HasIndex(e => e.VesselId, "IX_INV_VesselWarehouses_VesselId");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.WarehouseCode).HasMaxLength(20);
            entity.Property(e => e.WarehouseName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.InvVesselWarehouses)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_VesselWarehouses_Companies");

            entity.HasOne(d => d.Vessel).WithMany(p => p.InvVesselWarehouses)
                .HasForeignKey(d => d.VesselId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_VesselWarehouses_Vessels");
        });

        modelBuilder.Entity<InvWarehouse>(entity =>
        {
            entity.ToTable("INV_Warehouses");

            entity.HasIndex(e => new { e.CompanyId, e.WarehouseCode }, "IX_INV_Warehouses_CompanyId_WarehouseCode").IsUnique();

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Capacity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Latitude).HasMaxLength(50);
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Longitude).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Town).HasMaxLength(50);
            entity.Property(e => e.WarehouseCode).HasMaxLength(20);
            entity.Property(e => e.WarehouseName).HasMaxLength(100);
            entity.Property(e => e.WarehouseType).HasDefaultValue(1);
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Company).WithMany(p => p.InvWarehouses)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_Warehouses_Companies");
        });

        modelBuilder.Entity<LojBillsOfLading>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Bill__3214EC0796F5E334");

            entity.ToTable("LOJ_BillsOfLading");

            entity.Property(e => e.Bldate).HasColumnName("BLDate");
            entity.Property(e => e.Blno)
                .HasMaxLength(50)
                .HasColumnName("BLNo");
            entity.Property(e => e.Bltype)
                .HasMaxLength(50)
                .HasColumnName("BLType");
            entity.Property(e => e.Consignee).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FreightTerms).HasMaxLength(50);
            entity.Property(e => e.GoodsDescription).HasMaxLength(500);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotifyParty).HasMaxLength(200);
            entity.Property(e => e.PackageType).HasMaxLength(50);
            entity.Property(e => e.PaymentTerms).HasMaxLength(50);
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(100);
            entity.Property(e => e.PlaceOfReceipt).HasMaxLength(100);
            entity.Property(e => e.PortOfDischarge).HasMaxLength(100);
            entity.Property(e => e.PortOfLoading).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Shipper).HasMaxLength(200);
            entity.Property(e => e.ShippingMarks).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VesselName).HasMaxLength(100);
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VoyageNo).HasMaxLength(50);

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojBillsOfLadings)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK_LOJ_BillsOfLading_Shipment");
        });

        modelBuilder.Entity<LojBondedWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Bond__3214EC07288DC76F");

            entity.ToTable("LOJ_BondedWarehouses");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.TotalCapacity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsedCapacity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WarehouseCode).HasMaxLength(50);
            entity.Property(e => e.WarehouseName).HasMaxLength(200);
            entity.Property(e => e.WarehouseType).HasMaxLength(50);

            entity.HasOne(d => d.Port).WithMany(p => p.LojBondedWarehouses)
                .HasForeignKey(d => d.PortId)
                .HasConstraintName("FK_BondedWarehouses_Port");
        });

        modelBuilder.Entity<LojCargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Carg__3214EC077C71ECAC");

            entity.ToTable("LOJ_Cargos");

            entity.Property(e => e.CargoDescription).HasMaxLength(200);
            entity.Property(e => e.CargoNo).HasMaxLength(50);
            entity.Property(e => e.CargoType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DeclaredValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HazardousDescription).HasMaxLength(200);
            entity.Property(e => e.Hscode)
                .HasMaxLength(100)
                .HasColumnName("HSCode");
            entity.Property(e => e.Imoclass)
                .HasMaxLength(20)
                .HasColumnName("IMOClass");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsHazardous).HasDefaultValue(false);
            entity.Property(e => e.MaxTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.MinTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PackageType).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RequiresTemperatureControl).HasDefaultValue(false);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Unnumber)
                .HasMaxLength(20)
                .HasColumnName("UNNumber");
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeUnit).HasMaxLength(10);
            entity.Property(e => e.WeightUnit).HasMaxLength(10);
        });

        modelBuilder.Entity<LojContainer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Cont__3214EC07DE29FE6F");

            entity.ToTable("LOJ_Containers");

            entity.HasIndex(e => e.ContainerNo, "IX_LOJ_Containers_ContainerNo");

            entity.HasIndex(e => e.Status, "IX_LOJ_Containers_Status");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.ContainerNo).HasMaxLength(20);
            entity.Property(e => e.ContainerSize).HasMaxLength(50);
            entity.Property(e => e.ContainerType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentLocation).HasMaxLength(200);
            entity.Property(e => e.CurrentTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DamageDescription).HasMaxLength(500);
            entity.Property(e => e.InternalVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsOwned).HasDefaultValue(false);
            entity.Property(e => e.IsReefer).HasDefaultValue(false);
            entity.Property(e => e.MaxGrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxPayload).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SetTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TareWeight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CurrentPort).WithMany(p => p.LojContainers)
                .HasForeignKey(d => d.CurrentPortId)
                .HasConstraintName("FK_LOJ_Containers_CurrentPort");
        });

        modelBuilder.Entity<LojContainerDamageReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Cont__3214EC07C5AAB6FE");

            entity.ToTable("LOJ_ContainerDamageReports");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DamageLocation).HasMaxLength(200);
            entity.Property(e => e.DamageSeverity).HasMaxLength(50);
            entity.Property(e => e.DamageType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RepairCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReportNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Container).WithMany(p => p.LojContainerDamageReports)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ContainerDamageReports_Container");
        });

        modelBuilder.Entity<LojCustomsDeclaration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Cust__3214EC07A9284175");

            entity.ToTable("LOJ_CustomsDeclarations");

            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.Cifvalue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CIFValue");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CustomsDuty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomsOffice).HasMaxLength(100);
            entity.Property(e => e.DeclarationNo).HasMaxLength(50);
            entity.Property(e => e.DeclarationType).HasMaxLength(50);
            entity.Property(e => e.EntryPort).HasMaxLength(50);
            entity.Property(e => e.Fobvalue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FOBValue");
            entity.Property(e => e.FreightValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsuranceValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OtherTaxes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDuties).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAT");

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojCustomsDeclarations)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK_LOJ_CustomsDeclarations_Shipment");
        });

        modelBuilder.Entity<LojCustomsDeclarationItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Cust__3214EC07A4B110ED");

            entity.ToTable("LOJ_CustomsDeclarationItems");

            entity.Property(e => e.CountryOfOrigin).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DutyAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Hscode)
                .HasMaxLength(20)
                .HasColumnName("HSCode");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Declaration).WithMany(p => p.LojCustomsDeclarationItems)
                .HasForeignKey(d => d.DeclarationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_CustomsDeclarationItems_Declaration");
        });

        modelBuilder.Entity<LojFreightInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Frei__3214EC07DBBCC3EB");

            entity.ToTable("LOJ_FreightInvoices");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojFreightInvoices)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK_LOJ_FreightInvoices_Shipment");
        });

        modelBuilder.Entity<LojFreightInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Frei__3214EC07DA4FA5D6");

            entity.ToTable("LOJ_FreightInvoiceItems");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChargeType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InverseInvoice)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreightInvoiceItems_Invoice");
        });

        modelBuilder.Entity<LojLogisticsAlert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Logi__3214EC0712C3BCF6");

            entity.ToTable("LOJ_LogisticsAlerts");

            entity.HasIndex(e => e.Severity, "IX_LogisticsAlerts_Severity");

            entity.HasIndex(e => e.Status, "IX_LogisticsAlerts_Status");

            entity.Property(e => e.AcknowledgedAt).HasColumnType("datetime");
            entity.Property(e => e.AlertDate).HasColumnType("datetime");
            entity.Property(e => e.AlertNo).HasMaxLength(50);
            entity.Property(e => e.AlertType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Resolution).HasMaxLength(500);
            entity.Property(e => e.ResolvedAt).HasColumnType("datetime");
            entity.Property(e => e.Severity).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Subject).HasMaxLength(200);
        });

        modelBuilder.Entity<LojPortCall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Port__3214EC07FEF48B34");

            entity.ToTable("LOJ_PortCalls");

            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.BerthCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BerthNo).HasMaxLength(50);
            entity.Property(e => e.BerthingTime).HasColumnType("datetime");
            entity.Property(e => e.CallNo).HasMaxLength(50);
            entity.Property(e => e.CallType).HasMaxLength(50);
            entity.Property(e => e.CargoDischarged).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargoLoaded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PilotageCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PortDues).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TugCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnberthingTime).HasColumnType("datetime");
            entity.Property(e => e.WaitingReason).HasMaxLength(200);

            entity.HasOne(d => d.Port).WithMany(p => p.LojPortCalls)
                .HasForeignKey(d => d.PortId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PortCalls_Port");

            entity.HasOne(d => d.Vessel).WithMany(p => p.LojPortCalls)
                .HasForeignKey(d => d.VesselId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PortCalls_Vessel");
        });

        modelBuilder.Entity<LojRoutePort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Rout__3214EC0708ABADBC");

            entity.ToTable("LOJ_RoutePorts");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OperationType).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(200);

            entity.HasOne(d => d.Port).WithMany(p => p.LojRoutePorts)
                .HasForeignKey(d => d.PortId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_RoutePorts_Port");

            entity.HasOne(d => d.Route).WithMany(p => p.LojRoutePorts)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_RoutePorts_Route");
        });

        modelBuilder.Entity<LojShipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC07657FB639");

            entity.ToTable("LOJ_Shipments");

            entity.HasIndex(e => e.ShipmentDate, "IX_LOJ_Shipments_ShipmentDate");

            entity.HasIndex(e => e.ShipmentNo, "IX_LOJ_Shipments_ShipmentNo");

            entity.HasIndex(e => e.Status, "IX_LOJ_Shipments_Status");

            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DestinationAddress).HasMaxLength(200);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FreightCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsUrgent).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OriginAddress).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ShipmentNo).HasMaxLength(50);
            entity.Property(e => e.ShipmentType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.DestinationPort).WithMany(p => p.LojShipmentDestinationPorts)
                .HasForeignKey(d => d.DestinationPortId)
                .HasConstraintName("FK_LOJ_Shipments_DestinationPort");

            entity.HasOne(d => d.OriginPort).WithMany(p => p.LojShipmentOriginPorts)
                .HasForeignKey(d => d.OriginPortId)
                .HasConstraintName("FK_LOJ_Shipments_OriginPort");

            entity.HasOne(d => d.Route).WithMany(p => p.LojShipments)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK_LOJ_Shipments_Route");

            entity.HasOne(d => d.Vessel).WithMany(p => p.LojShipments)
                .HasForeignKey(d => d.VesselId)
                .HasConstraintName("FK_LOJ_Shipments_Vessel");
        });

        modelBuilder.Entity<LojShipmentCargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC07C343465F");

            entity.ToTable("LOJ_ShipmentCargos");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Remarks).HasMaxLength(200);

            entity.HasOne(d => d.Cargo).WithMany(p => p.LojShipmentCargos)
                .HasForeignKey(d => d.CargoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentCargos_Cargo");

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojShipmentCargos)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentCargos_Shipment");
        });

        modelBuilder.Entity<LojShipmentContainer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC079749D5E6");

            entity.ToTable("LOJ_ShipmentContainers");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SealNo).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Container).WithMany(p => p.LojShipmentContainers)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentContainers_Container");

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojShipmentContainers)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentContainers_Shipment");
        });

        modelBuilder.Entity<LojShipmentCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC07B62C6F3E");

            entity.ToTable("LOJ_ShipmentCosts");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountInBaseCurrency).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojShipmentCosts)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentCosts_Shipment");
        });

        modelBuilder.Entity<LojShipmentDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC07CB0E7402");

            entity.ToTable("LOJ_ShipmentDocuments");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(200);
            entity.Property(e => e.DocumentNo).HasMaxLength(100);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojShipmentDocuments)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_ShipmentDocuments_Shipment");
        });

        modelBuilder.Entity<LojShippingRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Ship__3214EC0795520DB5");

            entity.ToTable("LOJ_ShippingRoutes");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BaseCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Distance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RouteCode).HasMaxLength(50);
            entity.Property(e => e.RouteName).HasMaxLength(200);
            entity.Property(e => e.RouteType).HasMaxLength(50);

            entity.HasOne(d => d.DestinationPort).WithMany(p => p.LojShippingRouteDestinationPorts)
                .HasForeignKey(d => d.DestinationPortId)
                .HasConstraintName("FK_LOJ_ShippingRoutes_DestinationPort");

            entity.HasOne(d => d.OriginPort).WithMany(p => p.LojShippingRouteOriginPorts)
                .HasForeignKey(d => d.OriginPortId)
                .HasConstraintName("FK_LOJ_ShippingRoutes_OriginPort");
        });

        modelBuilder.Entity<LojSupplierPerformance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Supp__3214EC07081E2CF3");

            entity.ToTable("LOJ_SupplierPerformances");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.TotalPurchaseValue).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<LojVesselFuelConsumption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Vess__3214EC0732D1829C");

            entity.ToTable("LOJ_VesselFuelConsumptions");

            entity.Property(e => e.Bunkered).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Consumption).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FuelType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OperationMode).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Rob)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ROB");

            entity.HasOne(d => d.Vessel).WithMany(p => p.LojVesselFuelConsumptions)
                .HasForeignKey(d => d.VesselId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VesselFuelConsumptions_Vessel");
        });

        modelBuilder.Entity<LojVoyageProfitability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOJ_Voya__3214EC076509F590");

            entity.ToTable("LOJ_VoyageProfitabilities");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CustomsCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreightCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrossProfit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsuranceCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OtherCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PortCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProfitMargin).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Revenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WarehouseCost).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Shipment).WithMany(p => p.LojVoyageProfitabilities)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOJ_VoyageProfitabilities_Shipment");
        });

        modelBuilder.Entity<MailAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Acc__3214EC070A25091D");

            entity.ToTable("Mail_Accounts");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ClientSecret).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TenantId).HasMaxLength(200);
            entity.Property(e => e.TokenExpiresAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<MailAppConfig>(entity =>
        {
            entity.ToTable("Mail_AppConfig");

            entity.HasIndex(e => e.CompanyId, "IX_Mail_AppConfig_CompanyId");

            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ClientSecret).HasMaxLength(500);
            entity.Property(e => e.TenantId).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.MailAppConfigs).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<MailAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Att__3214EC07A97364B5");

            entity.ToTable("Mail_Attachments");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.GraphAttachmentId).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MailCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Cat__3214EC07CDD48CC3");

            entity.ToTable("Mail_Categories");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.ColorCode).HasMaxLength(20);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MailFolder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Fol__3214EC07691CE791");

            entity.ToTable("Mail_Folders");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.GraphFolderId).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentFolderId).HasMaxLength(250);

            entity.HasOne(d => d.Account).WithMany(p => p.MailFolders)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mail_Fold__Accou__0257F7FE");
        });

        modelBuilder.Entity<MailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Mes__3214EC07EF9797D7");

            entity.ToTable("Mail_Messages");

            entity.HasIndex(e => new { e.AccountId, e.IsDeleted, e.ReceivedDateTime }, "IX_MailMessages_AccountId_IsDeleted_ReceivedDateTime");

            entity.HasIndex(e => new { e.FolderId, e.IsDeleted, e.ReceivedDateTime }, "IX_MailMessages_FolderId_IsDeleted_ReceivedDateTime").IsDescending(false, false, true);

            entity.HasIndex(e => e.GraphMessageId, "IX_Mail_Messages_GraphMessageId")
                .IsUnique()
                .HasFilter("([GraphMessageId] IS NOT NULL)");

            entity.Property(e => e.AssignedTo).HasMaxLength(50);
            entity.Property(e => e.BodyPreview).HasMaxLength(1000);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GraphMessageId).HasMaxLength(250);
            entity.Property(e => e.GraphThreadId).HasMaxLength(250);
            entity.Property(e => e.Importance).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RefModule).HasMaxLength(50);
            entity.Property(e => e.SenderEmail).HasMaxLength(150);
            entity.Property(e => e.SenderName).HasMaxLength(150);
            entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(500);

            entity.HasOne(d => d.Account).WithMany(p => p.MailMessages)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mail_Mess__Accou__0904F58D");

            entity.HasOne(d => d.Folder).WithMany(p => p.MailMessages)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK__Mail_Mess__Folde__09F919C6");
        });

        modelBuilder.Entity<MailMessageCategory>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.CategoryId }).HasName("PK__Mail_Mes__69EC9F3C47285465");

            entity.ToTable("Mail_MessageCategories");

            entity.HasOne(d => d.Category).WithMany(p => p.MailMessageCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mail_Mess__Categ__1D0BEE3A");
        });

        modelBuilder.Entity<MailTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Tra__3214EC0792619064");

            entity.ToTable("Mail_Tracking");

            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RecipientEmail).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
        });

        modelBuilder.Entity<MsgNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("MSG_Notification");

            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<MsgNotificationUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("MSG_NotificationUser");

            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FromUserId).HasMaxLength(450);
            entity.Property(e => e.IsPrivate).HasComputedColumnSql("(CONVERT([bit],case when [ToGroupId] IS NULL then (1) else (0) end))", false);
            entity.Property(e => e.IsRead).HasComputedColumnSql("(CONVERT([bit],case when [ReadDate] IS NOT NULL then (1) else (0) end))", false);
            entity.Property(e => e.ReadDate).HasPrecision(3);
            entity.Property(e => e.ToGroupId).HasMaxLength(450);
            entity.Property(e => e.ToUserId).HasMaxLength(450);
        });

        modelBuilder.Entity<OfferApprovalToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OfferApp__3214EC074A0E8881");

            entity.HasIndex(e => e.Token, "UX_OfferApprovalTokens_Token").IsUnique();

            entity.Property(e => e.ClientIp).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RecipientEmail).HasMaxLength(256);
            entity.Property(e => e.SigneeName).HasMaxLength(150);
            entity.Property(e => e.Token).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UsedDate).HasColumnType("datetime");
            entity.Property(e => e.UserAgent).HasMaxLength(256);

            entity.HasOne(d => d.Offer).WithMany(p => p.OfferApprovalTokens)
                .HasForeignKey(d => d.OfferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OfferApprovalTokens_Offers");
        });

        modelBuilder.Entity<OprProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_Projects");

            entity.ToTable("OPR_Projects");

            entity.HasIndex(e => e.CompanyId, "IX_Opr_Projects_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.ProjectNo }, "IX_Opr_Projects_CompanyId_ProjectNo")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.HasIndex(e => e.PartnerId, "IX_Opr_Projects_PartnerId");

            entity.HasIndex(e => e.Status, "IX_Opr_Projects_Status");

            entity.HasIndex(e => e.WorkflowTemplateId, "IX_Opr_Projects_WorkflowTemplateId");

            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PlannedBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProgressPercent)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.ServiceLocation).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Draft");

            entity.HasOne(d => d.Company).WithMany(p => p.OprProjects)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_Projects_Company");

            entity.HasOne(d => d.WorkflowTemplate).WithMany(p => p.OprProjects)
                .HasForeignKey(d => d.WorkflowTemplateId)
                .HasConstraintName("FK_Opr_Projects_GNL_WorkflowTemplate_WorkflowTemplateId");
        });

        modelBuilder.Entity<OprProjectBudget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ProjectBudgets");

            entity.ToTable("OPR_ProjectBudgets");

            entity.HasIndex(e => e.CompanyId, "IX_Opr_ProjectBudgets_CompanyId");

            entity.HasIndex(e => e.ProjectId, "IX_Opr_ProjectBudgets_ProjectId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LineType)
                .HasMaxLength(20)
                .HasDefaultValue("Plan");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.OprProjectBudgets)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectBudgets_Company");

            entity.HasOne(d => d.Project).WithMany(p => p.OprProjectBudgets)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectBudgets_Project");

            entity.HasOne(d => d.ProjectPhase).WithMany(p => p.OprProjectBudgets)
                .HasForeignKey(d => d.ProjectPhaseId)
                .HasConstraintName("FK_Opr_ProjectBudgets_Phase");
        });

        modelBuilder.Entity<OprProjectDeliverable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ProjectDeliverables");

            entity.ToTable("OPR_ProjectDeliverables");

            entity.HasIndex(e => e.CompanyId, "IX_Opr_ProjectDeliverables_CompanyId");

            entity.HasIndex(e => e.ProjectId, "IX_Opr_ProjectDeliverables_ProjectId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverableType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");

            entity.HasOne(d => d.Company).WithMany(p => p.OprProjectDeliverables)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectDeliverables_Company");

            entity.HasOne(d => d.Project).WithMany(p => p.OprProjectDeliverables)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectDeliverables_Project");

            entity.HasOne(d => d.ProjectPhase).WithMany(p => p.OprProjectDeliverables)
                .HasForeignKey(d => d.ProjectPhaseId)
                .HasConstraintName("FK_Opr_ProjectDeliverables_Phase");
        });

        modelBuilder.Entity<OprProjectPhase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ProjectPhases");

            entity.ToTable("OPR_ProjectPhases");

            entity.HasIndex(e => e.CompanyId, "IX_Opr_ProjectPhases_CompanyId");

            entity.HasIndex(e => e.ProjectId, "IX_Opr_ProjectPhases_ProjectId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Sequence).HasDefaultValue(1);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Draft");

            entity.HasOne(d => d.Company).WithMany(p => p.OprProjectPhases)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectPhases_Company");

            entity.HasOne(d => d.Project).WithMany(p => p.OprProjectPhases)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectPhases_Project");
        });

        modelBuilder.Entity<OprProjectTask>(entity =>
        {
            entity.ToTable("Opr_ProjectTasks");

            entity.Property(e => e.BudgetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ProgressPercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Sequence).HasDefaultValue(1);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Draft");

            entity.HasOne(d => d.ProjectPhase).WithMany(p => p.OprProjectTasks)
                .HasForeignKey(d => d.ProjectPhaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectTasks_Opr_ProjectPhases");
        });

        modelBuilder.Entity<OprProjectTeamMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ProjectTeamMembers");

            entity.ToTable("OPR_ProjectTeamMembers");

            entity.HasIndex(e => e.EmployeeId, "IX_Opr_ProjectTeamMembers_EmployeeId");

            entity.HasIndex(e => e.ProjectId, "IX_Opr_ProjectTeamMembers_ProjectId");

            entity.HasIndex(e => new { e.ProjectId, e.EmployeeId }, "IX_Opr_ProjectTeamMembers_Project_Employee")
                .IsUnique()
                .HasFilter("([IsDeleted]=(0))");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleCode).HasMaxLength(50);
            entity.Property(e => e.RoleName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.OprProjectTeamMembers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectTeamMembers_Company");

            entity.HasOne(d => d.Project).WithMany(p => p.OprProjectTeamMembers)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opr_ProjectTeamMembers_Project");
        });

        modelBuilder.Entity<OprToDo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Opr_ToDo");

            entity.ToTable("OPR_ToDo");

            entity.Property(e => e.AssignedTo).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EtaText).HasMaxLength(50);
            entity.Property(e => e.Imo)
                .HasMaxLength(50)
                .HasColumnName("IMO");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PortCode).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.ReminderDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.VesselId).HasDefaultValue(0);
        });

        modelBuilder.Entity<OprVesselVisit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Opr_Vess__3214EC077992D79D");

            entity.ToTable("OPR_VesselVisits");

            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Imo)
                .HasMaxLength(50)
                .HasColumnName("IMO");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PortCode).HasMaxLength(50);
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorName).HasMaxLength(100);
        });

        modelBuilder.Entity<PdfVisualTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PdfVisua__3214EC07A9145E3F");

            entity.ToTable("PdfVisualTemplate");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdentifierKeywords).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SamplePdfPath).HasMaxLength(500);
            entity.Property(e => e.TemplateName).HasMaxLength(200);
        });

        modelBuilder.Entity<PentestOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_pentest_out");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Msg)
                .HasMaxLength(4000)
                .HasColumnName("msg");
            entity.Property(e => e.Ts)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ts");
        });

        modelBuilder.Entity<ReqDiscountList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__B2B_Disc__3214EC07123D299F");

            entity.ToTable("REQ_DiscountList");

            entity.HasIndex(e => e.Name, "UQ_B2B_DiscountList_Name").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<ReqEmailTracking>(entity =>
        {
            entity.ToTable("REQ_EmailTracking");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FileStatus).HasMaxLength(50);
            entity.Property(e => e.ItemCount).HasMaxLength(50);
            entity.Property(e => e.Receiver).HasMaxLength(100);
            entity.Property(e => e.Requester).HasMaxLength(100);
            entity.Property(e => e.RfqNumber).HasMaxLength(100);
            entity.Property(e => e.VesselName).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.ReqEmailTrackings).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<ReqOffer>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_CRM_Offers")
                .HasFillFactor(85);

            entity.ToTable("REQ_Offers");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ApprovedAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CustomFee).HasDefaultValue(0);
            entity.Property(e => e.DeliveryDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DeliveryLocation).HasMaxLength(250);
            entity.Property(e => e.DeliveryType).HasMaxLength(60);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocumentNo).HasMaxLength(250);
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.DueDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FreightCharge)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.MessageReceived).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.OfferCode).HasMaxLength(20);
            entity.Property(e => e.OfferDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PartnerRefNo).HasMaxLength(50);
            entity.Property(e => e.PaymentTerms).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PortFee).HasDefaultValue(0);
            entity.Property(e => e.PreparedBy).HasMaxLength(150);
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.RfqNo).HasMaxLength(50);
            entity.Property(e => e.ServiceLinked).HasDefaultValue(false);
            entity.Property(e => e.Status).HasMaxLength(400);
            entity.Property(e => e.StatusId).HasDefaultValue(0);
            entity.Property(e => e.SystemAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.ValidityDays).HasDefaultValue(0);
            entity.Property(e => e.VesselName).HasMaxLength(500);
        });

        modelBuilder.Entity<ReqOfferDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_CRM_OfferDetails")
                .HasFillFactor(85);

            entity.ToTable("REQ_OfferDetails");

            entity.HasIndex(e => e.OfferId, "IX_CRM_OfferDetails_OfferId").HasFillFactor(85);

            entity.HasIndex(e => e.StockId, "IX_REQ_OfferDetails_StockId");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.Dsc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSC");
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.OrderNo).HasDefaultValue(0);
            entity.Property(e => e.PrchPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasDefaultValue(0);
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StockId).HasDefaultValue(0);
            entity.Property(e => e.SupplierNote).HasMaxLength(1000);
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.VesselRemark).HasMaxLength(1000);
        });

        modelBuilder.Entity<ReqOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REQ_Orde__3214EC07744FF586");

            entity.ToTable("REQ_Orders");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.CustomFee)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerRefNo).HasMaxLength(50);
            entity.Property(e => e.DeliveryLocation).HasMaxLength(250);
            entity.Property(e => e.DeliveryPeriod).HasMaxLength(50);
            entity.Property(e => e.DeliveryTime).HasMaxLength(100);
            entity.Property(e => e.DeliveryType).HasMaxLength(50);
            entity.Property(e => e.DocumentNo).HasMaxLength(30);
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.InCustomArea).HasDefaultValue(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.OfferId).HasDefaultValue(0);
            entity.Property(e => e.OrderNo).HasMaxLength(100);
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.OutputStoreName).HasMaxLength(100);
            entity.Property(e => e.OutputWarehouseId).HasDefaultValue(0);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PartnerName).HasMaxLength(250);
            entity.Property(e => e.PaymentPlan).HasMaxLength(50);
            entity.Property(e => e.PortFee)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProjectNo).HasMaxLength(100);
            entity.Property(e => e.PurchaseOrderStatus).HasMaxLength(50);
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RfqNo).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasDefaultValue(0);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.Transportation)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.VesselName).HasMaxLength(100);
        });

        modelBuilder.Entity<ReqOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REQ_Orde__3214EC0700A8FA02");

            entity.ToTable("REQ_OrderDetails");

            entity.HasIndex(e => e.StockId, "IX_REQ_OrderDetails_StockId");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.Dsc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSC");
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.Gtipcode)
                .HasMaxLength(50)
                .HasColumnName("GTIPCode");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.OfferDetailId).HasDefaultValue(0);
            entity.Property(e => e.OrderId).HasDefaultValue(0);
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasDefaultValue(0);
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.RowNo).HasDefaultValue(0);
            entity.Property(e => e.StockCode).HasMaxLength(50);
            entity.Property(e => e.StockId).HasDefaultValue(0);
            entity.Property(e => e.StockName).HasMaxLength(250);
            entity.Property(e => e.StockName2).HasMaxLength(250);
            entity.Property(e => e.StoreName).HasMaxLength(100);
            entity.Property(e => e.SupplierNote).HasMaxLength(1000);
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.TurkishDescription).HasMaxLength(500);
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.VesselRemark).HasMaxLength(1000);
            entity.Property(e => e.WarehouseId).HasDefaultValue(0);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ReqOrderDetails).HasForeignKey(d => d.WarehouseId);
        });

        modelBuilder.Entity<ReqPicker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REQ_Picker");

            entity.Property(e => e.ActionDate).HasPrecision(3);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.DeliveryDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DocumentNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsCanceled).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PickerCode).HasMaxLength(50);
            entity.Property(e => e.PickerName).HasMaxLength(50);
            entity.Property(e => e.Pqty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PQty");
            entity.Property(e => e.PreparedBy).HasMaxLength(50);
            entity.Property(e => e.ReadyDate).HasPrecision(3);
            entity.Property(e => e.ReceivedBy).HasMaxLength(150);
            entity.Property(e => e.Rqty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RQty");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Submitter).HasMaxLength(150);
            entity.Property(e => e.VesselName).HasMaxLength(50);
        });

        modelBuilder.Entity<ReqPickerDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_GNL_PickerDetails")
                .HasFillFactor(85);

            entity.ToTable("REQ_PickerDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Fqty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FQty");
            entity.Property(e => e.InOut).HasMaxLength(5);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.PickerId).HasDefaultValue(0);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecieptQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StockName).HasMaxLength(500);
            entity.Property(e => e.StockName2).HasMaxLength(500);
        });

        modelBuilder.Entity<ReqPriceList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PriceLis__3214EC0799D2A708");

            entity.ToTable("REQ_PriceList");

            entity.Property(e => e.Photo).HasMaxLength(500);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StockCode).HasMaxLength(100);
            entity.Property(e => e.StockName).HasMaxLength(300);
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<ReqProforma>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_B2B_Proforma")
                .HasFillFactor(85);

            entity.ToTable("REQ_Proforma");

            entity.HasIndex(e => e.PartnerId, "IX_B2B_Invoices_CompanyId").HasFillFactor(85);

            entity.HasIndex(e => e.PartnerId, "IX_B2B_Invoices_CustomerId").HasFillFactor(85);

            entity.HasIndex(e => e.ShippingId, "IX_B2B_Invoices_ShippingId").HasFillFactor(85);

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AccountCodeOld)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AccountManager).HasMaxLength(250);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Balance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankDetails).HasMaxLength(500);
            entity.Property(e => e.BillingAddress).HasMaxLength(250);
            entity.Property(e => e.Cocompany)
                .HasMaxLength(150)
                .HasColumnName("COCompany");
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CompanyIdFirst).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(20);
            entity.Property(e => e.CustomerStatus).HasMaxLength(20);
            entity.Property(e => e.DeliveryDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DocumentNumber).HasMaxLength(250);
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.DueDate)
                .HasPrecision(3)
                .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.FreightCharge)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GroupPartnerId).HasDefaultValue(0);
            entity.Property(e => e.HesapCode).HasMaxLength(20);
            entity.Property(e => e.InvoiceNo).HasMaxLength(20);
            entity.Property(e => e.InvoiceType).HasDefaultValue(0);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.LocalCode).HasMaxLength(20);
            entity.Property(e => e.MergedDocumentNumber).HasMaxLength(500);
            entity.Property(e => e.MiddleMan).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.OpenOrders).HasMaxLength(50);
            entity.Property(e => e.Paid)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PartnerComment).HasMaxLength(250);
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PartnerRefNo).HasMaxLength(250);
            entity.Property(e => e.PaymentTerms)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PickerStatus).HasMaxLength(20);
            entity.Property(e => e.PreparedBy).HasMaxLength(150);
            entity.Property(e => e.ProformaCode).HasMaxLength(20);
            entity.Property(e => e.ProformaDate)
                .HasPrecision(3)
                .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(30);
            entity.Property(e => e.Purpose).HasMaxLength(50);
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedBy).HasMaxLength(150);
            entity.Property(e => e.RefId).HasMaxLength(50);
            entity.Property(e => e.RefType).HasMaxLength(20);
            entity.Property(e => e.RefUser).HasMaxLength(100);
            entity.Property(e => e.SendType).HasMaxLength(10);
            entity.Property(e => e.Service).HasMaxLength(1000);
            entity.Property(e => e.ShipmentTag).HasMaxLength(10);
            entity.Property(e => e.ShipmentTerms)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingAddress).HasMaxLength(250);
            entity.Property(e => e.ShippingId).HasDefaultValue(0);
            entity.Property(e => e.Side).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Submitter).HasMaxLength(150);
            entity.Property(e => e.TermsConditions).HasMaxLength(1000);
            entity.Property(e => e.TotalBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalVolume)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWeight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrackingNo).HasMaxLength(20);
            entity.Property(e => e.Transportation).HasMaxLength(250);
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.VesselName).HasMaxLength(150);
        });

        modelBuilder.Entity<ReqProformaDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_B2B_ProformaDetails_1")
                .HasFillFactor(85);

            entity.ToTable("REQ_ProformaDetails");

            entity.HasIndex(e => e.ProformaId, "IX_B2B_InvoiceDetails_InvoiceId").HasFillFactor(85);

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Brand).HasMaxLength(250);
            entity.Property(e => e.Catalogue).HasMaxLength(20);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.DrawingNo).HasMaxLength(150);
            entity.Property(e => e.Dsc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSC");
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.Fqty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FQty");
            entity.Property(e => e.FreightCharge)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Grup).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ItemNo).HasMaxLength(50);
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.Locprice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOCPrice");
            entity.Property(e => e.Mdsc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MDSC");
            entity.Property(e => e.Model).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.PartNo).HasMaxLength(500);
            entity.Property(e => e.PickerStatus).HasMaxLength(20);
            entity.Property(e => e.PrchPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProformaId).HasDefaultValue(0);
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StockCode).HasMaxLength(150);
            entity.Property(e => e.StockId).HasDefaultValue(0);
            entity.Property(e => e.StockName).HasMaxLength(1000);
            entity.Property(e => e.StockName2).HasMaxLength(1000);
            entity.Property(e => e.StoreId).HasDefaultValue(0);
            entity.Property(e => e.SupplierCode).HasMaxLength(30);
            entity.Property(e => e.TotalVolume)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWeight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.Unit).HasMaxLength(30);
        });

        modelBuilder.Entity<ReqRequest>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_CRM_Request")
                .HasFillFactor(85);

            entity.ToTable("REQ_Requests");

            entity.Property(e => e.AccountName).HasMaxLength(200);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DocumentNo).HasMaxLength(30);
            entity.Property(e => e.DueDate).HasPrecision(3);
            entity.Property(e => e.ExternalRfqId).HasMaxLength(100);
            entity.Property(e => e.ExternalSystem).HasMaxLength(50);
            entity.Property(e => e.IntegrationStatus).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.MakerType).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.Quality).HasMaxLength(200);
            entity.Property(e => e.RefType).HasMaxLength(30);
            entity.Property(e => e.RequestCode).HasMaxLength(200);
            entity.Property(e => e.RequestDate).HasPrecision(3);
            entity.Property(e => e.RequestNo).HasMaxLength(30);
            entity.Property(e => e.ResponsiblePerson).HasMaxLength(150);
            entity.Property(e => e.RfqNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.VesselRefNo).HasMaxLength(400);
        });

        modelBuilder.Entity<ReqRequestDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_B2B_RequestDetails")
                .HasFillFactor(85);

            entity.ToTable("REQ_RequestDetails");

            entity.HasIndex(e => e.StockId, "IX_REQ_RequestDetails_StockId");

            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Brand).HasMaxLength(250);
            entity.Property(e => e.Catalogue).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.Dsc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSC");
            entity.Property(e => e.Dscamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSCAmount");
            entity.Property(e => e.FreightCharge)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.Model).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Netamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NETAmount");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.Photo).HasMaxLength(500);
            entity.Property(e => e.PurchaseCurrency).HasMaxLength(5);
            entity.Property(e => e.PurchasePrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RequestId).HasDefaultValue(0);
            entity.Property(e => e.Rqty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RQty");
            entity.Property(e => e.SaleCurrency).HasMaxLength(500);
            entity.Property(e => e.SalePrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StockCode).HasMaxLength(50);
            entity.Property(e => e.StockName).HasMaxLength(500);
            entity.Property(e => e.StoreId).HasDefaultValue(0);
            entity.Property(e => e.SupplierGroupName).HasMaxLength(200);
            entity.Property(e => e.TotalVolume)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWeight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ttlamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTLAmount");
            entity.Property(e => e.Unit).HasMaxLength(30);
            entity.Property(e => e.UnitPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ReqRequestItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RequestI__3214EC0789E9A77F");

            entity.ToTable("REQ_RequestItems");

            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Kdvamount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.Kdvrate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("KDVRate");
            entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SupplierNote).HasMaxLength(500);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VesselRemark).HasMaxLength(500);

            entity.HasOne(d => d.Request).WithMany(p => p.ReqRequestItems)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestItems_Request");
        });

        modelBuilder.Entity<ReqRequestSupplierProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REQ_Requ__3214EC07299D6B7B");

            entity.ToTable("REQ_RequestSupplierProducts");

            entity.HasIndex(e => e.StockId, "IX_REQ_RequestSupplierProducts_StockId");

            entity.Property(e => e.AccessToken).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.DeliveryPlace).HasMaxLength(150);
            entity.Property(e => e.DeliveryTime).HasMaxLength(100);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Dsc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsLock).HasDefaultValue(false);
            entity.Property(e => e.IsSelectedForQuote).HasDefaultValue(false);
            entity.Property(e => e.Kdvamount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVAmount");
            entity.Property(e => e.Kdvrate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KDVRate");
            entity.Property(e => e.MailCount).HasDefaultValue(0);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PartnerId).HasDefaultValue(0);
            entity.Property(e => e.PaymentTerms).HasMaxLength(150);
            entity.Property(e => e.PricedItemsQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProfitRate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PurchasePrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RequestId).HasDefaultValue(0);
            entity.Property(e => e.RequestItemsQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupplierAttach).HasMaxLength(250);
            entity.Property(e => e.SupplierCurrency).HasMaxLength(50);
            entity.Property(e => e.SupplierPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ReqRequestSupplierProductFile>(entity =>
        {
            entity.ToTable("REQ_RequestSupplierProductFiles");

            entity.HasIndex(e => e.Category, "IX_RequestSupplierProductFiles_Category").HasFilter("([Category] IS NOT NULL)");

            entity.HasIndex(e => e.RequestDetailId, "IX_RequestSupplierProductFiles_RequestDetailId").HasFilter("([RequestDetailId] IS NOT NULL)");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.FilePath).HasMaxLength(250);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.RequestSupplierProductId).HasDefaultValue(0);
        });

        modelBuilder.Entity<ScmAppointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Appo__3214EC07BA7088EC");

            entity.ToTable("SCM_Appointments");

            entity.HasIndex(e => e.AssetId, "IX_SCM_Appointments_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Appointments_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_Appointments_PartnerId");

            entity.HasIndex(e => e.TechnicianId, "IX_SCM_Appointments_TechnicianId");

            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(250);

            entity.HasOne(d => d.Asset).WithMany(p => p.ScmAppointments)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK__SCM_Appoi__Asset__2FD4A9EB");

            entity.HasOne(d => d.Company).WithMany(p => p.ScmAppointments)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__SCM_Appoi__Compa__2CF83D40");

            entity.HasOne(d => d.Partner).WithMany(p => p.ScmAppointments)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__SCM_Appoi__Partn__2DEC6179");

            entity.HasOne(d => d.Technician).WithMany(p => p.ScmAppointments).HasForeignKey(d => d.TechnicianId);
        });

        modelBuilder.Entity<ScmAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Asse__3214EC0765871704");

            entity.ToTable("SCM_Assets");

            entity.HasIndex(e => e.AssetCategoryId, "IX_SCM_Assets_AssetCategoryId");

            entity.HasIndex(e => e.AssetTypeId, "IX_SCM_Assets_AssetTypeId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Assets_CompanyId");

            entity.HasIndex(e => e.CustomerSiteId, "IX_SCM_Assets_CustomerSiteId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_Assets_PartnerId");

            entity.Property(e => e.AssetCode).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.Criticality).HasMaxLength(20);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.Manufacturer).HasMaxLength(100);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.QrToken).HasMaxLength(100);
            entity.Property(e => e.SerialNumber).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.ScmAssets)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__SCM_Asset__Compa__31BCF25D");
        });

        modelBuilder.Entity<ScmAssetCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Asse__3214EC07CEA6D170");

            entity.ToTable("SCM_AssetCategories");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_AssetCategories_CompanyId");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.ScmAssetCategories)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__SCM_Asset__Compa__30C8CE24");
        });

        modelBuilder.Entity<ScmAssetType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Asse__3214EC074EB8A5C0");

            entity.ToTable("SCM_AssetTypes");

            entity.HasIndex(e => e.CategoryId, "IX_SCM_AssetTypes_CategoryId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_AssetTypes_CompanyId");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmCalibration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cali__3214EC078B8A6ADE");

            entity.ToTable("SCM_Calibrations");

            entity.HasIndex(e => e.AssetId, "IX_SCM_Calibrations_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Calibrations_CompanyId");

            entity.HasIndex(e => e.TechnicianId, "IX_SCM_Calibrations_TechnicianId");

            entity.Property(e => e.CalibrationNo).HasMaxLength(50);
            entity.Property(e => e.CalibrationType).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalConditions).HasMaxLength(200);
            entity.Property(e => e.ReferenceStandard).HasMaxLength(200);
            entity.Property(e => e.Result).HasMaxLength(50);
            entity.Property(e => e.SerialNumber).HasMaxLength(100);
            entity.Property(e => e.Tolerance).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmCalibrationMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cali__3214EC070B62F85F");

            entity.ToTable("SCM_CalibrationMeasurements");

            entity.HasIndex(e => e.CalibrationId, "IX_SCM_CalibrationMeasurements_CalibrationId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CalibrationMeasurements_CompanyId");

            entity.Property(e => e.Deviation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Max).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MeasuredValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Min).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Parameter).HasMaxLength(100);
            entity.Property(e => e.ReferenceValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Result).HasMaxLength(20);
            entity.Property(e => e.Tolerance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmCertificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cert__3214EC0708DED2A3");

            entity.ToTable("SCM_Certificates");

            entity.HasIndex(e => e.AssetId, "IX_SCM_Certificates_AssetId");

            entity.HasIndex(e => e.CalibrationId, "IX_SCM_Certificates_CalibrationId");

            entity.HasIndex(e => e.CertificateTypeId, "IX_SCM_Certificates_CertificateTypeId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Certificates_CompanyId");

            entity.HasIndex(e => e.CustomerSiteId, "IX_SCM_Certificates_CustomerSiteId");

            entity.HasIndex(e => e.InspectionId, "IX_SCM_Certificates_InspectionId");

            entity.HasIndex(e => e.NextCertificateId, "IX_SCM_Certificates_NextCertificateId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_Certificates_PartnerId");

            entity.HasIndex(e => e.PreviousCertificateId, "IX_SCM_Certificates_PreviousCertificateId");

            entity.HasIndex(e => e.ServiceJobId, "IX_SCM_Certificates_ServiceJobId");

            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.CertificateNo).HasMaxLength(50);
            entity.Property(e => e.IssuedBy).HasMaxLength(100);
            entity.Property(e => e.RenewalStatus).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VerificationCode).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmCertificateRenewal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cert__3214EC07C7BF66F0");

            entity.ToTable("SCM_CertificateRenewals");

            entity.HasIndex(e => e.CertificateId, "IX_SCM_CertificateRenewals_CertificateId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CertificateRenewals_CompanyId");

            entity.HasIndex(e => e.ScheduledServiceRequestId, "IX_SCM_CertificateRenewals_ScheduledServiceRequestId");

            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmCertificateType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cert__3214EC074E11F8A0");

            entity.ToTable("SCM_CertificateTypes");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CertificateTypes_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmCertificateVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cert__3214EC076C31E29F");

            entity.ToTable("SCM_CertificateVersions");

            entity.HasIndex(e => e.CertificateId, "IX_SCM_CertificateVersions_CertificateId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CertificateVersions_CompanyId");

            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.DocumentFileName).HasMaxLength(250);
        });

        modelBuilder.Entity<ScmCustomerCommunication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cust__3214EC07AB7B4EFD");

            entity.ToTable("SCM_CustomerCommunications");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CustomerCommunications_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_CustomerCommunications_PartnerId");

            entity.Property(e => e.CommunicationType).HasMaxLength(50);
            entity.Property(e => e.RecordedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmCustomerSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Cust__3214EC0742EF8ED0");

            entity.ToTable("SCM_CustomerSites");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_CustomerSites_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_CustomerSites_PartnerId");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.SiteName).HasMaxLength(150);
        });

        modelBuilder.Entity<ScmInspection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Insp__3214EC0775F4D88B");

            entity.ToTable("SCM_Inspections");

            entity.HasIndex(e => e.AssetId, "IX_SCM_Inspections_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Inspections_CompanyId");

            entity.HasIndex(e => e.InspectorId, "IX_SCM_Inspections_InspectorId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_Inspections_PartnerId");

            entity.HasIndex(e => e.ServiceJobId, "IX_SCM_Inspections_ServiceJobId");

            entity.Property(e => e.InspectionNo).HasMaxLength(50);
            entity.Property(e => e.InspectionType).HasMaxLength(50);
            entity.Property(e => e.Result).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmInspectionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Insp__3214EC07DEBFF440");

            entity.ToTable("SCM_InspectionDetails");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_InspectionDetails_CompanyId");

            entity.HasIndex(e => e.InspectionId, "IX_SCM_InspectionDetails_InspectionId");

            entity.Property(e => e.Parameter).HasMaxLength(250);
            entity.Property(e => e.Result).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmNonConformity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_NonC__3214EC0775FFF847");

            entity.ToTable("SCM_NonConformities");

            entity.HasIndex(e => e.AssetId, "IX_SCM_NonConformities_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_NonConformities_CompanyId");

            entity.HasIndex(e => e.InspectionId, "IX_SCM_NonConformities_InspectionId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_NonConformities_PartnerId");

            entity.Property(e => e.ClosedBy).HasMaxLength(100);
            entity.Property(e => e.Ncrno)
                .HasMaxLength(50)
                .HasColumnName("NCRNo");
            entity.Property(e => e.ResponsiblePerson).HasMaxLength(100);
            entity.Property(e => e.Severity).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Noti__3214EC07DD0081D3");

            entity.ToTable("SCM_Notifications");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Notifications_CompanyId");

            entity.Property(e => e.ActionUrl).HasMaxLength(250);
            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        modelBuilder.Entity<ScmNotificationTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Noti__3214EC07CD7BFC45");

            entity.ToTable("SCM_NotificationTemplates");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_NotificationTemplates_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Subject).HasMaxLength(250);
        });

        modelBuilder.Entity<ScmReminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Remi__3214EC07BE39948D");

            entity.ToTable("SCM_Reminders");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Reminders_CompanyId");

            entity.HasIndex(e => e.RuleId, "IX_SCM_Reminders_RuleId");

            entity.Property(e => e.ResultMessage).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TargetType).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmReminderRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Remi__3214EC073DE31A09");

            entity.ToTable("SCM_ReminderRules");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ReminderRules_CompanyId");

            entity.Property(e => e.NotificationChannel).HasMaxLength(50);
            entity.Property(e => e.RuleName).HasMaxLength(150);
            entity.Property(e => e.TargetType).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmServiceChecklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC0773403A8A");

            entity.ToTable("SCM_ServiceChecklists");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceChecklists_CompanyId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_ServiceChecklists_ServiceTypeId");

            entity.Property(e => e.ChecklistName).HasMaxLength(150);
        });

        modelBuilder.Entity<ScmServiceChecklistItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC0733785468");

            entity.ToTable("SCM_ServiceChecklistItems");

            entity.HasIndex(e => e.ChecklistId, "IX_SCM_ServiceChecklistItems_ChecklistId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceChecklistItems_CompanyId");

            entity.Property(e => e.CheckItem).HasMaxLength(250);
        });

        modelBuilder.Entity<ScmServiceChecklistResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC0753ED3BF0");

            entity.ToTable("SCM_ServiceChecklistResults");

            entity.HasIndex(e => e.CheckItemId, "IX_SCM_ServiceChecklistResults_CheckItemId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceChecklistResults_CompanyId");

            entity.HasIndex(e => e.ServiceJobId, "IX_SCM_ServiceChecklistResults_ServiceJobId");

            entity.Property(e => e.ExpectedValue).HasMaxLength(100);
            entity.Property(e => e.MeasuredValue).HasMaxLength(100);
            entity.Property(e => e.Result).HasMaxLength(20);
            entity.Property(e => e.Tolerance).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmServiceContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07719C0E75");

            entity.ToTable("SCM_ServiceContracts");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceContracts_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_ServiceContracts_PartnerId");

            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.ContractType).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RenewalType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmServiceContractAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC0784A0D8D7");

            entity.ToTable("SCM_ServiceContractAssets");

            entity.HasIndex(e => e.AssetId, "IX_SCM_ServiceContractAssets_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceContractAssets_CompanyId");

            entity.HasIndex(e => e.ContractId, "IX_SCM_ServiceContractAssets_ContractId");
        });

        modelBuilder.Entity<ScmServiceJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07E597B6D0");

            entity.ToTable("SCM_ServiceJobs");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceJobs_CompanyId");

            entity.HasIndex(e => e.ScmWorkOrderId, "IX_SCM_ServiceJobs_ScmWorkOrderId");

            entity.HasIndex(e => e.TechnicianId, "IX_SCM_ServiceJobs_TechnicianId");

            entity.HasIndex(e => e.WorkOrderId, "IX_SCM_ServiceJobs_WorkOrderId");

            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.LaborHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmServiceJobActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC070E66A21E");

            entity.ToTable("SCM_ServiceJobActivities");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceJobActivities_CompanyId");

            entity.HasIndex(e => e.ServiceJobId, "IX_SCM_ServiceJobActivities_ServiceJobId");

            entity.Property(e => e.ActivityName).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmServicePlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07566A06CC");

            entity.ToTable("SCM_ServicePlans");

            entity.HasIndex(e => e.AssetId, "IX_SCM_ServicePlans_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServicePlans_CompanyId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_ServicePlans_ServiceTypeId");

            entity.Property(e => e.PlanName).HasMaxLength(150);
        });

        modelBuilder.Entity<ScmServiceRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07EA119273");

            entity.ToTable("SCM_ServiceRequests");

            entity.HasIndex(e => e.AssetId, "IX_SCM_ServiceRequests_AssetId");

            entity.HasIndex(e => e.AssignedTechnicianId, "IX_SCM_ServiceRequests_AssignedTechnicianId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceRequests_CompanyId");

            entity.HasIndex(e => e.CustomerSiteId, "IX_SCM_ServiceRequests_CustomerSiteId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_ServiceRequests_PartnerId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_ServiceRequests_ServiceTypeId");

            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.CustomerReference).HasMaxLength(100);
            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(100);
            entity.Property(e => e.RequestNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmServiceRequestDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07F1E29880");

            entity.ToTable("SCM_ServiceRequestDetails");

            entity.HasIndex(e => e.AssetId, "IX_SCM_ServiceRequestDetails_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceRequestDetails_CompanyId");

            entity.HasIndex(e => e.ServiceRequestId, "IX_SCM_ServiceRequestDetails_ServiceRequestId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_ServiceRequestDetails_ServiceTypeId");
        });

        modelBuilder.Entity<ScmServiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Serv__3214EC07AFF741EB");

            entity.ToTable("SCM_ServiceTypes");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_ServiceTypes_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmTechnician>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Tech__3214EC07168C3A06");

            entity.ToTable("SCM_Technicians");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_Technicians_CompanyId");

            entity.HasIndex(e => e.PersonelId, "IX_SCM_Technicians_PersonelId");

            entity.Property(e => e.AvailabilityStatus).HasMaxLength(50);
            entity.Property(e => e.EmployeeNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmTechnicianQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Tech__3214EC07E1198FA2");

            entity.ToTable("SCM_TechnicianQualifications");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_TechnicianQualifications_CompanyId");

            entity.HasIndex(e => e.TechnicianId, "IX_SCM_TechnicianQualifications_TechnicianId");

            entity.Property(e => e.CertificateNo).HasMaxLength(100);
            entity.Property(e => e.QualificationName).HasMaxLength(200);
        });

        modelBuilder.Entity<ScmTechnicianSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Tech__3214EC077A3E230D");

            entity.ToTable("SCM_TechnicianSkills");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_TechnicianSkills_CompanyId");

            entity.HasIndex(e => e.TechnicianId, "IX_SCM_TechnicianSkills_TechnicianId");

            entity.Property(e => e.SkillLevel).HasMaxLength(50);
            entity.Property(e => e.SkillName).HasMaxLength(100);
        });

        modelBuilder.Entity<ScmWorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Work__3214EC07B86CB377");

            entity.ToTable("SCM_WorkOrders");

            entity.HasIndex(e => e.AssetId, "IX_SCM_WorkOrders_AssetId");

            entity.HasIndex(e => e.AssignedTechnicianId, "IX_SCM_WorkOrders_AssignedTechnicianId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_WorkOrders_CompanyId");

            entity.HasIndex(e => e.CustomerSiteId, "IX_SCM_WorkOrders_CustomerSiteId");

            entity.HasIndex(e => e.PartnerId, "IX_SCM_WorkOrders_PartnerId");

            entity.HasIndex(e => e.ServiceRequestId, "IX_SCM_WorkOrders_ServiceRequestId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_WorkOrders_ServiceTypeId");

            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.WorkOrderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ScmWorkOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SCM_Work__3214EC0763E02660");

            entity.ToTable("SCM_WorkOrderDetails");

            entity.HasIndex(e => e.AssetId, "IX_SCM_WorkOrderDetails_AssetId");

            entity.HasIndex(e => e.CompanyId, "IX_SCM_WorkOrderDetails_CompanyId");

            entity.HasIndex(e => e.ServiceTypeId, "IX_SCM_WorkOrderDetails_ServiceTypeId");

            entity.HasIndex(e => e.WorkOrderId, "IX_SCM_WorkOrderDetails_WorkOrderId");
        });

        modelBuilder.Entity<SrvServiceCatalog>(entity =>
        {
            entity.ToTable("SRV_ServiceCatalog");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_ServiceCatalog_CompanyId");

            entity.HasIndex(e => e.ServiceCategoryId, "IX_SRV_ServiceCatalog_ServiceCategoryId");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EstimatedDurationHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SlatemplateId).HasColumnName("SLATemplateId");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ServiceCategory).WithMany(p => p.SrvServiceCatalogs)
                .HasForeignKey(d => d.ServiceCategoryId)
                .HasConstraintName("FK_SRV_ServiceCatalog_Category");

            entity.HasOne(d => d.Slatemplate).WithMany(p => p.SrvServiceCatalogs)
                .HasForeignKey(d => d.SlatemplateId)
                .HasConstraintName("FK_SRV_ServiceCatalog_SLATemplate");
        });

        modelBuilder.Entity<SrvServiceCategory>(entity =>
        {
            entity.ToTable("SRV_ServiceCategories");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_ServiceCategories_CompanyId");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SrvServiceContract>(entity =>
        {
            entity.ToTable("SRV_ServiceContracts");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_ServiceContracts_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SRV_ServiceContracts_PartnerId");

            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.ContractValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<SrvServiceRequest>(entity =>
        {
            entity.ToTable("SRV_ServiceRequests");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_ServiceRequests_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SRV_ServiceRequests_PartnerId");

            entity.HasIndex(e => e.Status, "IX_SRV_ServiceRequests_Status");

            entity.Property(e => e.AssignedTo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.ResolutionDate).HasColumnType("datetime");
            entity.Property(e => e.ResponseDate).HasColumnType("datetime");
            entity.Property(e => e.SlatemplateId).HasColumnName("SLATemplateId");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.TicketNo).HasMaxLength(50);

            entity.HasOne(d => d.ServiceCatalog).WithMany(p => p.SrvServiceRequests)
                .HasForeignKey(d => d.ServiceCatalogId)
                .HasConstraintName("FK_SRV_ServiceRequests_Catalog");

            entity.HasOne(d => d.ServiceContract).WithMany(p => p.SrvServiceRequests)
                .HasForeignKey(d => d.ServiceContractId)
                .HasConstraintName("FK_SRV_ServiceRequests_Contract");
        });

        modelBuilder.Entity<SrvServiceVisit>(entity =>
        {
            entity.ToTable("SRV_ServiceVisits");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_ServiceVisits_CompanyId");

            entity.HasIndex(e => e.PartnerId, "IX_SRV_ServiceVisits_PartnerId");

            entity.HasIndex(e => e.Status, "IX_SRV_ServiceVisits_Status");

            entity.Property(e => e.AssignedTo).HasMaxLength(100);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PlannedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.VisitNo).HasMaxLength(50);
        });

        modelBuilder.Entity<SrvSlatemplate>(entity =>
        {
            entity.ToTable("SRV_SLATemplates");

            entity.HasIndex(e => e.CompanyId, "IX_SRV_SLATemplates_CompanyId");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PriorityLevel).HasMaxLength(20);
            entity.Property(e => e.ResolutionTimeHours).HasDefaultValue(24);
            entity.Property(e => e.ResponseTimeMinutes).HasDefaultValue(60);
        });

        modelBuilder.Entity<SysObjectChecksum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYS_Object_Checksum");

            entity.Property(e => e.Checksum).HasColumnName("checksum");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.Db)
                .HasMaxLength(128)
                .HasColumnName("db");
            entity.Property(e => e.Def1).HasColumnName("def1");
            entity.Property(e => e.Def2)
                .IsUnicode(false)
                .HasColumnName("def2");
            entity.Property(e => e.Definition)
                .IsUnicode(false)
                .HasColumnName("definition");
            entity.Property(e => e.Object)
                .HasMaxLength(128)
                .HasColumnName("object");
            entity.Property(e => e.Parent)
                .HasMaxLength(128)
                .HasColumnName("parent");
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS_KS_WS")
                .HasColumnName("type");
            entity.Property(e => e.TypeDesc)
                .HasMaxLength(66)
                .UseCollation("Latin1_General_CI_AS_KS_WS")
                .HasColumnName("type_desc");
        });

        modelBuilder.Entity<SysParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("SYS_Params");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.CreatedOn)
                .HasPrecision(3)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);
            entity.Property(e => e.ValueType).HasMaxLength(255);
        });

        modelBuilder.Entity<TelegramMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(85);

            entity.ToTable("TelegramMessage");

            entity.Property(e => e.BotToken)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ErrMsg).IsUnicode(false);
            entity.Property(e => e.Group)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Message)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Response)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.SentOn).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCatchError>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CatchError");

            entity.Property(e => e.ErrMsg).HasMaxLength(4000);
            entity.Property(e => e.ErrProc).HasMaxLength(128);
            entity.Property(e => e.FullErrMsg).IsUnicode(false);
        });

        modelBuilder.Entity<VFirstLastDayOfMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_FirstLastDayOfMonth");

            entity.Property(e => e.First).HasColumnType("datetime");
            entity.Property(e => e.Last).HasColumnType("datetime");
        });

        modelBuilder.Entity<VInvoiceAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Invoice_All");

            entity.Property(e => e.AccountCode).HasMaxLength(20);
            entity.Property(e => e.AccountManager).HasMaxLength(250);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.BillingAddress).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Currency).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DocumentNumber).HasMaxLength(250);
            entity.Property(e => e.Dscamount).HasColumnName("DSCAmount");
            entity.Property(e => e.DueDate).HasPrecision(3);
            entity.Property(e => e.InvoiceCode).HasMaxLength(20);
            entity.Property(e => e.InvoiceDate).HasPrecision(3);
            entity.Property(e => e.InvoiceNo).HasMaxLength(20);
            entity.Property(e => e.InvoiceOrigin)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Kdvamount).HasColumnName("KDVAmount");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasPrecision(3);
            entity.Property(e => e.Netamount).HasColumnName("NETAmount");
            entity.Property(e => e.PartnerRefNo).HasMaxLength(50);
            entity.Property(e => e.PreparedBy).HasMaxLength(150);
            entity.Property(e => e.SendType).HasMaxLength(10);
            entity.Property(e => e.ShipmentTag).HasMaxLength(10);
            entity.Property(e => e.ShippingAddress).HasMaxLength(500);
            entity.Property(e => e.Side).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Transportation).HasMaxLength(250);
            entity.Property(e => e.Ttlamount).HasColumnName("TTLAmount");
            entity.Property(e => e.VesselName).HasMaxLength(50);
        });

        modelBuilder.Entity<VNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Notification");

            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.FromUserName).HasMaxLength(256);
            entity.Property(e => e.ReadDate).HasPrecision(3);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.ToUserId).HasMaxLength(450);
            entity.Property(e => e.ToUserName).HasMaxLength(256);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<VPurOffer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Pur_Offer");

            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.PstockCode)
                .HasMaxLength(255)
                .HasColumnName("PStockCode");
            entity.Property(e => e.PstockName)
                .HasMaxLength(255)
                .HasColumnName("PStockName");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<VPurOfferCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Pur_OfferCount");
        });

        modelBuilder.Entity<VPurRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Pur_Request");

            entity.Property(e => e.DetailStatus).HasMaxLength(20);
            entity.Property(e => e.DocumentNumber).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StockCode).HasMaxLength(250);
            entity.Property(e => e.StockName).HasMaxLength(250);
        });

        modelBuilder.Entity<VResource>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Resources");

            entity.Property(e => e.En).HasColumnName("en");
            entity.Property(e => e.Ge).HasColumnName("ge");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Tr).HasColumnName("tr");
        });

        modelBuilder.Entity<VStockBrand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Stock_Brand");

            entity.Property(e => e.ApriceAvg).HasColumnName("APrice_AVG");
            entity.Property(e => e.ApriceMax).HasColumnName("APrice_MAX");
            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.Currency).HasMaxLength(5);
            entity.Property(e => e.ItemNo).HasMaxLength(100);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.PartNo).HasMaxLength(100);
            entity.Property(e => e.SpriceAvg).HasColumnName("SPrice_AVG");
            entity.Property(e => e.SpriceMax).HasColumnName("SPrice_MAX");
            entity.Property(e => e.StockCode).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

