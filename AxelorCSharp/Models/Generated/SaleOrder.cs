using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.SaleOrder")]
	public class SaleOrder : AxelorModel
	{
		[Field("carrierPartner")]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[Field("periodicityTypeSelect")]
		public int? PeriodicityTypeSelect;

		[Field("deliveryAddress")]
		public Axelor.Apps.Base.Db.Address? DeliveryAddress;

		[Field("salemanUser")]
		public Axelor.Auth.Db.User? SalemanUser;

		[Field("id")]
		public long? Id;

		[Field("opportunity")]
		public Axelor.Apps.Crm.Db.Opportunity? Opportunity;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("isToPrintLineSubTotal")]
		public bool? IsToPrintLineSubTotal;

		[Field("externalReference")]
		public string? ExternalReference;

		[Field("template")]
		public bool? Template;

		[Field("confirmationDateTime")]
		public DateTime? ConfirmationDateTime;

		[Field("saleOrderSeq")]
		public string? SaleOrderSeq;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("createdByInterco")]
		public bool? CreatedByInterco;

		[Field("numberOfPeriods")]
		public int? NumberOfPeriods;

		[Field("contractPeriodInMonths")]
		public int? ContractPeriodInMonths;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("isIspmRequired")]
		public bool? IsIspmRequired;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("cancelReason")]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[Field("tradingName")]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[Field("blockedOnCustCreditExceed")]
		public bool? BlockedOnCustCreditExceed;

		[Field("hideDiscount")]
		public bool? HideDiscount;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("standardDelay")]
		public int? StandardDelay;

		[Field("importId")]
		public string? ImportId;

		[Field("manualUnblock")]
		public bool? ManualUnblock;

		[Field("orderNumber")]
		public string? OrderNumber;

		[Field("isNeedingConformityCertificate")]
		public bool? IsNeedingConformityCertificate;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("noticePeriodInDays")]
		public int? NoticePeriodInDays;

		[Field("hasSubLineDefaultValue")]
		public bool? HasSubLineDefaultValue;

		[Field("freightCarrierMode")]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[Field("isTacitAgreement")]
		public bool? IsTacitAgreement;

		[Field("orderBeingEdited")]
		public bool? OrderBeingEdited;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("mainInvoicingAddress")]
		public Axelor.Apps.Base.Db.Address? MainInvoicingAddress;

		[Field("templateUser")]
		public Axelor.Auth.Db.User? TemplateUser;

		[Field("clientPartner")]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[Field("electronicSignature")]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[Field("incoterm")]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[Field("saleOrderTypeSelect")]
		public int? SaleOrderTypeSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("forwarderPartner")]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[Field("inAti")]
		public bool? InAti;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("priceList")]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[Field("duration")]
		public Axelor.Apps.Base.Db.Duration? Duration;

		[Field("printingSettings")]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[Field("directOrderLocation")]
		public bool? DirectOrderLocation;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("fullName")]
		public string? FullName;

		[Field("shipmentMode")]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[Field("versionNumber")]
		public int? VersionNumber;

		[Field("confirmedByUser")]
		public Axelor.Auth.Db.User? ConfirmedByUser;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("deliveryState")]
		public int? DeliveryState;

		[Field("interco")]
		public bool? Interco;

	}
}
