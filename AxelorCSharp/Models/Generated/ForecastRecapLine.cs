using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Cash.Management.Db
{
	[Serializable]
	[Model("com.axelor.apps.cash.management.db.ForecastRecapLine")]
	public class ForecastRecapLine : AxelorModel
	{
		[JsonProperty("amount")]
		[Field("amount", false, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("forecastReason")]
		[Field("forecastReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Cash.Management.Db.ForecastReason? ForecastReason;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("forecastRecap")]
		[Field("forecastRecap", false, null, Int32.MaxValue)]
		public Axelor.Apps.Cash.Management.Db.ForecastRecap? ForecastRecap;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("estimatedDate")]
		[Field("estimatedDate", false, null, Int32.MaxValue)]
		public DateTime? EstimatedDate;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

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

		[JsonProperty("balance")]
		[Field("balance", false, "0", Int32.MaxValue)]
		public decimal? Balance;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
