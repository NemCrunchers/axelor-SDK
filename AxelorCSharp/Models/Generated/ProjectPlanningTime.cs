using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Project.Db
{
	[Serializable]
	[Model("com.axelor.apps.project.db.ProjectPlanningTime")]
	public class ProjectPlanningTime : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", true, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("project")]
		[Field("project", true, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isIncludeInTurnoverForecast")]
		[Field("isIncludeInTurnoverForecast", false, "False", Int32.MaxValue)]
		public bool? IsIncludeInTurnoverForecast;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("realHours")]
		[Field("realHours", false, "0", Int32.MaxValue)]
		public decimal? RealHours;

		[JsonProperty("task")]
		[Field("task", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.TeamTask? Task;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("timepercent")]
		[Field("timepercent", false, "0", Int32.MaxValue)]
		public int? Timepercent;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("user")]
		[Field("user", true, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("plannedHours")]
		[Field("plannedHours", false, "0", Int32.MaxValue)]
		public decimal? PlannedHours;

	}
}
