using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockConfig")]
	public class StockConfig : AxelorModel
	{
		[JsonProperty("finishedProductsDefaultStockLocation")]
		[Field("finishedProductsDefaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? FinishedProductsDefaultStockLocation;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("inventoryVirtualStockLocation")]
		[Field("inventoryVirtualStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? InventoryVirtualStockLocation;

		[JsonProperty("qualityControlDefaultStockLocation")]
		[Field("qualityControlDefaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? QualityControlDefaultStockLocation;

		[JsonProperty("receiptDefaultStockLocation")]
		[Field("receiptDefaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ReceiptDefaultStockLocation;

		[JsonProperty("componentDefaultStockLocation")]
		[Field("componentDefaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ComponentDefaultStockLocation;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("realStockMoveMessageTemplate")]
		[Field("realStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("freightCarrierCustomerAccountNumberList")]
		[Field("freightCarrierCustomerAccountNumberList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.FreightCarrierCustomerAccountNumber>? FreightCarrierCustomerAccountNumberList;

		[JsonProperty("displayLineDetailsOnPrinting")]
		[Field("displayLineDetailsOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayLineDetailsOnPrinting;

		[JsonProperty("displayBarcodeOnPickingPrinting")]
		[Field("displayBarcodeOnPickingPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayBarcodeOnPickingPrinting;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("displayTrackNbrOnPickingPrinting")]
		[Field("displayTrackNbrOnPickingPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTrackNbrOnPickingPrinting;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("signatoryUser")]
		[Field("signatoryUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SignatoryUser;

		[JsonProperty("wasteStockLocation")]
		[Field("wasteStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? WasteStockLocation;

		[JsonProperty("displayPartnerSeqOnPrinting")]
		[Field("displayPartnerSeqOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayPartnerSeqOnPrinting;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("supplierVirtualStockLocation")]
		[Field("supplierVirtualStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? SupplierVirtualStockLocation;

		[JsonProperty("conformityCertificateDescription")]
		[Field("conformityCertificateDescription", false, null, Int32.MaxValue)]
		public string? ConformityCertificateDescription;

		[JsonProperty("isWithReturnSurplus")]
		[Field("isWithReturnSurplus", false, "False", Int32.MaxValue)]
		public bool? IsWithReturnSurplus;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("directOrderStockLocation")]
		[Field("directOrderStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? DirectOrderStockLocation;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("realizeStockMovesUponParcelPalletCollection")]
		[Field("realizeStockMovesUponParcelPalletCollection", false, "False", Int32.MaxValue)]
		public bool? RealizeStockMovesUponParcelPalletCollection;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("productionVirtualStockLocation")]
		[Field("productionVirtualStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ProductionVirtualStockLocation;

		[JsonProperty("customerVirtualStockLocation")]
		[Field("customerVirtualStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? CustomerVirtualStockLocation;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("customsMassUnit")]
		[Field("customsMassUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? CustomsMassUnit;

		[JsonProperty("isWithBackorder")]
		[Field("isWithBackorder", false, "False", Int32.MaxValue)]
		public bool? IsWithBackorder;

		[JsonProperty("pickupDefaultStockLocation")]
		[Field("pickupDefaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? PickupDefaultStockLocation;

		[JsonProperty("displayCustomerCodeOnPickingPrinting")]
		[Field("displayCustomerCodeOnPickingPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayCustomerCodeOnPickingPrinting;

		[JsonProperty("pickingOrderPrintingDetailed")]
		[Field("pickingOrderPrintingDetailed", false, "False", Int32.MaxValue)]
		public bool? PickingOrderPrintingDetailed;

		[JsonProperty("plannedStockMoveMessageTemplate")]
		[Field("plannedStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[JsonProperty("realStockMoveAutomaticMail")]
		[Field("realStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? RealStockMoveAutomaticMail;

		[JsonProperty("conformityCertificateTitle")]
		[Field("conformityCertificateTitle", false, null, Int32.MaxValue)]
		public string? ConformityCertificateTitle;

		[JsonProperty("plannedStockMoveAutomaticMail")]
		[Field("plannedStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? PlannedStockMoveAutomaticMail;

	}
}
