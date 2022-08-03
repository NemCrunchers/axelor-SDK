using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LeaveReason")]
	public class LeaveReason : AxelorModel
	{
		[JsonProperty("payrollPreprationExport")]
		[Field("payrollPreprationExport", false, "False", Int32.MaxValue)]
		public bool? PayrollPreprationExport;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("allowInjection")]
		[Field("allowInjection", false, "False", Int32.MaxValue)]
		public bool? AllowInjection;

		[JsonProperty("defaultDayNumberGain")]
		[Field("defaultDayNumberGain", false, "0", Int32.MaxValue)]
		public decimal? DefaultDayNumberGain;

		[JsonProperty("selectedByMgtOnly")]
		[Field("selectedByMgtOnly", false, "False", Int32.MaxValue)]
		public bool? SelectedByMgtOnly;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("manageAccumulation")]
		[Field("manageAccumulation", false, "False", Int32.MaxValue)]
		public bool? ManageAccumulation;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("exportCode")]
		[Field("exportCode", false, null, Int32.MaxValue)]
		public string? ExportCode;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("instruction")]
		[Field("instruction", false, null, Int32.MaxValue)]
		public string? Instruction;

		[JsonProperty("leaveReason")]
		[Field("leaveReason", true, null, Int32.MaxValue)]
		public string? LeaveReasonField;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("allowNegativeValue")]
		[Field("allowNegativeValue", false, "False", Int32.MaxValue)]
		public bool? AllowNegativeValue;

	}
}
