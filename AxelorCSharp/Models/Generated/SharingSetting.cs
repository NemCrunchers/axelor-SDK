using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.SharingSetting")]
	public class SharingSetting : AxelorModel
	{
		[Field("calendar")]
		public Axelor.Apps.Base.Db.ICalendar? Calendar;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("visible")]
		public bool? Visible;

		[Field("rightsSelect")]
		public int? RightsSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("sharedWith")]
		public Axelor.Auth.Db.User? SharedWith;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
