using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.CalendarConfiguration")]
	public class CalendarConfiguration : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("role")]
		public Axelor.Auth.Db.Role? Role;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaAction")]
		public Axelor.Meta.Db.MetaAction? MetaAction;

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

		[Field("calendarGroup")]
		public Axelor.Auth.Db.Group? CalendarGroup;

		[Field("calendarUser")]
		public Axelor.Auth.Db.User? CalendarUser;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("calendarSet")]
		public IEnumerable<Axelor.Apps.Base.Db.ICalendar>? CalendarSet;

		[Field("parentMetaMenu")]
		public Axelor.Meta.Db.MetaMenu? ParentMetaMenu;

	}
}
