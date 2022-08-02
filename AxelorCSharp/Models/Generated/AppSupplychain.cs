using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppSupplychain")]
	public class AppSupplychain : AxelorModel
	{
		[Field("allowTimetableInvoicing")]
		public bool? AllowTimetableInvoicing;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("allowSusbcriptionSaleOrder")]
		public bool? AllowSusbcriptionSaleOrder;

		[Field("generateInvoiceFromPurchaseOrder")]
		public bool? GenerateInvoiceFromPurchaseOrder;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("cancelReasonOnChangingSaleOrder")]
		public Axelor.Apps.Base.Db.CancelReason? CancelReasonOnChangingSaleOrder;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("allowFinishManuallyPurchaseOrder")]
		public bool? AllowFinishManuallyPurchaseOrder;

		[Field("manageStockReservation")]
		public bool? ManageStockReservation;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("customerStockMoveGenerationAuto")]
		public bool? CustomerStockMoveGenerationAuto;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("generateInvoiceFromStockMove")]
		public bool? GenerateInvoiceFromStockMove;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("supplStockMoveMgtOnPO")]
		public bool? SupplStockMoveMgtOnPO;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("intercoFromSale")]
		public bool? IntercoFromSale;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("intercoSaleOrderCreateFinalized")]
		public bool? IntercoSaleOrderCreateFinalized;

		[Field("terminatePurchaseOrderOnReceipt")]
		public bool? TerminatePurchaseOrderOnReceipt;

		[Field("name")]
		public string? Name;

		[Field("intercoFromPurchase")]
		public bool? IntercoFromPurchase;

		[Field("intercoSaleCreatingStatusSelect")]
		public int? IntercoSaleCreatingStatusSelect;

		[Field("intercoInvoiceCreateValidated")]
		public bool? IntercoInvoiceCreateValidated;

		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("intercoPurchaseCreatingStatusSelect")]
		public int? IntercoPurchaseCreatingStatusSelect;

		[Field("allowCompleteManuallySaleOrder")]
		public bool? AllowCompleteManuallySaleOrder;

		[Field("intercoPurchaseOrderCreateRequested")]
		public bool? IntercoPurchaseOrderCreateRequested;

		[Field("checkSaleStocks")]
		public bool? CheckSaleStocks;

		[Field("terminateSaleOrderOnDelivery")]
		public bool? TerminateSaleOrderOnDelivery;

		[Field("generateInvoiceFromSaleOrder")]
		public bool? GenerateInvoiceFromSaleOrder;

		[Field("custStockMoveMgtOnSO")]
		public bool? CustStockMoveMgtOnSO;

		[Field("purchaseOrderGenerationAuto")]
		public bool? PurchaseOrderGenerationAuto;

		[Field("intercoFromInvoice")]
		public bool? IntercoFromInvoice;

		[Field("supplierStockMoveGenerationAuto")]
		public bool? SupplierStockMoveGenerationAuto;

		[Field("importId")]
		public string? ImportId;

		[Field("manageInvoicedAmountByLine")]
		public bool? ManageInvoicedAmountByLine;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
