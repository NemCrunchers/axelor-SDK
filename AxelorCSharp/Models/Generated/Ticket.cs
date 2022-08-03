using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Helpdesk.Db
{
	[Serializable]
	[Model("com.axelor.apps.helpdesk.db.Ticket")]
	public class Ticket : AxelorModel
	{
		[JsonProperty("assignedToUser")]
		[Field("assignedToUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? AssignedToUser;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("isSlaCompleted")]
		[Field("isSlaCompleted", false, "False", Int32.MaxValue)]
		public bool? IsSlaCompleted;

		[JsonProperty("subject")]
		[Field("subject", true, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public long? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("mailSubject")]
		[Field("mailSubject", false, null, Int32.MaxValue)]
		public string? MailSubject;

		[JsonProperty("startDateT")]
		[Field("startDateT", false, null, Int32.MaxValue)]
		public DateTime? StartDateT;

		[JsonProperty("timerState")]
		[Field("timerState", false, "False", Int32.MaxValue)]
		public bool? TimerState;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("progressSelect")]
		[Field("progressSelect", false, "0", Int32.MaxValue)]
		public int? ProgressSelect;

		[JsonProperty("endDateT")]
		[Field("endDateT", false, null, Int32.MaxValue)]
		public DateTime? EndDateT;

		[JsonProperty("responsibleUser")]
		[Field("responsibleUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ResponsibleUser;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("realTotalDuration")]
		[Field("realTotalDuration", false, "0", Int32.MaxValue)]
		public decimal? RealTotalDuration;

		[JsonProperty("deadlineDateT")]
		[Field("deadlineDateT", false, null, Int32.MaxValue)]
		public DateTime? DeadlineDateT;

		[JsonProperty("ticketType")]
		[Field("ticketType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Helpdesk.Db.TicketType? TicketType;

		[JsonProperty("timerList")]
		[Field("timerList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Timer>? TimerList;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "2", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("lead")]
		[Field("lead", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("slaPolicy")]
		[Field("slaPolicy", false, null, Int32.MaxValue)]
		public Axelor.Apps.Helpdesk.Db.Sla? SlaPolicy;

		[JsonProperty("ticketSeq")]
		[Field("ticketSeq", false, null, Int32.MaxValue)]
		public string? TicketSeq;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("customer")]
		[Field("customer", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Customer;

	}
}
