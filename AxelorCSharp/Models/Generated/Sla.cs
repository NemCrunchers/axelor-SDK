using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Helpdesk.Db
{
	[Serializable]
	[Model("com.axelor.apps.helpdesk.db.Sla")]
	public class Sla : AxelorModel
	{
		[JsonProperty("hours")]
		[Field("hours", false, "0", Int32.MaxValue)]
		public int? Hours;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("ticketType")]
		[Field("ticketType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Helpdesk.Db.TicketType? TicketType;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "2", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("reachStageSelect")]
		[Field("reachStageSelect", false, "0", Int32.MaxValue)]
		public int? ReachStageSelect;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("days")]
		[Field("days", false, "0", Int32.MaxValue)]
		public int? Days;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isWorkingDays")]
		[Field("isWorkingDays", false, "False", Int32.MaxValue)]
		public bool? IsWorkingDays;

	}
}
