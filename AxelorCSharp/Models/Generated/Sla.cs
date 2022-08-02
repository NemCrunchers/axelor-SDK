using Axelor.SDK;

namespace Axelor.Apps.Helpdesk.Db
{
	[Model("com.axelor.apps.helpdesk.db.Sla")]
	public class Sla : AxelorModel
	{
		[Field("hours")]
		public int? Hours;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("ticketType")]
		public Axelor.Apps.Helpdesk.Db.TicketType? TicketType;

		[Field("prioritySelect")]
		public int? PrioritySelect;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("reachStageSelect")]
		public int? ReachStageSelect;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("days")]
		public int? Days;

		[Field("id")]
		public long? Id;

		[Field("isWorkingDays")]
		public bool? IsWorkingDays;

	}
}
