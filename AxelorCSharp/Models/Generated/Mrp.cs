using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.Mrp")]
	public class Mrp : AxelorModel
	{
		[JsonProperty("productFamilySet")]
		[Field("productFamilySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductFamily>? ProductFamilySet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", true, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("saleOrderLineSet")]
		[Field("saleOrderLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineSet;

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

		[JsonProperty("productSet")]
		[Field("productSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productCategorySet")]
		[Field("productCategorySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductCategory>? ProductCategorySet;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("mrpForecastSet")]
		[Field("mrpForecastSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Supplychain.Db.MrpForecast>? MrpForecastSet;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
