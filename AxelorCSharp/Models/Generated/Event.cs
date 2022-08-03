using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.Event")]
	public class Event : AxelorModel
	{
		[JsonProperty("calendarEventUid")]
		[Field("calendarEventUid", false, null, Int32.MaxValue)]
		public string? CalendarEventUid;

		[JsonProperty("eventReminderList")]
		[Field("eventReminderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.EventReminder>? EventReminderList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("eventCategory")]
		[Field("eventCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.EventCategory? EventCategory;

		[JsonProperty("parentEvent")]
		[Field("parentEvent", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Event? ParentEvent;

		[JsonProperty("subject")]
		[Field("subject", true, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("recurrenceConfiguration")]
		[Field("recurrenceConfiguration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.RecurrenceConfiguration? RecurrenceConfiguration;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("computedAttendeeList")]
		[Field("computedAttendeeList", false, null, Int32.MaxValue)]
		public string? ComputedAttendeeList;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public long? Duration;

		[JsonProperty("geo")]
		[Field("geo", false, null, Int32.MaxValue)]
		public string? Geo;

		[JsonProperty("allDay")]
		[Field("allDay", false, "False", Int32.MaxValue)]
		public bool? AllDay;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("uid")]
		[Field("uid", false, null, Int32.MaxValue)]
		public string? Uid;

		[JsonProperty("callTypeSelect")]
		[Field("callTypeSelect", false, "0", Int32.MaxValue)]
		public int? CallTypeSelect;

		[JsonProperty("limitDateT")]
		[Field("limitDateT", false, null, Int32.MaxValue)]
		public DateTime? LimitDateT;

		[JsonProperty("visibilitySelect")]
		[Field("visibilitySelect", false, "1", Int32.MaxValue)]
		public int? VisibilitySelect;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("relatedToSelect")]
		[Field("relatedToSelect", false, null, Int32.MaxValue)]
		public string? RelatedToSelect;

		[JsonProperty("calendar")]
		[Field("calendar", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendar? Calendar;

		[JsonProperty("relatedToSelectId")]
		[Field("relatedToSelectId", false, "0", Int32.MaxValue)]
		public long? RelatedToSelectId;

		[JsonProperty("subjectTeam")]
		[Field("subjectTeam", false, null, Int32.MaxValue)]
		public string? SubjectTeam;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isRecurrent")]
		[Field("isRecurrent", false, "False", Int32.MaxValue)]
		public bool? IsRecurrent;

		[JsonProperty("attendees")]
		[Field("attendees", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ICalendarUser>? Attendees;

		[JsonProperty("disponibilitySelect")]
		[Field("disponibilitySelect", false, "1", Int32.MaxValue)]
		public int? DisponibilitySelect;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "2", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("endDateTime")]
		[Field("endDateTime", true, null, Int32.MaxValue)]
		public DateTime? EndDateTime;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("lead")]
		[Field("lead", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[JsonProperty("url")]
		[Field("url", false, null, Int32.MaxValue)]
		public string? Url;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("startDateTime")]
		[Field("startDateTime", true, null, Int32.MaxValue)]
		public DateTime? StartDateTime;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("organizer")]
		[Field("organizer", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendarUser? Organizer;

		[JsonProperty("campaign")]
		[Field("campaign", false, null, Int32.MaxValue)]
		public Axelor.Apps.Marketing.Db.Campaign? Campaign;

		[JsonProperty("location")]
		[Field("location", false, null, Int32.MaxValue)]
		public string? Location;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("status")]
		[Field("status", false, null, Int32.MaxValue)]
		public string? Status;

	}
}
