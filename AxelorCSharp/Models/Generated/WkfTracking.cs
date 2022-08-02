using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.WkfTracking")]
	public class WkfTracking : AxelorModel
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

		[Field("recordId")]
		public long? RecordId;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("wkf")]
		public Axelor.Studio.Db.Wkf? Wkf;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("recordName")]
		public string? RecordName;

		[Field("id")]
		public long? Id;

		[Field("recordModel")]
		public string? RecordModel;

	}
}
