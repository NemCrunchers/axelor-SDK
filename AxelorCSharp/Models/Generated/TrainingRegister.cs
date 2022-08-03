using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Talent.Db
{
	[Serializable]
	[Model("com.axelor.apps.talent.db.TrainingRegister")]
	public class TrainingRegister : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toDate")]
		[Field("toDate", true, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("training")]
		[Field("training", true, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.Training? Training;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("employee")]
		[Field("employee", true, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", true, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
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

		[JsonProperty("ratingSelect")]
		[Field("ratingSelect", false, "0", Int32.MaxValue)]
		public int? RatingSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("trainingSession")]
		[Field("trainingSession", false, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.TrainingSession? TrainingSession;

	}
}
