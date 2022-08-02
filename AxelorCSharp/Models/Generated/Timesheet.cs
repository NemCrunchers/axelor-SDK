using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.Timesheet")]
	public class Timesheet : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("timeLoggingPreferenceSelect")]
		public string? TimeLoggingPreferenceSelect;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("showEditor")]
		public bool? ShowEditor;

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

		[Field("validatedBy")]
		public Axelor.Auth.Db.User? ValidatedBy;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
