using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.WkfTracking")]
	public class WkfTracking : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("wkfTrackingLines")]
		[Field("wkfTrackingLines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTrackingLine>? WkfTrackingLines;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("totalTimeLines")]
		[Field("totalTimeLines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTrackingTime>? TotalTimeLines;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("recordId")]
		[Field("recordId", true, "0", Int32.MaxValue)]
		public long? RecordId;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("wkf")]
		[Field("wkf", true, null, Int32.MaxValue)]
		public Axelor.Studio.Db.Wkf? Wkf;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("recordName")]
		[Field("recordName", false, null, Int32.MaxValue)]
		public string? RecordName;

		[JsonProperty("totalLines")]
		[Field("totalLines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTrackingTotal>? TotalLines;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("recordModel")]
		[Field("recordModel", true, null, Int32.MaxValue)]
		public string? RecordModel;

	}
}
