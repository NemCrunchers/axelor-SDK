using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.TSTimer")]
	public class TSTimer : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("timesheetLine")]
		public Axelor.Apps.Hr.Db.TimesheetLine? TimesheetLine;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("timerStartDateT")]
		public DateTime? TimerStartDateT;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("duration")]
		public long? Duration;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("startDateTime")]
		public DateTime? StartDateTime;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
