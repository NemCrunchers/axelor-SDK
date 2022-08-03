using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Talent.Db
{
	[Serializable]
	[Model("com.axelor.apps.talent.db.JobApplication")]
	public class JobApplication : AxelorModel
	{
		[JsonProperty("lastName")]
		[Field("lastName", false, null, Int32.MaxValue)]
		public string? LastName;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("availabilityFrom")]
		[Field("availabilityFrom", false, null, Int32.MaxValue)]
		public DateTime? AvailabilityFrom;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("reasonNotHired")]
		[Field("reasonNotHired", false, null, Int32.MaxValue)]
		public string? ReasonNotHired;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("talentSource")]
		[Field("talentSource", false, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.TalentSource? TalentSource;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("titleSelect")]
		[Field("titleSelect", false, "0", Int32.MaxValue)]
		public int? TitleSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("emailAddress")]
		[Field("emailAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAddress? EmailAddress;

		[JsonProperty("educationLevel")]
		[Field("educationLevel", false, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.EducationLevel? EducationLevel;

		[JsonProperty("responsible")]
		[Field("responsible", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[JsonProperty("hiringStage")]
		[Field("hiringStage", false, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.HiringStage? HiringStage;

		[JsonProperty("expectedSalary")]
		[Field("expectedSalary", false, null, Int32.MaxValue)]
		public string? ExpectedSalary;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fax")]
		[Field("fax", false, null, Int32.MaxValue)]
		public string? Fax;

		[JsonProperty("skillSet")]
		[Field("skillSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("linkedInProfile")]
		[Field("linkedInProfile", false, null, Int32.MaxValue)]
		public string? LinkedInProfile;

		[JsonProperty("appreciation")]
		[Field("appreciation", false, "0", Int32.MaxValue)]
		public int? Appreciation;

		[JsonProperty("fixedPhone")]
		[Field("fixedPhone", false, null, Int32.MaxValue)]
		public string? FixedPhone;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("creationDate")]
		[Field("creationDate", false, null, Int32.MaxValue)]
		public DateTime? CreationDate;

		[JsonProperty("employeeAddress")]
		[Field("employeeAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? EmployeeAddress;

		[JsonProperty("proposedSalary")]
		[Field("proposedSalary", false, null, Int32.MaxValue)]
		public string? ProposedSalary;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("picture")]
		[Field("picture", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Picture;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("jobPosition")]
		[Field("jobPosition", true, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.JobPosition? JobPosition;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("firstName")]
		[Field("firstName", false, null, Int32.MaxValue)]
		public string? FirstName;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("mobilePhone")]
		[Field("mobilePhone", false, null, Int32.MaxValue)]
		public string? MobilePhone;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("industrySectorSet")]
		[Field("industrySectorSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.IndustrySector>? IndustrySectorSet;

		[JsonProperty("referredBy")]
		[Field("referredBy", false, null, Int32.MaxValue)]
		public string? ReferredBy;

		[JsonProperty("experienceSelect")]
		[Field("experienceSelect", false, "0", Int32.MaxValue)]
		public int? ExperienceSelect;

	}
}
