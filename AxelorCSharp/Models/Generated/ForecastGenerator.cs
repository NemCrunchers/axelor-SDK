using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Cash.Management.Db
{
	[Serializable]
	[Model("com.axelor.apps.cash.management.db.ForecastGenerator")]
	public class ForecastGenerator : AxelorModel
	{
		[JsonProperty("amount")]
		[Field("amount", false, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("forecastReason")]
		[Field("forecastReason", true, null, Int32.MaxValue)]
		public Axelor.Apps.Cash.Management.Db.ForecastReason? ForecastReason;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("forecastList")]
		[Field("forecastList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Cash.Management.Db.Forecast>? ForecastList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toDate")]
		[Field("toDate", true, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("periodicitySelect")]
		[Field("periodicitySelect", false, "1", Int32.MaxValue)]
		public int? PeriodicitySelect;

		[JsonProperty("realizedSelect")]
		[Field("realizedSelect", false, "2", Int32.MaxValue)]
		public int? RealizedSelect;

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

		[JsonProperty("bankDetails")]
		[Field("bankDetails", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
