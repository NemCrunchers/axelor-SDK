using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockMoveLine")]
	public class StockMoveLine : AxelorModel
	{
		[Field("productModel")]
		public Axelor.Apps.Base.Db.Product? ProductModel;

		[Field("productName")]
		public string? ProductName;

		[Field("stockMove")]
		public Axelor.Apps.Stock.Db.StockMove? StockMove;

		[Field("id")]
		public long? Id;

		[Field("trackingNumber")]
		public Axelor.Apps.Stock.Db.TrackingNumber? TrackingNumber;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("purchaseOrderLine")]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("packPriceSelect")]
		public int? PackPriceSelect;

		[Field("producedManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ProducedManufOrder;

		[Field("customsCodeNomenclature")]
		public Axelor.Apps.Stock.Db.CustomsCodeNomenclature? CustomsCodeNomenclature;

		[Field("customsCode")]
		public string? CustomsCode;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("conformitySelect")]
		public int? ConformitySelect;

		[Field("isSubLine")]
		public bool? IsSubLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("consumedManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ConsumedManufOrder;

		[Field("productTypeSelect")]
		public string? ProductTypeSelect;

		[Field("parentLine")]
		public Axelor.Apps.Stock.Db.StockMoveLine? ParentLine;

		[Field("plannedStockMove")]
		public Axelor.Apps.Stock.Db.StockMove? PlannedStockMove;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("saleOrderLine")]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[Field("lineTypeSelect")]
		public int? LineTypeSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("consumedOperationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? ConsumedOperationOrder;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("countryOfOrigin")]
		public Axelor.Apps.Base.Db.Country? CountryOfOrigin;

	}
}
