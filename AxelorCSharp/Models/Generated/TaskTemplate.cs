using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Project.Db
{
	[Serializable]
	[Model("com.axelor.apps.project.db.TaskTemplate")]
	public class TaskTemplate : AxelorModel
	{
		[JsonProperty("taskTemplateList")]
		[Field("taskTemplateList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.TaskTemplate>? TaskTemplateList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("parentTaskTemplate")]
		[Field("parentTaskTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.TaskTemplate? ParentTaskTemplate;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("totalPlannedHrs")]
		[Field("totalPlannedHrs", false, "0", Int32.MaxValue)]
		public decimal? TotalPlannedHrs;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("assignedTo")]
		[Field("assignedTo", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? AssignedTo;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isUniqueTaskForMultipleQuantity")]
		[Field("isUniqueTaskForMultipleQuantity", false, "False", Int32.MaxValue)]
		public bool? IsUniqueTaskForMultipleQuantity;

		[JsonProperty("delayToStart")]
		[Field("delayToStart", false, "0", Int32.MaxValue)]
		public decimal? DelayToStart;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
