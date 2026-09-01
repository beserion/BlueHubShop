using System;
using System.Collections.Generic;

namespace BlueHubShop.Domain.Entities;

public partial class HrEmployee
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? EmployeeCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? NameSurname { get; set; }

    public string? TckimlikNo { get; set; }

    public string? PassportNo { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public int? Gender { get; set; }

    public int? MaritalStatus { get; set; }

    public int? MilitaryStatus { get; set; }

    public string? Nationality { get; set; }

    public int? BloodType { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? PersonalEmail { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? PostalCode { get; set; }

    public string? EmergencyContact { get; set; }

    public string? EmergencyPhone { get; set; }

    public string? EmergencyRelation { get; set; }

    public DateOnly? HireDate { get; set; }

    public DateOnly? TerminationDate { get; set; }

    public string? TerminationReason { get; set; }

    public int? EmploymentStatus { get; set; }

    public int? EmploymentType { get; set; }

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public int? ManagerId { get; set; }

    public int? BranchId { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? Iban { get; set; }

    public string? Sgkno { get; set; }

    public int? EducationLevel { get; set; }

    public string? University { get; set; }

    public string? EducationDepartment { get; set; }

    public int? GraduationYear { get; set; }

    public string? PhotoPath { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public int? SalaryGradeId { get; set; }

    public virtual GnlCompany? Company { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrPosition? Position { get; set; }

    public virtual ICollection<ScmAppointment> ScmAppointments { get; set; } = new List<ScmAppointment>();
}
