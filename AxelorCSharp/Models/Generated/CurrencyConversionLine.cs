using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.CurrencyConversionLine")]
	public class CurrencyConversionLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("endCurrency")]
		[Field("endCurrency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? EndCurrency;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("startCurrency")]
		[Field("startCurrency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? StartCurrency;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("exchangeRate")]
		[Field("exchangeRate", false, "0", Int32.MaxValue)]
		public decimal? ExchangeRate;

		[JsonProperty("appBase")]
		[Field("appBase", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.AppBase? AppBase;

		[JsonProperty("variations")]
		[Field("variations", false, null, Int32.MaxValue)]
		public string? Variations;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
