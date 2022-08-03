using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Team.Db
{
	[Serializable]
	[Model("com.axelor.team.db.TeamTask")]
	public class TeamTask : AxelorModel
	{
		[JsonProperty("toInvoice")]
		[Field("toInvoice", false, "False", Int32.MaxValue)]
		public bool? ToInvoice;

		[JsonProperty("relatedName")]
		[Field("relatedName", false, null, Int32.MaxValue)]
		public string? RelatedName;

		[JsonProperty("discountAmount")]
		[Field("discountAmount", false, "0", Int32.MaxValue)]
		public decimal? DiscountAmount;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("relatedModel")]
		[Field("relatedModel", false, null, Int32.MaxValue)]
		public string? RelatedModel;

		[JsonProperty("projectCategory")]
		[Field("projectCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.ProjectCategory? ProjectCategory;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("progressSelect")]
		[Field("progressSelect", false, "0", Int32.MaxValue)]
		public int? ProgressSelect;

		[JsonProperty("unitPrice")]
		[Field("unitPrice", false, "0", Int32.MaxValue)]
		public decimal? UnitPrice;

		[JsonProperty("plannedProgress")]
		[Field("plannedProgress", false, "0", Int32.MaxValue)]
		public decimal? PlannedProgress;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("parentTask")]
		[Field("parentTask", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.TeamTask? ParentTask;

		[JsonProperty("projectPlanningTimeList")]
		[Field("projectPlanningTimeList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectPlanningTime>? ProjectPlanningTimeList;

		[JsonProperty("timerList")]
		[Field("timerList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Timer>? TimerList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, null, Int32.MaxValue)]
		public string? Priority;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("relatedId")]
		[Field("relatedId", false, "0", Int32.MaxValue)]
		public long? RelatedId;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("totalRealHrs")]
		[Field("totalRealHrs", false, "0", Int32.MaxValue)]
		public decimal? TotalRealHrs;

		[JsonProperty("status")]
		[Field("status", false, null, Int32.MaxValue)]
		public string? Status;

		[JsonProperty("durationHours")]
		[Field("durationHours", false, "0", Int32.MaxValue)]
		public decimal? DurationHours;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("discountTypeSelect")]
		[Field("discountTypeSelect", false, "3", Int32.MaxValue)]
		public int? DiscountTypeSelect;

		[JsonProperty("assignedTo")]
		[Field("assignedTo", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? AssignedTo;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("taskEndDate")]
		[Field("taskEndDate", false, null, Int32.MaxValue)]
		public DateTime? TaskEndDate;

		[JsonProperty("taskDate")]
		[Field("taskDate", false, null, Int32.MaxValue)]
		public DateTime? TaskDate;

		[JsonProperty("teamTaskList")]
		[Field("teamTaskList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.TeamTask>? TeamTaskList;

		[JsonProperty("finishToStartSet")]
		[Field("finishToStartSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.TeamTask>? FinishToStartSet;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("membersUserSet")]
		[Field("membersUserSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? MembersUserSet;

		[JsonProperty("quantity")]
		[Field("quantity", false, "0", Int32.MaxValue)]
		public decimal? Quantity;

		[JsonProperty("taskDeadline")]
		[Field("taskDeadline", false, null, Int32.MaxValue)]
		public DateTime? TaskDeadline;

		[JsonProperty("taskDuration")]
		[Field("taskDuration", false, "0", Int32.MaxValue)]
		public int? TaskDuration;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("totalPlannedHrs")]
		[Field("totalPlannedHrs", false, "0", Int32.MaxValue)]
		public decimal? TotalPlannedHrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("priceDiscounted")]
		[Field("priceDiscounted", false, "0", Int32.MaxValue)]
		public decimal? PriceDiscounted;

	}
}
