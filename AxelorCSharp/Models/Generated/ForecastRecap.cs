using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Cash.Management.Db
{
	[Serializable]
	[Model("com.axelor.apps.cash.management.db.ForecastRecap")]
	public class ForecastRecap : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("opportunitiesTypeSelect")]
		[Field("opportunitiesTypeSelect", false, "0", Int32.MaxValue)]
		public int? OpportunitiesTypeSelect;

		[JsonProperty("currentBalance")]
		[Field("currentBalance", false, "0", Int32.MaxValue)]
		public decimal? CurrentBalance;

		[JsonProperty("isReport")]
		[Field("isReport", false, "False", Int32.MaxValue)]
		public bool? IsReport;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("endingBalance")]
		[Field("endingBalance", false, "0", Int32.MaxValue)]
		public decimal? EndingBalance;

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

		[JsonProperty("startingBalance")]
		[Field("startingBalance", true, "0", Int32.MaxValue)]
		public decimal? StartingBalance;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("forecastRecapLineList")]
		[Field("forecastRecapLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Cash.Management.Db.ForecastRecapLine>? ForecastRecapLineList;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("displayTypeSelect")]
		[Field("displayTypeSelect", false, "3", Int32.MaxValue)]
		public int? DisplayTypeSelect;

		[JsonProperty("salesMan")]
		[Field("salesMan", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SalesMan;

	}
}
