using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.EventAttendee")]
	public class EventAttendee : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("lead")]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("id")]
		public long? Id;

		[Field("event")]
		public Axelor.Apps.Crm.Db.Event? Event;

	}
}
