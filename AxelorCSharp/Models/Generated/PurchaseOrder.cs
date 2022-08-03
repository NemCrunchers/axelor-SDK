using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Purchase.Db
{
	[Serializable]
	[Model("com.axelor.apps.purchase.db.PurchaseOrder")]
	public class PurchaseOrder : AxelorModel
	{
		[JsonProperty("priceRequest")]
		[Field("priceRequest", false, null, Int32.MaxValue)]
		public string? PriceRequest;

		[JsonProperty("notes")]
		[Field("notes", false, null, Int32.MaxValue)]
		public string? Notes;

		[JsonProperty("companyExTaxTotal")]
		[Field("companyExTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxTotal;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("expectedRealisationDate")]
		[Field("expectedRealisationDate", false, null, Int32.MaxValue)]
		public DateTime? ExpectedRealisationDate;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("validationDate")]
		[Field("validationDate", false, null, Int32.MaxValue)]
		public DateTime? ValidationDate;

		[JsonProperty("supplierPartner")]
		[Field("supplierPartner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[JsonProperty("purchaseOrderSeq")]
		[Field("purchaseOrderSeq", false, null, Int32.MaxValue)]
		public string? PurchaseOrderSeq;

		[JsonProperty("purchaseOrderLineList")]
		[Field("purchaseOrderLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.PurchaseOrderLine>? PurchaseOrderLineList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("freightCarrierMode")]
		[Field("freightCarrierMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[JsonProperty("budget")]
		[Field("budget", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Budget? Budget;

		[JsonProperty("generatedSaleOrderId")]
		[Field("generatedSaleOrderId", false, "0", Int32.MaxValue)]
		public long? GeneratedSaleOrderId;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isPurchaseParent")]
		[Field("isPurchaseParent", false, "False", Int32.MaxValue)]
		public bool? IsPurchaseParent;

		[JsonProperty("buyerUser")]
		[Field("buyerUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? BuyerUser;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("externalReference")]
		[Field("externalReference", false, null, Int32.MaxValue)]
		public string? ExternalReference;

		[JsonProperty("receiptState")]
		[Field("receiptState", false, "1", Int32.MaxValue)]
		public int? ReceiptState;

		[JsonProperty("orderDate")]
		[Field("orderDate", false, null, Int32.MaxValue)]
		public DateTime? OrderDate;

		[JsonProperty("amountToBeSpreadOverTheTimetable")]
		[Field("amountToBeSpreadOverTheTimetable", false, "0", Int32.MaxValue)]
		public decimal? AmountToBeSpreadOverTheTimetable;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("validatedByUser")]
		[Field("validatedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedByUser;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("createdByInterco")]
		[Field("createdByInterco", false, "False", Int32.MaxValue)]
		public bool? CreatedByInterco;

		[JsonProperty("inAti")]
		[Field("inAti", false, "False", Int32.MaxValue)]
		public bool? InAti;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("priceList")]
		[Field("priceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("printingSettings")]
		[Field("printingSettings", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[JsonProperty("timetableList")]
		[Field("timetableList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Supplychain.Db.Timetable>? TimetableList;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("deliveryDate")]
		[Field("deliveryDate", false, null, Int32.MaxValue)]
		public DateTime? DeliveryDate;

		[JsonProperty("parentPurchaseOrder")]
		[Field("parentPurchaseOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? ParentPurchaseOrder;

		[JsonProperty("tradingName")]
		[Field("tradingName", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[JsonProperty("priceDisplay")]
		[Field("priceDisplay", false, "False", Int32.MaxValue)]
		public bool? PriceDisplay;

		[JsonProperty("paymentCondition")]
		[Field("paymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("internalReference")]
		[Field("internalReference", false, null, Int32.MaxValue)]
		public string? InternalReference;

		[JsonProperty("shipmentMode")]
		[Field("shipmentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("purchaseOrderLineTaxList")]
		[Field("purchaseOrderLineTaxList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.PurchaseOrderLineTax>? PurchaseOrderLineTaxList;

		[JsonProperty("versionNumber")]
		[Field("versionNumber", false, "1", Int32.MaxValue)]
		public int? VersionNumber;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("amountInvoiced")]
		[Field("amountInvoiced", false, "0", Int32.MaxValue)]
		public decimal? AmountInvoiced;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("internalNote")]
		[Field("internalNote", false, null, Int32.MaxValue)]
		public string? InternalNote;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("interco")]
		[Field("interco", false, "False", Int32.MaxValue)]
		public bool? Interco;

	}
}
