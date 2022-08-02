using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.PayrollLeave")]
	public class PayrollLeave : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("payrollPreparation")]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("leaveRequest")]
		public Axelor.Apps.Hr.Db.LeaveRequest? LeaveRequest;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("leaveReason")]
		public Axelor.Apps.Hr.Db.LeaveReason? LeaveReason;

		[Field("id")]
		public long? Id;

	}
}
