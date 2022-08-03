using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.EmploymentContract")]
	public class EmploymentContract : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("monthlyGlobalCost")]
		[Field("monthlyGlobalCost", false, "0", Int32.MaxValue)]
		public decimal? MonthlyGlobalCost;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("contractType")]
		[Field("contractType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmploymentContractType? ContractType;

		[JsonProperty("employmentContractVersion")]
		[Field("employmentContractVersion", false, "0", Int32.MaxValue)]
		public int? EmploymentContractVersion;

		[JsonProperty("otherCostsEmployeeSet")]
		[Field("otherCostsEmployeeSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.OtherCostsEmployee>? OtherCostsEmployeeSet;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("employmentContractTemplate")]
		[Field("employmentContractTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmploymentContractTemplate? EmploymentContractTemplate;

		[JsonProperty("hoursDistribution")]
		[Field("hoursDistribution", false, null, Int32.MaxValue)]
		public string? HoursDistribution;

		[JsonProperty("duration")]
		[Field("duration", false, null, Int32.MaxValue)]
		public string? Duration;

		[JsonProperty("endContractDetails")]
		[Field("endContractDetails", false, null, Int32.MaxValue)]
		public string? EndContractDetails;

		[JsonProperty("endOfContractReason")]
		[Field("endOfContractReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EndOfContractReason? EndOfContractReason;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("minMonthlyRemuneration")]
		[Field("minMonthlyRemuneration", false, "0", Int32.MaxValue)]
		public decimal? MinMonthlyRemuneration;

		[JsonProperty("amendmentTypeSelect")]
		[Field("amendmentTypeSelect", false, "0", Int32.MaxValue)]
		public int? AmendmentTypeSelect;

		[JsonProperty("annualGrossSalary")]
		[Field("annualGrossSalary", false, "0", Int32.MaxValue)]
		public decimal? AnnualGrossSalary;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("executiveStatusSelect")]
		[Field("executiveStatusSelect", false, "0", Int32.MaxValue)]
		public int? ExecutiveStatusSelect;

		[JsonProperty("weeklyDuration")]
		[Field("weeklyDuration", false, "0", Int32.MaxValue)]
		public decimal? WeeklyDuration;

		[JsonProperty("amendmentDate")]
		[Field("amendmentDate", false, null, Int32.MaxValue)]
		public DateTime? AmendmentDate;

		[JsonProperty("trialPeriodDuration")]
		[Field("trialPeriodDuration", false, null, Int32.MaxValue)]
		public string? TrialPeriodDuration;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("hourlyGrossSalary")]
		[Field("hourlyGrossSalary", false, "0", Int32.MaxValue)]
		public decimal? HourlyGrossSalary;

		[JsonProperty("payCompany")]
		[Field("payCompany", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? PayCompany;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("employment")]
		[Field("employment", false, null, Int32.MaxValue)]
		public string? Employment;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("signatureDate")]
		[Field("signatureDate", false, null, Int32.MaxValue)]
		public DateTime? SignatureDate;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("coefficient")]
		[Field("coefficient", false, null, Int32.MaxValue)]
		public string? Coefficient;

		[JsonProperty("companyDepartment")]
		[Field("companyDepartment", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CompanyDepartment? CompanyDepartment;

		[JsonProperty("position")]
		[Field("position", false, null, Int32.MaxValue)]
		public string? Position;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

		[JsonProperty("status")]
		[Field("status", false, "0", Int32.MaxValue)]
		public int? Status;

	}
}
