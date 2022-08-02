using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Partner")]
	public class Partner : AxelorModel
	{
		[Field("purchasePartnerPriceList")]
		public Axelor.Apps.Base.Db.PartnerPriceList? PurchasePartnerPriceList;

		[Field("carrierPartner")]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[Field("companyStr")]
		public string? CompanyStr;

		[Field("invoicesCopySelect")]
		public int? InvoicesCopySelect;

		[Field("isCarrier")]
		public bool? IsCarrier;

		[Field("password")]
		public string? Password;

		[Field("taxNbr")]
		public string? TaxNbr;

		[Field("id")]
		public long? Id;

		[Field("fax")]
		public string? Fax;

		[Field("contactPartnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? ContactPartnerSet;

		[Field("chargeBackPurchaseSelect")]
		public int? ChargeBackPurchaseSelect;

		[Field("isEmployee")]
		public bool? IsEmployee;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("mainAddress")]
		public Axelor.Apps.Base.Db.Address? MainAddress;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("mainPartner")]
		public Axelor.Apps.Base.Db.Partner? MainPartner;

		[Field("mobilePhone")]
		public string? MobilePhone;

		[Field("factorizedCustomer")]
		public bool? FactorizedCustomer;

		[Field("industrySector")]
		public Axelor.Apps.Base.Db.IndustrySector? IndustrySector;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("webSite")]
		public string? WebSite;

		[Field("archived")]
		public bool? Archived;

		[Field("partnerSeq")]
		public string? PartnerSeq;

		[Field("isIspmRequired")]
		public bool? IsIspmRequired;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("isProspect")]
		public bool? IsProspect;

		[Field("parentPartner")]
		public Axelor.Apps.Base.Db.Partner? ParentPartner;

		[Field("reportsTo")]
		public Axelor.Apps.Base.Db.Partner? ReportsTo;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("picture")]
		public Axelor.Meta.Db.MetaFile? Picture;

		[Field("saleTurnover")]
		public int? SaleTurnover;

		[Field("importId")]
		public string? ImportId;

		[Field("fiscalPosition")]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

		[Field("isNeedingConformityCertificate")]
		public bool? IsNeedingConformityCertificate;

		[Field("isSupplier")]
		public bool? IsSupplier;

		[Field("jobTitle")]
		public string? JobTitle;

		[Field("language")]
		public Axelor.Apps.Base.Db.Language? Language;

		[Field("partnerTypeSelect")]
		public int? PartnerTypeSelect;

		[Field("source")]
		public Axelor.Apps.Base.Db.Source? Source;

		[Field("titleSelect")]
		public int? TitleSelect;

		[Field("partnerCategory")]
		public Axelor.Apps.Base.Db.PartnerCategory? PartnerCategory;

		[Field("freightCarrierMode")]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("nbrEmployees")]
		public int? NbrEmployees;

		[Field("fixedPhone")]
		public string? FixedPhone;

		[Field("salePartnerPriceList")]
		public Axelor.Apps.Base.Db.PartnerPriceList? SalePartnerPriceList;

		[Field("firstName")]
		public string? FirstName;

		[Field("rejectCounter")]
		public int? RejectCounter;

		[Field("simpleFullName")]
		public string? SimpleFullName;

		[Field("name")]
		public string? Name;

		[Field("outPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? OutPaymentMode;

		[Field("partnerAttrs")]
		public string? PartnerAttrs;

		[Field("invoiceSendingFormatSelect")]
		public string? InvoiceSendingFormatSelect;

		[Field("isContact")]
		public bool? IsContact;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("activeUmr")]
		public Axelor.Apps.Account.Db.Umr? ActiveUmr;

		[Field("inPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? InPaymentMode;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("sellerCode")]
		public string? SellerCode;

		[Field("isFactor")]
		public bool? IsFactor;

		[Field("registrationCode")]
		public string? RegistrationCode;

		[Field("companySet")]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

		[Field("department")]
		public string? Department;

		[Field("deliveryDelay")]
		public int? DeliveryDelay;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("contactAttrs")]
		public string? ContactAttrs;

		[Field("fullName")]
		public string? FullName;

		[Field("shipmentMode")]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[Field("isCustomer")]
		public bool? IsCustomer;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
