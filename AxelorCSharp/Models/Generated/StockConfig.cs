using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockConfig")]
	public class StockConfig : AxelorModel
	{
		[Field("finishedProductsDefaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? FinishedProductsDefaultStockLocation;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("inventoryVirtualStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? InventoryVirtualStockLocation;

		[Field("qualityControlDefaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? QualityControlDefaultStockLocation;

		[Field("receiptDefaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ReceiptDefaultStockLocation;

		[Field("componentDefaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ComponentDefaultStockLocation;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("realStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[Field("archived")]
		public bool? Archived;

		[Field("displayLineDetailsOnPrinting")]
		public bool? DisplayLineDetailsOnPrinting;

		[Field("displayBarcodeOnPickingPrinting")]
		public bool? DisplayBarcodeOnPickingPrinting;

		[Field("displayTrackNbrOnPickingPrinting")]
		public bool? DisplayTrackNbrOnPickingPrinting;

		[Field("id")]
		public long? Id;

		[Field("signatoryUser")]
		public Axelor.Auth.Db.User? SignatoryUser;

		[Field("wasteStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WasteStockLocation;

		[Field("displayPartnerSeqOnPrinting")]
		public bool? DisplayPartnerSeqOnPrinting;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("supplierVirtualStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? SupplierVirtualStockLocation;

		[Field("isWithReturnSurplus")]
		public bool? IsWithReturnSurplus;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("directOrderStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? DirectOrderStockLocation;

		[Field("version")]
		public int? Version;

		[Field("realizeStockMovesUponParcelPalletCollection")]
		public bool? RealizeStockMovesUponParcelPalletCollection;

		[Field("attrs")]
		public string? Attrs;

		[Field("productionVirtualStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ProductionVirtualStockLocation;

		[Field("customerVirtualStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? CustomerVirtualStockLocation;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("customsMassUnit")]
		public Axelor.Apps.Base.Db.Unit? CustomsMassUnit;

		[Field("isWithBackorder")]
		public bool? IsWithBackorder;

		[Field("pickupDefaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? PickupDefaultStockLocation;

		[Field("displayCustomerCodeOnPickingPrinting")]
		public bool? DisplayCustomerCodeOnPickingPrinting;

		[Field("pickingOrderPrintingDetailed")]
		public bool? PickingOrderPrintingDetailed;

		[Field("plannedStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[Field("realStockMoveAutomaticMail")]
		public bool? RealStockMoveAutomaticMail;

		[Field("conformityCertificateTitle")]
		public string? ConformityCertificateTitle;

		[Field("plannedStockMoveAutomaticMail")]
		public bool? PlannedStockMoveAutomaticMail;

	}
}
