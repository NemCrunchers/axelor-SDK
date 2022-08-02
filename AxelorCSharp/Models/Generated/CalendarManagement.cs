using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.CalendarManagement")]
	public class CalendarManagement : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("allCalendars")]
		public bool? AllCalendars;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("erpCalendars")]
		public bool? ErpCalendars;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("icalCalendars")]
		public bool? IcalCalendars;

		[Field("id")]
		public long? Id;

		[Field("calendarSet")]
		public IEnumerable<Axelor.Apps.Base.Db.ICalendar>? CalendarSet;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("parentUser")]
		public Axelor.Auth.Db.User? ParentUser;

	}
}
