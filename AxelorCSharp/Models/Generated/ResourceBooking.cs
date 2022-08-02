using Axelor.SDK;

namespace Axelor.Apps.Project.Db
{
	[Model("com.axelor.apps.project.db.ResourceBooking")]
	public class ResourceBooking : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("resource")]
		public Axelor.Apps.Project.Db.Resource? Resource;

		[Field("toDate")]
		public DateTime? ToDate;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("updateTaskFromPeriod")]
		public bool? UpdateTaskFromPeriod;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("fromDate")]
		public DateTime? FromDate;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("task")]
		public Axelor.Team.Db.TeamTask? Task;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
