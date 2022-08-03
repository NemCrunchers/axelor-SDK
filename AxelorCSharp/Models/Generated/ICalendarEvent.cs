using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.ICalendarEvent")]
	public class ICalendarEvent : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("subject")]
		[Field("subject", true, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("computedAttendeeList")]
		[Field("computedAttendeeList", false, null, Int32.MaxValue)]
		public string? ComputedAttendeeList;

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

		[JsonProperty("visibilitySelect")]
		[Field("visibilitySelect", false, "1", Int32.MaxValue)]
		public int? VisibilitySelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("calendar")]
		[Field("calendar", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendar? Calendar;

		[JsonProperty("subjectTeam")]
		[Field("subjectTeam", false, null, Int32.MaxValue)]
		public string? SubjectTeam;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("attendees")]
		[Field("attendees", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ICalendarUser>? Attendees;

		[JsonProperty("disponibilitySelect")]
		[Field("disponibilitySelect", false, "1", Int32.MaxValue)]
		public int? DisponibilitySelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("endDateTime")]
		[Field("endDateTime", true, null, Int32.MaxValue)]
		public DateTime? EndDateTime;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("url")]
		[Field("url", false, null, Int32.MaxValue)]
		public string? Url;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("startDateTime")]
		[Field("startDateTime", true, null, Int32.MaxValue)]
		public DateTime? StartDateTime;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("organizer")]
		[Field("organizer", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendarUser? Organizer;

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
