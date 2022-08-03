using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.EmployeeAdvanceUsage")]
	public class EmployeeAdvanceUsage : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("usedAmount")]
		[Field("usedAmount", false, "0", Int32.MaxValue)]
		public decimal? UsedAmount;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("expense")]
		[Field("expense", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Expense? Expense;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("employeeAdvance")]
		[Field("employeeAdvance", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmployeeAdvance? EmployeeAdvance;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
