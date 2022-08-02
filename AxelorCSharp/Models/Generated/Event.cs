using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.Event")]
	public class Event : AxelorModel
	{
		[Field("calendarEventUid")]
		public string? CalendarEventUid;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("eventCategory")]
		public Axelor.Apps.Crm.Db.EventCategory? EventCategory;

		[Field("parentEvent")]
		public Axelor.Apps.Crm.Db.Event? ParentEvent;

		[Field("subject")]
		public string? Subject;

		[Field("recurrenceConfiguration")]
		public Axelor.Apps.Crm.Db.RecurrenceConfiguration? RecurrenceConfiguration;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("duration")]
		public long? Duration;

		[Field("geo")]
		public string? Geo;

		[Field("allDay")]
		public bool? AllDay;

		[Field("archived")]
		public bool? Archived;

		[Field("uid")]
		public string? Uid;

		[Field("callTypeSelect")]
		public int? CallTypeSelect;

		[Field("limitDateT")]
		public DateTime? LimitDateT;

		[Field("visibilitySelect")]
		public int? VisibilitySelect;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("id")]
		public long? Id;

		[Field("relatedToSelect")]
		public string? RelatedToSelect;

		[Field("calendar")]
		public Axelor.Apps.Base.Db.ICalendar? Calendar;

		[Field("relatedToSelectId")]
		public long? RelatedToSelectId;

		[Field("subjectTeam")]
		public string? SubjectTeam;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRecurrent")]
		public bool? IsRecurrent;

		[Field("disponibilitySelect")]
		public int? DisponibilitySelect;

		[Field("prioritySelect")]
		public int? PrioritySelect;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("endDateTime")]
		public DateTime? EndDateTime;

		[Field("version")]
		public int? Version;

		[Field("lead")]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[Field("url")]
		public string? Url;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("startDateTime")]
		public DateTime? StartDateTime;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("organizer")]
		public Axelor.Apps.Base.Db.ICalendarUser? Organizer;

		[Field("campaign")]
		public Axelor.Apps.Marketing.Db.Campaign? Campaign;

		[Field("location")]
		public string? Location;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("status")]
		public string? Status;

	}
}
