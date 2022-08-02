using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.EventsPlanningLine")]
	public class EventsPlanningLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("year")]
		public int? Year;

		[Field("description")]
		public string? Description;

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

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("eventsPlanning")]
		public Axelor.Apps.Base.Db.EventsPlanning? EventsPlanning;

		[Field("id")]
		public long? Id;

	}
}
