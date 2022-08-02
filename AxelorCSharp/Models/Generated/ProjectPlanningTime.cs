using Axelor.SDK;

namespace Axelor.Apps.Project.Db
{
	[Model("com.axelor.apps.project.db.ProjectPlanningTime")]
	public class ProjectPlanningTime : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("isIncludeInTurnoverForecast")]
		public bool? IsIncludeInTurnoverForecast;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("task")]
		public Axelor.Team.Db.TeamTask? Task;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("timepercent")]
		public int? Timepercent;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
