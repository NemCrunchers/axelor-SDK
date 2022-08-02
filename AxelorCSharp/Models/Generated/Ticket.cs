using Axelor.SDK;

namespace Axelor.Apps.Helpdesk.Db
{
	[Model("com.axelor.apps.helpdesk.db.Ticket")]
	public class Ticket : AxelorModel
	{
		[Field("assignedToUser")]
		public Axelor.Auth.Db.User? AssignedToUser;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("isSlaCompleted")]
		public bool? IsSlaCompleted;

		[Field("subject")]
		public string? Subject;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("duration")]
		public long? Duration;

		[Field("archived")]
		public bool? Archived;

		[Field("mailSubject")]
		public string? MailSubject;

		[Field("startDateT")]
		public DateTime? StartDateT;

		[Field("timerState")]
		public bool? TimerState;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("id")]
		public long? Id;

		[Field("progressSelect")]
		public int? ProgressSelect;

		[Field("endDateT")]
		public DateTime? EndDateT;

		[Field("responsibleUser")]
		public Axelor.Auth.Db.User? ResponsibleUser;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("deadlineDateT")]
		public DateTime? DeadlineDateT;

		[Field("ticketType")]
		public Axelor.Apps.Helpdesk.Db.TicketType? TicketType;

		[Field("prioritySelect")]
		public int? PrioritySelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("lead")]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("slaPolicy")]
		public Axelor.Apps.Helpdesk.Db.Sla? SlaPolicy;

		[Field("ticketSeq")]
		public string? TicketSeq;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("customer")]
		public Axelor.Apps.Base.Db.Partner? Customer;

	}
}
