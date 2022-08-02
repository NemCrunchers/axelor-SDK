using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.LeaveRequest")]
	public class LeaveRequest : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("injectConsumeSelect")]
		public int? InjectConsumeSelect;

		[Field("leaveLine")]
		public Axelor.Apps.Hr.Db.LeaveLine? LeaveLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("endOnSelect")]
		public int? EndOnSelect;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("refusedBy")]
		public Axelor.Auth.Db.User? RefusedBy;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("toJustifyLeaveReason")]
		public bool? ToJustifyLeaveReason;

		[Field("startOnSelect")]
		public int? StartOnSelect;

		[Field("validatedBy")]
		public Axelor.Auth.Db.User? ValidatedBy;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("icalendarEvent")]
		public Axelor.Apps.Base.Db.ICalendarEvent? IcalendarEvent;

	}
}
