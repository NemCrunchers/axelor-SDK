using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ProdProcess")]
	public class ProdProcess : AxelorModel
	{
		[JsonProperty("launchQty")]
		[Field("launchQty", false, "0", Int32.MaxValue)]
		public decimal? LaunchQty;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("prodProcessLineList")]
		[Field("prodProcessLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProcessLine>? ProdProcessLineList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("producedProductStockLocation")]
		[Field("producedProductStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ProducedProductStockLocation;

		[JsonProperty("workshopStockLocation")]
		[Field("workshopStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("stockMoveRealizeOrderSelect")]
		[Field("stockMoveRealizeOrderSelect", false, "1", Int32.MaxValue)]
		public int? StockMoveRealizeOrderSelect;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("isConsProOnOperation")]
		[Field("isConsProOnOperation", false, "False", Int32.MaxValue)]
		public bool? IsConsProOnOperation;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("originalProdProcess")]
		[Field("originalProdProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcess? OriginalProdProcess;

		[JsonProperty("versionNumber")]
		[Field("versionNumber", false, "1", Int32.MaxValue)]
		public int? VersionNumber;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("outsourcing")]
		[Field("outsourcing", false, "False", Int32.MaxValue)]
		public bool? Outsourcing;

		[JsonProperty("isEnabledForAllProducts")]
		[Field("isEnabledForAllProducts", false, "False", Int32.MaxValue)]
		public bool? IsEnabledForAllProducts;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

	}
}
