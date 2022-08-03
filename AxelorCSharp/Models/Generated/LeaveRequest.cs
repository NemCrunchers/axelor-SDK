using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LeaveRequest")]
	public class LeaveRequest : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("injectConsumeSelect")]
		[Field("injectConsumeSelect", false, "1", Int32.MaxValue)]
		public int? InjectConsumeSelect;

		[JsonProperty("quantityBeforeValidation")]
		[Field("quantityBeforeValidation", false, "0", Int32.MaxValue)]
		public decimal? QuantityBeforeValidation;

		[JsonProperty("leaveLine")]
		[Field("leaveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.LeaveLine? LeaveLine;

		[JsonProperty("validationDate")]
		[Field("validationDate", false, null, Int32.MaxValue)]
		public DateTime? ValidationDate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("requestDate")]
		[Field("requestDate", false, null, Int32.MaxValue)]
		public DateTime? RequestDate;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("endOnSelect")]
		[Field("endOnSelect", true, "2", Int32.MaxValue)]
		public int? EndOnSelect;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("refusalDate")]
		[Field("refusalDate", false, null, Int32.MaxValue)]
		public DateTime? RefusalDate;

		[JsonProperty("groundForRefusal")]
		[Field("groundForRefusal", false, null, Int32.MaxValue)]
		public string? GroundForRefusal;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", true, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("refusedBy")]
		[Field("refusedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? RefusedBy;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("toJustifyLeaveReason")]
		[Field("toJustifyLeaveReason", false, "False", Int32.MaxValue)]
		public bool? ToJustifyLeaveReason;

		[JsonProperty("startOnSelect")]
		[Field("startOnSelect", true, "1", Int32.MaxValue)]
		public int? StartOnSelect;

		[JsonProperty("validatedBy")]
		[Field("validatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedBy;

		[JsonProperty("user")]
		[Field("user", true, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("icalendarEvent")]
		[Field("icalendarEvent", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendarEvent? IcalendarEvent;

	}
}
