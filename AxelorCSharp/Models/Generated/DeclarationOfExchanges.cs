using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.DeclarationOfExchanges")]
	public class DeclarationOfExchanges : AxelorModel
	{
		[JsonProperty("country")]
		[Field("country", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? Country;

		[JsonProperty("formatSelect")]
		[Field("formatSelect", true, "pdf", Int32.MaxValue)]
		public string? FormatSelect;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("period")]
		[Field("period", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("stockMoveTypeSelect")]
		[Field("stockMoveTypeSelect", true, "2", Int32.MaxValue)]
		public int? StockMoveTypeSelect;

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

		[JsonProperty("productTypeSelect")]
		[Field("productTypeSelect", true, "storable", Int32.MaxValue)]
		public string? ProductTypeSelect;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fiscalYear")]
		[Field("fiscalYear", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Year? FiscalYear;

	}
}
