using Axelor.SDK;

namespace Axelor.Apps.Purchase.Db
{
	[Model("com.axelor.apps.purchase.db.PurchaseOrder")]
	public class PurchaseOrder : AxelorModel
	{
		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("supplierPartner")]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[Field("purchaseOrderSeq")]
		public string? PurchaseOrderSeq;

		[Field("id")]
		public long? Id;

		[Field("freightCarrierMode")]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[Field("budget")]
		public Axelor.Apps.Account.Db.Budget? Budget;

		[Field("generatedSaleOrderId")]
		public long? GeneratedSaleOrderId;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isPurchaseParent")]
		public bool? IsPurchaseParent;

		[Field("buyerUser")]
		public Axelor.Auth.Db.User? BuyerUser;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("externalReference")]
		public string? ExternalReference;

		[Field("receiptState")]
		public int? ReceiptState;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("validatedByUser")]
		public Axelor.Auth.Db.User? ValidatedByUser;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("createdByInterco")]
		public bool? CreatedByInterco;

		[Field("inAti")]
		public bool? InAti;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("priceList")]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[Field("archived")]
		public bool? Archived;

		[Field("printingSettings")]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("parentPurchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? ParentPurchaseOrder;

		[Field("tradingName")]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[Field("priceDisplay")]
		public bool? PriceDisplay;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("fullName")]
		public string? FullName;

		[Field("internalReference")]
		public string? InternalReference;

		[Field("shipmentMode")]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("versionNumber")]
		public int? VersionNumber;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("interco")]
		public bool? Interco;

	}
}
