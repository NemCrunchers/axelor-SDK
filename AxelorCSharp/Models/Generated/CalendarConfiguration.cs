using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.CalendarConfiguration")]
	public class CalendarConfiguration : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("role")]
		[Field("role", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.Role? Role;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaAction")]
		[Field("metaAction", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaAction? MetaAction;

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

		[JsonProperty("calendarGroup")]
		[Field("calendarGroup", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.Group? CalendarGroup;

		[JsonProperty("calendarUser")]
		[Field("calendarUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CalendarUser;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("calendarSet")]
		[Field("calendarSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ICalendar>? CalendarSet;

		[JsonProperty("parentMetaMenu")]
		[Field("parentMetaMenu", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? ParentMetaMenu;

	}
}
