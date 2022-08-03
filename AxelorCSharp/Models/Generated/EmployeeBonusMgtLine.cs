using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.EmployeeBonusMgtLine")]
	public class EmployeeBonusMgtLine : AxelorModel
	{
		[JsonProperty("amount")]
		[Field("amount", false, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("coef")]
		[Field("coef", false, "0", Int32.MaxValue)]
		public decimal? Coef;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("payrollPreparation")]
		[Field("payrollPreparation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("weeklyPlanning")]
		[Field("weeklyPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("employeeBonusMgt")]
		[Field("employeeBonusMgt", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmployeeBonusMgt? EmployeeBonusMgt;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("seniorityDate")]
		[Field("seniorityDate", false, null, Int32.MaxValue)]
		public DateTime? SeniorityDate;

	}
}
