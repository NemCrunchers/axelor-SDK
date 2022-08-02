using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmploymentContract")]
	public class EmploymentContract : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("contractType")]
		public Axelor.Apps.Hr.Db.EmploymentContractType? ContractType;

		[Field("employmentContractVersion")]
		public int? EmploymentContractVersion;

		[Field("otherCostsEmployeeSet")]
		public IEnumerable<Axelor.Apps.Hr.Db.OtherCostsEmployee>? OtherCostsEmployeeSet;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("employmentContractTemplate")]
		public Axelor.Apps.Hr.Db.EmploymentContractTemplate? EmploymentContractTemplate;

		[Field("duration")]
		public string? Duration;

		[Field("endContractDetails")]
		public string? EndContractDetails;

		[Field("endOfContractReason")]
		public Axelor.Apps.Hr.Db.EndOfContractReason? EndOfContractReason;

		[Field("archived")]
		public bool? Archived;

		[Field("amendmentTypeSelect")]
		public int? AmendmentTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("executiveStatusSelect")]
		public int? ExecutiveStatusSelect;

		[Field("trialPeriodDuration")]
		public string? TrialPeriodDuration;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("payCompany")]
		public Axelor.Apps.Base.Db.Company? PayCompany;

		[Field("fullName")]
		public string? FullName;

		[Field("employment")]
		public string? Employment;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("coefficient")]
		public string? Coefficient;

		[Field("companyDepartment")]
		public Axelor.Apps.Base.Db.CompanyDepartment? CompanyDepartment;

		[Field("position")]
		public string? Position;

		[Field("status")]
		public int? Status;

	}
}
