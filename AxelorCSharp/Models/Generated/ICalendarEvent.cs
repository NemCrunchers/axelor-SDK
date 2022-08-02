using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ICalendarEvent")]
	public class ICalendarEvent : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("subject")]
		public string? Subject;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("geo")]
		public string? Geo;

		[Field("allDay")]
		public bool? AllDay;

		[Field("archived")]
		public bool? Archived;

		[Field("uid")]
		public string? Uid;

		[Field("visibilitySelect")]
		public int? VisibilitySelect;

		[Field("id")]
		public long? Id;

		[Field("calendar")]
		public Axelor.Apps.Base.Db.ICalendar? Calendar;

		[Field("subjectTeam")]
		public string? SubjectTeam;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("disponibilitySelect")]
		public int? DisponibilitySelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("endDateTime")]
		public DateTime? EndDateTime;

		[Field("version")]
		public int? Version;

		[Field("url")]
		public string? Url;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("startDateTime")]
		public DateTime? StartDateTime;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("organizer")]
		public Axelor.Apps.Base.Db.ICalendarUser? Organizer;

		[Field("location")]
		public string? Location;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("status")]
		public string? Status;

	}
}
