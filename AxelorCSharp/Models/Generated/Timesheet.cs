using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.Timesheet")]
	public class Timesheet : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("validationDate")]
		[Field("validationDate", false, null, Int32.MaxValue)]
		public DateTime? ValidationDate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sentDate")]
		[Field("sentDate", false, null, Int32.MaxValue)]
		public DateTime? SentDate;

		[JsonProperty("timeLoggingPreferenceSelect")]
		[Field("timeLoggingPreferenceSelect", false, null, Int32.MaxValue)]
		public string? TimeLoggingPreferenceSelect;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("timesheetLineList")]
		[Field("timesheetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? TimesheetLineList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("refusalDate")]
		[Field("refusalDate", false, null, Int32.MaxValue)]
		public DateTime? RefusalDate;

		[JsonProperty("showEditor")]
		[Field("showEditor", false, "False", Int32.MaxValue)]
		public bool? ShowEditor;

		[JsonProperty("groundForRefusal")]
		[Field("groundForRefusal", false, null, Int32.MaxValue)]
		public string? GroundForRefusal;

		[JsonProperty("periodTotal")]
		[Field("periodTotal", false, "0", Int32.MaxValue)]
		public decimal? PeriodTotal;

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
		[Field("fromDate", false, null, Int32.MaxValue)]
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

		[JsonProperty("validatedBy")]
		[Field("validatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedBy;

		[JsonProperty("user")]
		[Field("user", true, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
