using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockLocation")]
	public class StockLocation : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("usableOnPurchaseOrder")]
		public bool? UsableOnPurchaseOrder;

		[Field("isWorkshop")]
		public bool? IsWorkshop;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("directOrderLocation")]
		public bool? DirectOrderLocation;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("address")]
		public Axelor.Apps.Base.Db.Address? Address;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("usableOnSaleOrder")]
		public bool? UsableOnSaleOrder;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("usableOnProduction")]
		public bool? UsableOnProduction;

		[Field("includeOutOfStock")]
		public bool? IncludeOutOfStock;

		[Field("name")]
		public string? Name;

		[Field("parentStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ParentStockLocation;

	}
}
