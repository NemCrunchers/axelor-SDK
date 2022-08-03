using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Talent.Db
{
	[Serializable]
	[Model("com.axelor.apps.talent.db.TrainingSession")]
	public class TrainingSession : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("nbrRegistered")]
		[Field("nbrRegistered", false, "0", Int32.MaxValue)]
		public int? NbrRegistered;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toDate")]
		[Field("toDate", true, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("rating")]
		[Field("rating", false, "0", Int32.MaxValue)]
		public decimal? Rating;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("training")]
		[Field("training", true, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.Training? Training;

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

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("fromDate")]
		[Field("fromDate", true, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("location")]
		[Field("location", false, null, Int32.MaxValue)]
		public string? Location;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
