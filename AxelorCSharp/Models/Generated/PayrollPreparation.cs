using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.PayrollPreparation")]
	public class PayrollPreparation : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("exportTypeSelect")]
		[Field("exportTypeSelect", false, "0", Int32.MaxValue)]
		public int? ExportTypeSelect;

		[JsonProperty("employmentContract")]
		[Field("employmentContract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmploymentContract? EmploymentContract;

		[JsonProperty("lunchVoucherMgtLineList")]
		[Field("lunchVoucherMgtLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LunchVoucherMgtLine>? LunchVoucherMgtLineList;

		[JsonProperty("otherCostsEmployeeSet")]
		[Field("otherCostsEmployeeSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.OtherCostsEmployee>? OtherCostsEmployeeSet;

		[JsonProperty("employee")]
		[Field("employee", true, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("expenseAmount")]
		[Field("expenseAmount", false, "0", Int32.MaxValue)]
		public decimal? ExpenseAmount;

		[JsonProperty("total")]
		[Field("total", false, "0", Int32.MaxValue)]
		public decimal? Total;

		[JsonProperty("employeeBonusAmount")]
		[Field("employeeBonusAmount", false, "0", Int32.MaxValue)]
		public decimal? EmployeeBonusAmount;

		[JsonProperty("employeeBonusMgtLineList")]
		[Field("employeeBonusMgtLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.EmployeeBonusMgtLine>? EmployeeBonusMgtLineList;

		[JsonProperty("leaveDuration")]
		[Field("leaveDuration", false, "0", Int32.MaxValue)]
		public decimal? LeaveDuration;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("annualGrossSalary")]
		[Field("annualGrossSalary", false, "0", Int32.MaxValue)]
		public decimal? AnnualGrossSalary;

		[JsonProperty("expenseList")]
		[Field("expenseList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.Expense>? ExpenseList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("batchList")]
		[Field("batchList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[JsonProperty("exported")]
		[Field("exported", false, "False", Int32.MaxValue)]
		public bool? Exported;

		[JsonProperty("period")]
		[Field("period", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("lunchVoucherNumber")]
		[Field("lunchVoucherNumber", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherNumber;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("extraHoursNumber")]
		[Field("extraHoursNumber", false, "0", Int32.MaxValue)]
		public decimal? ExtraHoursNumber;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("exportDate")]
		[Field("exportDate", false, null, Int32.MaxValue)]
		public DateTime? ExportDate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("socialCharges")]
		[Field("socialCharges", false, "0", Int32.MaxValue)]
		public decimal? SocialCharges;

		[JsonProperty("netSalary")]
		[Field("netSalary", false, "0", Int32.MaxValue)]
		public decimal? NetSalary;

		[JsonProperty("extraHoursLineList")]
		[Field("extraHoursLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.ExtraHoursLine>? ExtraHoursLineList;

	}
}
