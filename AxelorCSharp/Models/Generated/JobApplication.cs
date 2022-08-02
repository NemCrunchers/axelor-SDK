using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.JobApplication")]
	public class JobApplication : AxelorModel
	{
		[Field("lastName")]
		public string? LastName;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("talentSource")]
		public Axelor.Apps.Talent.Db.TalentSource? TalentSource;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("titleSelect")]
		public int? TitleSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("educationLevel")]
		public Axelor.Apps.Talent.Db.EducationLevel? EducationLevel;

		[Field("responsible")]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[Field("hiringStage")]
		public Axelor.Apps.Talent.Db.HiringStage? HiringStage;

		[Field("expectedSalary")]
		public string? ExpectedSalary;

		[Field("id")]
		public long? Id;

		[Field("fax")]
		public string? Fax;

		[Field("skillSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("linkedInProfile")]
		public string? LinkedInProfile;

		[Field("appreciation")]
		public int? Appreciation;

		[Field("fixedPhone")]
		public string? FixedPhone;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("employeeAddress")]
		public Axelor.Apps.Base.Db.Address? EmployeeAddress;

		[Field("proposedSalary")]
		public string? ProposedSalary;

		[Field("version")]
		public int? Version;

		[Field("picture")]
		public Axelor.Meta.Db.MetaFile? Picture;

		[Field("attrs")]
		public string? Attrs;

		[Field("jobPosition")]
		public Axelor.Apps.Talent.Db.JobPosition? JobPosition;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("firstName")]
		public string? FirstName;

		[Field("importId")]
		public string? ImportId;

		[Field("mobilePhone")]
		public string? MobilePhone;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("industrySectorSet")]
		public IEnumerable<Axelor.Apps.Base.Db.IndustrySector>? IndustrySectorSet;

		[Field("referredBy")]
		public string? ReferredBy;

		[Field("experienceSelect")]
		public int? ExperienceSelect;

	}
}
