using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.Mrp")]
	public class Mrp : AxelorModel
	{
		[Field("productFamilySet")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductFamily>? ProductFamilySet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("saleOrderLineSet")]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineSet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("productSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("productCategorySet")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductCategory>? ProductCategorySet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("mrpForecastSet")]
		public IEnumerable<Axelor.Apps.Supplychain.Db.MrpForecast>? MrpForecastSet;

		[Field("id")]
		public long? Id;

	}
}
