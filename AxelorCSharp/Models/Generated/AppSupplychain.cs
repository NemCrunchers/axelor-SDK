using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppSupplychain")]
	public class AppSupplychain : AxelorModel
	{
		[JsonProperty("allowTimetableInvoicing")]
		[Field("allowTimetableInvoicing", false, "False", Int32.MaxValue)]
		public bool? AllowTimetableInvoicing;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("allowSusbcriptionSaleOrder")]
		[Field("allowSusbcriptionSaleOrder", false, "False", Int32.MaxValue)]
		public bool? AllowSusbcriptionSaleOrder;

		[JsonProperty("generateInvoiceFromPurchaseOrder")]
		[Field("generateInvoiceFromPurchaseOrder", false, "False", Int32.MaxValue)]
		public bool? GenerateInvoiceFromPurchaseOrder;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("cancelReasonOnChangingSaleOrder")]
		[Field("cancelReasonOnChangingSaleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CancelReason? CancelReasonOnChangingSaleOrder;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("allowFinishManuallyPurchaseOrder")]
		[Field("allowFinishManuallyPurchaseOrder", false, "False", Int32.MaxValue)]
		public bool? AllowFinishManuallyPurchaseOrder;

		[JsonProperty("manageStockReservation")]
		[Field("manageStockReservation", false, "False", Int32.MaxValue)]
		public bool? ManageStockReservation;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("customerStockMoveGenerationAuto")]
		[Field("customerStockMoveGenerationAuto", false, "False", Int32.MaxValue)]
		public bool? CustomerStockMoveGenerationAuto;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("generateInvoiceFromStockMove")]
		[Field("generateInvoiceFromStockMove", false, "False", Int32.MaxValue)]
		public bool? GenerateInvoiceFromStockMove;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("supplStockMoveMgtOnPO")]
		[Field("supplStockMoveMgtOnPO", false, "False", Int32.MaxValue)]
		public bool? SupplStockMoveMgtOnPO;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("intercoFromSale")]
		[Field("intercoFromSale", false, "False", Int32.MaxValue)]
		public bool? IntercoFromSale;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("intercoSaleOrderCreateFinalized")]
		[Field("intercoSaleOrderCreateFinalized", false, "False", Int32.MaxValue)]
		public bool? IntercoSaleOrderCreateFinalized;

		[JsonProperty("terminatePurchaseOrderOnReceipt")]
		[Field("terminatePurchaseOrderOnReceipt", false, "False", Int32.MaxValue)]
		public bool? TerminatePurchaseOrderOnReceipt;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("intercoFromPurchase")]
		[Field("intercoFromPurchase", false, "False", Int32.MaxValue)]
		public bool? IntercoFromPurchase;

		[JsonProperty("intercoSaleCreatingStatusSelect")]
		[Field("intercoSaleCreatingStatusSelect", false, "0", Int32.MaxValue)]
		public int? IntercoSaleCreatingStatusSelect;

		[JsonProperty("intercoInvoiceCreateValidated")]
		[Field("intercoInvoiceCreateValidated", false, "False", Int32.MaxValue)]
		public bool? IntercoInvoiceCreateValidated;

		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("intercoPurchaseCreatingStatusSelect")]
		[Field("intercoPurchaseCreatingStatusSelect", false, "0", Int32.MaxValue)]
		public int? IntercoPurchaseCreatingStatusSelect;

		[JsonProperty("allowCompleteManuallySaleOrder")]
		[Field("allowCompleteManuallySaleOrder", false, "False", Int32.MaxValue)]
		public bool? AllowCompleteManuallySaleOrder;

		[JsonProperty("intercoPurchaseOrderCreateRequested")]
		[Field("intercoPurchaseOrderCreateRequested", false, "False", Int32.MaxValue)]
		public bool? IntercoPurchaseOrderCreateRequested;

		[JsonProperty("checkSaleStocks")]
		[Field("checkSaleStocks", false, "False", Int32.MaxValue)]
		public bool? CheckSaleStocks;

		[JsonProperty("terminateSaleOrderOnDelivery")]
		[Field("terminateSaleOrderOnDelivery", false, "False", Int32.MaxValue)]
		public bool? TerminateSaleOrderOnDelivery;

		[JsonProperty("generateInvoiceFromSaleOrder")]
		[Field("generateInvoiceFromSaleOrder", false, "False", Int32.MaxValue)]
		public bool? GenerateInvoiceFromSaleOrder;

		[JsonProperty("custStockMoveMgtOnSO")]
		[Field("custStockMoveMgtOnSO", false, "False", Int32.MaxValue)]
		public bool? CustStockMoveMgtOnSO;

		[JsonProperty("purchaseOrderGenerationAuto")]
		[Field("purchaseOrderGenerationAuto", false, "False", Int32.MaxValue)]
		public bool? PurchaseOrderGenerationAuto;

		[JsonProperty("intercoFromInvoice")]
		[Field("intercoFromInvoice", false, "False", Int32.MaxValue)]
		public bool? IntercoFromInvoice;

		[JsonProperty("supplierStockMoveGenerationAuto")]
		[Field("supplierStockMoveGenerationAuto", false, "False", Int32.MaxValue)]
		public bool? SupplierStockMoveGenerationAuto;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("manageInvoicedAmountByLine")]
		[Field("manageInvoicedAmountByLine", false, "False", Int32.MaxValue)]
		public bool? ManageInvoicedAmountByLine;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

	}
}
