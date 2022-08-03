using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockLocation")]
	public class StockLocation : AxelorModel
	{
		[JsonProperty("detailsStockLocationLineList")]
		[Field("detailsStockLocationLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockLocationLine>? DetailsStockLocationLineList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("usableOnPurchaseOrder")]
		[Field("usableOnPurchaseOrder", false, "False", Int32.MaxValue)]
		public bool? UsableOnPurchaseOrder;

		[JsonProperty("isWorkshop")]
		[Field("isWorkshop", false, "False", Int32.MaxValue)]
		public bool? IsWorkshop;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("stockLocationLineList")]
		[Field("stockLocationLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockLocationLine>? StockLocationLineList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("directOrderLocation")]
		[Field("directOrderLocation", false, "False", Int32.MaxValue)]
		public bool? DirectOrderLocation;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("address")]
		[Field("address", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? Address;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("usableOnSaleOrder")]
		[Field("usableOnSaleOrder", false, "False", Int32.MaxValue)]
		public bool? UsableOnSaleOrder;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("usableOnProduction")]
		[Field("usableOnProduction", false, "False", Int32.MaxValue)]
		public bool? UsableOnProduction;

		[JsonProperty("includeOutOfStock")]
		[Field("includeOutOfStock", false, "False", Int32.MaxValue)]
		public bool? IncludeOutOfStock;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("parentStockLocation")]
		[Field("parentStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ParentStockLocation;

	}
}
