using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockMoveLine")]
	public class StockMoveLine : AxelorModel
	{
		[JsonProperty("productModel")]
		[Field("productModel", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? ProductModel;

		[JsonProperty("oldQty")]
		[Field("oldQty", false, "0", Int32.MaxValue)]
		public decimal? OldQty;

		[JsonProperty("productName")]
		[Field("productName", true, null, Int32.MaxValue)]
		public string? ProductName;

		[JsonProperty("stockMove")]
		[Field("stockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? StockMove;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("trackingNumber")]
		[Field("trackingNumber", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.TrackingNumber? TrackingNumber;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("purchaseOrderLine")]
		[Field("purchaseOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("totalNetMass")]
		[Field("totalNetMass", false, "0", Int32.MaxValue)]
		public decimal? TotalNetMass;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("packPriceSelect")]
		[Field("packPriceSelect", false, "0", Int32.MaxValue)]
		public int? PackPriceSelect;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("producedManufOrder")]
		[Field("producedManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ProducedManufOrder;

		[JsonProperty("customsCodeNomenclature")]
		[Field("customsCodeNomenclature", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.CustomsCodeNomenclature? CustomsCodeNomenclature;

		[JsonProperty("subLineList")]
		[Field("subLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? SubLineList;

		[JsonProperty("customsCode")]
		[Field("customsCode", false, null, Int32.MaxValue)]
		public string? CustomsCode;

		[JsonProperty("logisticalFormLineList")]
		[Field("logisticalFormLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.LogisticalFormLine>? LogisticalFormLineList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("conformitySelect")]
		[Field("conformitySelect", false, "0", Int32.MaxValue)]
		public int? ConformitySelect;

		[JsonProperty("isSubLine")]
		[Field("isSubLine", false, "False", Int32.MaxValue)]
		public bool? IsSubLine;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("realQty")]
		[Field("realQty", false, "0", Int32.MaxValue)]
		public decimal? RealQty;

		[JsonProperty("requestedReservedQty")]
		[Field("requestedReservedQty", false, "0", Int32.MaxValue)]
		public decimal? RequestedReservedQty;

		[JsonProperty("consumedManufOrder")]
		[Field("consumedManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ConsumedManufOrder;

		[JsonProperty("productTypeSelect")]
		[Field("productTypeSelect", false, null, Int32.MaxValue)]
		public string? ProductTypeSelect;

		[JsonProperty("parentLine")]
		[Field("parentLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMoveLine? ParentLine;

		[JsonProperty("plannedStockMove")]
		[Field("plannedStockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? PlannedStockMove;

		[JsonProperty("shippedQty")]
		[Field("shippedQty", false, "0", Int32.MaxValue)]
		public decimal? ShippedQty;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("saleOrderLine")]
		[Field("saleOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[JsonProperty("companyUnitPriceUntaxed")]
		[Field("companyUnitPriceUntaxed", false, "0", Int32.MaxValue)]
		public decimal? CompanyUnitPriceUntaxed;

		[JsonProperty("unitPriceUntaxed")]
		[Field("unitPriceUntaxed", false, "0", Int32.MaxValue)]
		public decimal? UnitPriceUntaxed;

		[JsonProperty("lineTypeSelect")]
		[Field("lineTypeSelect", false, "0", Int32.MaxValue)]
		public int? LineTypeSelect;

		[JsonProperty("reservedQty")]
		[Field("reservedQty", false, "0", Int32.MaxValue)]
		public decimal? ReservedQty;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("consumedOperationOrder")]
		[Field("consumedOperationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? ConsumedOperationOrder;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("unitPriceTaxed")]
		[Field("unitPriceTaxed", false, "0", Int32.MaxValue)]
		public decimal? UnitPriceTaxed;

		[JsonProperty("countryOfOrigin")]
		[Field("countryOfOrigin", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? CountryOfOrigin;

		[JsonProperty("shippedDate")]
		[Field("shippedDate", false, null, Int32.MaxValue)]
		public DateTime? ShippedDate;

		[JsonProperty("netMass")]
		[Field("netMass", false, "0", Int32.MaxValue)]
		public decimal? NetMass;

	}
}
