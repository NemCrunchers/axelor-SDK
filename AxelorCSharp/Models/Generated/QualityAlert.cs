using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Quality.Db
{
	[Serializable]
	[Model("com.axelor.apps.quality.db.QualityAlert")]
	public class QualityAlert : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("correctiveActions")]
		[Field("correctiveActions", false, null, Int32.MaxValue)]
		public string? CorrectiveActions;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("responsible")]
		[Field("responsible", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[JsonProperty("rootCause")]
		[Field("rootCause", false, null, Int32.MaxValue)]
		public Axelor.Apps.Quality.Db.RootCause? RootCause;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("deadLineDate")]
		[Field("deadLineDate", false, null, Int32.MaxValue)]
		public DateTime? DeadLineDate;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "0", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("team")]
		[Field("team", true, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("preventiveActions")]
		[Field("preventiveActions", false, null, Int32.MaxValue)]
		public string? PreventiveActions;

		[JsonProperty("workCenter")]
		[Field("workCenter", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("qualityTagSet")]
		[Field("qualityTagSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Quality.Db.QualityTag>? QualityTagSet;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
