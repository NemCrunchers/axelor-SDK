using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.KilometricAllowanceRule")]
	public class KilometricAllowanceRule : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("minimumCondition")]
		[Field("minimumCondition", false, "0", Int32.MaxValue)]
		public decimal? MinimumCondition;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("maximumCondition")]
		[Field("maximumCondition", false, "0", Int32.MaxValue)]
		public decimal? MaximumCondition;

		[JsonProperty("hrConfig")]
		[Field("hrConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.HRConfig? HrConfig;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("rate")]
		[Field("rate", true, "0", Int32.MaxValue)]
		public decimal? Rate;

		[JsonProperty("kilometricAllowanceRate")]
		[Field("kilometricAllowanceRate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.KilometricAllowanceRate? KilometricAllowanceRate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
