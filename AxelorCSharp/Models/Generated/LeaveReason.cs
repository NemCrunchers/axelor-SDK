using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.LeaveReason")]
	public class LeaveReason : AxelorModel
	{
		[Field("payrollPreprationExport")]
		public bool? PayrollPreprationExport;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("allowInjection")]
		public bool? AllowInjection;

		[Field("selectedByMgtOnly")]
		public bool? SelectedByMgtOnly;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("manageAccumulation")]
		public bool? ManageAccumulation;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("exportCode")]
		public string? ExportCode;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("leaveReason")]
		public string? LeaveReasonField;

		[Field("id")]
		public long? Id;

		[Field("allowNegativeValue")]
		public bool? AllowNegativeValue;

	}
}
