using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Talent.Db
{
	[Serializable]
	[Model("com.axelor.apps.talent.db.JobPosition")]
	public class JobPosition : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("contractType")]
		[Field("contractType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmploymentContractType? ContractType;

		[JsonProperty("jobTitle")]
		[Field("jobTitle", true, null, Int32.MaxValue)]
		public string? JobTitle;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("salary")]
		[Field("salary", false, null, Int32.MaxValue)]
		public string? Salary;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("nbPeopleHired")]
		[Field("nbPeopleHired", false, "0", Int32.MaxValue)]
		public int? NbPeopleHired;

		[JsonProperty("publicationDate")]
		[Field("publicationDate", false, null, Int32.MaxValue)]
		public DateTime? PublicationDate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("mailAccount")]
		[Field("mailAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAccount? MailAccount;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("jobReference")]
		[Field("jobReference", false, null, Int32.MaxValue)]
		public string? JobReference;

		[JsonProperty("positionStatusSelect")]
		[Field("positionStatusSelect", false, null, Int32.MaxValue)]
		public string? PositionStatusSelect;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("nbOpenJob")]
		[Field("nbOpenJob", false, "0", Int32.MaxValue)]
		public int? NbOpenJob;

		[JsonProperty("companyDepartment")]
		[Field("companyDepartment", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CompanyDepartment? CompanyDepartment;

		[JsonProperty("profileWanted")]
		[Field("profileWanted", false, null, Int32.MaxValue)]
		public string? ProfileWanted;

		[JsonProperty("jobDescription")]
		[Field("jobDescription", false, null, Int32.MaxValue)]
		public string? JobDescription;

		[JsonProperty("location")]
		[Field("location", false, null, Int32.MaxValue)]
		public string? Location;

		[JsonProperty("startingDate")]
		[Field("startingDate", false, null, Int32.MaxValue)]
		public DateTime? StartingDate;

		[JsonProperty("experienceSelect")]
		[Field("experienceSelect", false, "0", Int32.MaxValue)]
		public int? ExperienceSelect;

	}
}
