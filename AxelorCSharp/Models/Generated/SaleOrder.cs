using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.SaleOrder")]
	public class SaleOrder : AxelorModel
	{
		[JsonProperty("carrierPartner")]
		[Field("carrierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[JsonProperty("expectedRealisationDate")]
		[Field("expectedRealisationDate", false, null, Int32.MaxValue)]
		public DateTime? ExpectedRealisationDate;

		[JsonProperty("periodicityTypeSelect")]
		[Field("periodicityTypeSelect", false, "2", Int32.MaxValue)]
		public int? PeriodicityTypeSelect;

		[JsonProperty("mainInvoicingAddressStr")]
		[Field("mainInvoicingAddressStr", false, null, Int32.MaxValue)]
		public string? MainInvoicingAddressStr;

		[JsonProperty("deliveryCondition")]
		[Field("deliveryCondition", false, null, Int32.MaxValue)]
		public string? DeliveryCondition;

		[JsonProperty("deliveryAddress")]
		[Field("deliveryAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? DeliveryAddress;

		[JsonProperty("nextInvoicingEndPeriodDate")]
		[Field("nextInvoicingEndPeriodDate", false, null, Int32.MaxValue)]
		public DateTime? NextInvoicingEndPeriodDate;

		[JsonProperty("salemanUser")]
		[Field("salemanUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SalemanUser;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("opportunity")]
		[Field("opportunity", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Opportunity? Opportunity;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("companyCostTotal")]
		[Field("companyCostTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyCostTotal;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isToPrintLineSubTotal")]
		[Field("isToPrintLineSubTotal", false, "False", Int32.MaxValue)]
		public bool? IsToPrintLineSubTotal;

		[JsonProperty("externalReference")]
		[Field("externalReference", false, null, Int32.MaxValue)]
		public string? ExternalReference;

		[JsonProperty("invoicedFirstDate")]
		[Field("invoicedFirstDate", false, null, Int32.MaxValue)]
		public DateTime? InvoicedFirstDate;

		[JsonProperty("template")]
		[Field("template", false, "False", Int32.MaxValue)]
		public bool? Template;

		[JsonProperty("currentContractPeriodEndDate")]
		[Field("currentContractPeriodEndDate", false, null, Int32.MaxValue)]
		public DateTime? CurrentContractPeriodEndDate;

		[JsonProperty("confirmationDateTime")]
		[Field("confirmationDateTime", false, null, Int32.MaxValue)]
		public DateTime? ConfirmationDateTime;

		[JsonProperty("saleOrderSeq")]
		[Field("saleOrderSeq", false, null, Int32.MaxValue)]
		public string? SaleOrderSeq;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("advancePaymentList")]
		[Field("advancePaymentList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.AdvancePayment>? AdvancePaymentList;

		[JsonProperty("createdByInterco")]
		[Field("createdByInterco", false, "False", Int32.MaxValue)]
		public bool? CreatedByInterco;

		[JsonProperty("numberOfPeriods")]
		[Field("numberOfPeriods", false, "1", Int32.MaxValue)]
		public int? NumberOfPeriods;

		[JsonProperty("contractPeriodInMonths")]
		[Field("contractPeriodInMonths", false, "0", Int32.MaxValue)]
		public int? ContractPeriodInMonths;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("timetableList")]
		[Field("timetableList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Supplychain.Db.Timetable>? TimetableList;

		[JsonProperty("saleOrderScheduleLineList")]
		[Field("saleOrderScheduleLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderScheduleLine>? SaleOrderScheduleLineList;

		[JsonProperty("cancelReasonStr")]
		[Field("cancelReasonStr", false, null, Int32.MaxValue)]
		public string? CancelReasonStr;

		[JsonProperty("isIspmRequired")]
		[Field("isIspmRequired", false, "False", Int32.MaxValue)]
		public bool? IsIspmRequired;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("cancelReason")]
		[Field("cancelReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[JsonProperty("deliveryDate")]
		[Field("deliveryDate", false, null, Int32.MaxValue)]
		public DateTime? DeliveryDate;

		[JsonProperty("totalCostPrice")]
		[Field("totalCostPrice", false, "0", Int32.MaxValue)]
		public decimal? TotalCostPrice;

		[JsonProperty("tradingName")]
		[Field("tradingName", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[JsonProperty("blockedOnCustCreditExceed")]
		[Field("blockedOnCustCreditExceed", false, "False", Int32.MaxValue)]
		public bool? BlockedOnCustCreditExceed;

		[JsonProperty("subscriptionComment")]
		[Field("subscriptionComment", false, null, Int32.MaxValue)]
		public string? SubscriptionComment;

		[JsonProperty("stockMoveList")]
		[Field("stockMoveList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMove>? StockMoveList;

		[JsonProperty("hideDiscount")]
		[Field("hideDiscount", false, "False", Int32.MaxValue)]
		public bool? HideDiscount;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("standardDelay")]
		[Field("standardDelay", false, "0", Int32.MaxValue)]
		public int? StandardDelay;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("specificNotes")]
		[Field("specificNotes", false, null, Int32.MaxValue)]
		public string? SpecificNotes;

		[JsonProperty("manualUnblock")]
		[Field("manualUnblock", false, "False", Int32.MaxValue)]
		public bool? ManualUnblock;

		[JsonProperty("internalNote")]
		[Field("internalNote", false, null, Int32.MaxValue)]
		public string? InternalNote;

		[JsonProperty("saleOrderLineTaxList")]
		[Field("saleOrderLineTaxList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLineTax>? SaleOrderLineTaxList;

		[JsonProperty("orderNumber")]
		[Field("orderNumber", false, null, Int32.MaxValue)]
		public string? OrderNumber;

		[JsonProperty("isNeedingConformityCertificate")]
		[Field("isNeedingConformityCertificate", false, "False", Int32.MaxValue)]
		public bool? IsNeedingConformityCertificate;

		[JsonProperty("companyExTaxTotal")]
		[Field("companyExTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxTotal;

		[JsonProperty("advanceTotal")]
		[Field("advanceTotal", false, "0", Int32.MaxValue)]
		public decimal? AdvanceTotal;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("totalGrossMargin")]
		[Field("totalGrossMargin", false, "0", Int32.MaxValue)]
		public decimal? TotalGrossMargin;

		[JsonProperty("noticePeriodInDays")]
		[Field("noticePeriodInDays", false, "0", Int32.MaxValue)]
		public int? NoticePeriodInDays;

		[JsonProperty("productionNote")]
		[Field("productionNote", false, null, Int32.MaxValue)]
		public string? ProductionNote;

		[JsonProperty("hasSubLineDefaultValue")]
		[Field("hasSubLineDefaultValue", false, "False", Int32.MaxValue)]
		public bool? HasSubLineDefaultValue;

		[JsonProperty("freightCarrierMode")]
		[Field("freightCarrierMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[JsonProperty("isTacitAgreement")]
		[Field("isTacitAgreement", false, "False", Int32.MaxValue)]
		public bool? IsTacitAgreement;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("orderBeingEdited")]
		[Field("orderBeingEdited", false, "False", Int32.MaxValue)]
		public bool? OrderBeingEdited;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("markup")]
		[Field("markup", false, "0", Int32.MaxValue)]
		public decimal? Markup;

		[JsonProperty("contractStartDate")]
		[Field("contractStartDate", false, null, Int32.MaxValue)]
		public DateTime? ContractStartDate;

		[JsonProperty("subscriptionText")]
		[Field("subscriptionText", false, null, Int32.MaxValue)]
		public string? SubscriptionText;

		[JsonProperty("nextInvoicingDate")]
		[Field("nextInvoicingDate", false, null, Int32.MaxValue)]
		public DateTime? NextInvoicingDate;

		[JsonProperty("creationDate")]
		[Field("creationDate", true, null, Int32.MaxValue)]
		public DateTime? CreationDate;

		[JsonProperty("mainInvoicingAddress")]
		[Field("mainInvoicingAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? MainInvoicingAddress;

		[JsonProperty("saleOrderLineList")]
		[Field("saleOrderLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineList;

		[JsonProperty("templateUser")]
		[Field("templateUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? TemplateUser;

		[JsonProperty("clientPartner")]
		[Field("clientPartner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[JsonProperty("electronicSignature")]
		[Field("electronicSignature", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[JsonProperty("incoterm")]
		[Field("incoterm", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[JsonProperty("saleOrderTypeSelect")]
		[Field("saleOrderTypeSelect", true, "1", Int32.MaxValue)]
		public int? SaleOrderTypeSelect;

		[JsonProperty("endOfValidityDate")]
		[Field("endOfValidityDate", false, null, Int32.MaxValue)]
		public DateTime? EndOfValidityDate;

		[JsonProperty("orderDate")]
		[Field("orderDate", false, null, Int32.MaxValue)]
		public DateTime? OrderDate;

		[JsonProperty("amountToBeSpreadOverTheTimetable")]
		[Field("amountToBeSpreadOverTheTimetable", false, "0", Int32.MaxValue)]
		public decimal? AmountToBeSpreadOverTheTimetable;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("nextInvPeriodStartDate")]
		[Field("nextInvPeriodStartDate", false, null, Int32.MaxValue)]
		public DateTime? NextInvPeriodStartDate;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("forwarderPartner")]
		[Field("forwarderPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[JsonProperty("inAti")]
		[Field("inAti", false, "False", Int32.MaxValue)]
		public bool? InAti;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("priceList")]
		[Field("priceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[JsonProperty("duration")]
		[Field("duration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? Duration;

		[JsonProperty("marginRate")]
		[Field("marginRate", false, "0", Int32.MaxValue)]
		public decimal? MarginRate;

		[JsonProperty("printingSettings")]
		[Field("printingSettings", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[JsonProperty("directOrderLocation")]
		[Field("directOrderLocation", false, "False", Int32.MaxValue)]
		public bool? DirectOrderLocation;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("deliveryAddressStr")]
		[Field("deliveryAddressStr", false, null, Int32.MaxValue)]
		public string? DeliveryAddressStr;

		[JsonProperty("shipmentDate")]
		[Field("shipmentDate", false, null, Int32.MaxValue)]
		public DateTime? ShipmentDate;

		[JsonProperty("accountedRevenue")]
		[Field("accountedRevenue", false, "0", Int32.MaxValue)]
		public decimal? AccountedRevenue;

		[JsonProperty("nextInvoicingStartPeriodDate")]
		[Field("nextInvoicingStartPeriodDate", false, null, Int32.MaxValue)]
		public DateTime? NextInvoicingStartPeriodDate;

		[JsonProperty("paymentCondition")]
		[Field("paymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("specificPackage")]
		[Field("specificPackage", false, null, Int32.MaxValue)]
		public string? SpecificPackage;

		[JsonProperty("contractEndDate")]
		[Field("contractEndDate", false, null, Int32.MaxValue)]
		public DateTime? ContractEndDate;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("shipmentMode")]
		[Field("shipmentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[JsonProperty("versionNumber")]
		[Field("versionNumber", false, "1", Int32.MaxValue)]
		public int? VersionNumber;

		[JsonProperty("amountInvoiced")]
		[Field("amountInvoiced", false, "0", Int32.MaxValue)]
		public decimal? AmountInvoiced;

		[JsonProperty("confirmedByUser")]
		[Field("confirmedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ConfirmedByUser;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("deliveryState")]
		[Field("deliveryState", false, "1", Int32.MaxValue)]
		public int? DeliveryState;

		[JsonProperty("interco")]
		[Field("interco", false, "False", Int32.MaxValue)]
		public bool? Interco;

	}
}
