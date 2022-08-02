using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.WkfTrackingTime")]
	public class WkfTrackingTime : AxelorModel
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

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("wkfTracking")]
		public Axelor.Studio.Db.WkfTracking? WkfTracking;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("status")]
		public string? Status;

	}
}
