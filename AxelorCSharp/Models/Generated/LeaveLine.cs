using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LeaveLine")]
	public class LeaveLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("quantity")]
		[Field("quantity", false, "0", Int32.MaxValue)]
		public decimal? Quantity;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("daysToValidate")]
		[Field("daysToValidate", false, "0", Int32.MaxValue)]
		public decimal? DaysToValidate;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

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

		[JsonProperty("totalQuantity")]
		[Field("totalQuantity", false, "0", Int32.MaxValue)]
		public decimal? TotalQuantity;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("leaveReason")]
		[Field("leaveReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.LeaveReason? LeaveReason;

		[JsonProperty("daysValidated")]
		[Field("daysValidated", false, "0", Int32.MaxValue)]
		public decimal? DaysValidated;

		[JsonProperty("leaveManagementList")]
		[Field("leaveManagementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LeaveManagement>? LeaveManagementList;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
