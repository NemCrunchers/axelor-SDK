using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.JobPosition")]
	public class JobPosition : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("contractType")]
		public Axelor.Apps.Hr.Db.EmploymentContractType? ContractType;

		[Field("jobTitle")]
		public string? JobTitle;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("salary")]
		public string? Salary;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("nbPeopleHired")]
		public int? NbPeopleHired;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("mailAccount")]
		public Axelor.Apps.Message.Db.EmailAccount? MailAccount;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("jobReference")]
		public string? JobReference;

		[Field("positionStatusSelect")]
		public string? PositionStatusSelect;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("nbOpenJob")]
		public int? NbOpenJob;

		[Field("companyDepartment")]
		public Axelor.Apps.Base.Db.CompanyDepartment? CompanyDepartment;

		[Field("profileWanted")]
		public string? ProfileWanted;

		[Field("location")]
		public string? Location;

		[Field("experienceSelect")]
		public int? ExperienceSelect;

	}
}
