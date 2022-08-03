using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Partner")]
	public class Partner : AxelorModel
	{
		[JsonProperty("purchasePartnerPriceList")]
		[Field("purchasePartnerPriceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PartnerPriceList? PurchasePartnerPriceList;

		[JsonProperty("carrierPartner")]
		[Field("carrierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[JsonProperty("companyStr")]
		[Field("companyStr", false, null, Int32.MaxValue)]
		public string? CompanyStr;

		[JsonProperty("invoicesCopySelect")]
		[Field("invoicesCopySelect", false, "1", Int32.MaxValue)]
		public int? InvoicesCopySelect;

		[JsonProperty("isCarrier")]
		[Field("isCarrier", false, "False", Int32.MaxValue)]
		public bool? IsCarrier;

		[JsonProperty("password")]
		[Field("password", false, null, Int32.MaxValue)]
		public string? Password;

		[JsonProperty("taxNbr")]
		[Field("taxNbr", false, null, Int32.MaxValue)]
		public string? TaxNbr;

		[JsonProperty("accountingSituationList")]
		[Field("accountingSituationList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AccountingSituation>? AccountingSituationList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fax")]
		[Field("fax", false, null, Int32.MaxValue)]
		public string? Fax;

		[JsonProperty("contactPartnerSet")]
		[Field("contactPartnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? ContactPartnerSet;

		[JsonProperty("chargeBackPurchaseSelect")]
		[Field("chargeBackPurchaseSelect", false, "0", Int32.MaxValue)]
		public int? ChargeBackPurchaseSelect;

		[JsonProperty("isEmployee")]
		[Field("isEmployee", false, "False", Int32.MaxValue)]
		public bool? IsEmployee;

		[JsonProperty("partnerStockSettingsList")]
		[Field("partnerStockSettingsList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.PartnerStockSettings>? PartnerStockSettingsList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("customerCatalogList")]
		[Field("customerCatalogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.CustomerCatalog>? CustomerCatalogList;

		[JsonProperty("mainAddress")]
		[Field("mainAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? MainAddress;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("mainPartner")]
		[Field("mainPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? MainPartner;

		[JsonProperty("partnerAddressList")]
		[Field("partnerAddressList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.PartnerAddress>? PartnerAddressList;

		[JsonProperty("mobilePhone")]
		[Field("mobilePhone", false, null, Int32.MaxValue)]
		public string? MobilePhone;

		[JsonProperty("partnerProductQualityRatingList")]
		[Field("partnerProductQualityRatingList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.PartnerProductQualityRating>? PartnerProductQualityRatingList;

		[JsonProperty("umrList")]
		[Field("umrList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Umr>? UmrList;

		[JsonProperty("factorizedCustomer")]
		[Field("factorizedCustomer", false, "False", Int32.MaxValue)]
		public bool? FactorizedCustomer;

		[JsonProperty("industrySector")]
		[Field("industrySector", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.IndustrySector? IndustrySector;

		[JsonProperty("supplierArrivalProductQty")]
		[Field("supplierArrivalProductQty", false, "0", Int32.MaxValue)]
		public decimal? SupplierArrivalProductQty;

		[JsonProperty("timeSlot")]
		[Field("timeSlot", false, null, Int32.MaxValue)]
		public string? TimeSlot;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("webSite")]
		[Field("webSite", false, null, Int32.MaxValue)]
		public string? WebSite;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("chargeBackPurchase")]
		[Field("chargeBackPurchase", false, "100", Int32.MaxValue)]
		public decimal? ChargeBackPurchase;

		[JsonProperty("partnerSeq")]
		[Field("partnerSeq", false, null, Int32.MaxValue)]
		public string? PartnerSeq;

		[JsonProperty("isIspmRequired")]
		[Field("isIspmRequired", false, "False", Int32.MaxValue)]
		public bool? IsIspmRequired;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("isProspect")]
		[Field("isProspect", false, "False", Int32.MaxValue)]
		public bool? IsProspect;

		[JsonProperty("parentPartner")]
		[Field("parentPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ParentPartner;

		[JsonProperty("reportsTo")]
		[Field("reportsTo", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ReportsTo;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("picture")]
		[Field("picture", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Picture;

		[JsonProperty("saleTurnover")]
		[Field("saleTurnover", false, "0", Int32.MaxValue)]
		public int? SaleTurnover;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("supplierQualityRatingSelect")]
		[Field("supplierQualityRatingSelect", false, "0", Int32.MaxValue)]
		public decimal? SupplierQualityRatingSelect;

		[JsonProperty("fiscalPosition")]
		[Field("fiscalPosition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

		[JsonProperty("isNeedingConformityCertificate")]
		[Field("isNeedingConformityCertificate", false, "False", Int32.MaxValue)]
		public bool? IsNeedingConformityCertificate;

		[JsonProperty("isSupplier")]
		[Field("isSupplier", false, "False", Int32.MaxValue)]
		public bool? IsSupplier;

		[JsonProperty("jobTitle")]
		[Field("jobTitle", false, null, Int32.MaxValue)]
		public string? JobTitle;

		[JsonProperty("language")]
		[Field("language", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Language? Language;

		[JsonProperty("partnerTypeSelect")]
		[Field("partnerTypeSelect", false, "0", Int32.MaxValue)]
		public int? PartnerTypeSelect;

		[JsonProperty("source")]
		[Field("source", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Source? Source;

		[JsonProperty("payerQuality")]
		[Field("payerQuality", false, "0", Int32.MaxValue)]
		public decimal? PayerQuality;

		[JsonProperty("titleSelect")]
		[Field("titleSelect", false, "0", Int32.MaxValue)]
		public int? TitleSelect;

		[JsonProperty("emailAddress")]
		[Field("emailAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAddress? EmailAddress;

		[JsonProperty("partnerCategory")]
		[Field("partnerCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PartnerCategory? PartnerCategory;

		[JsonProperty("supplierQualityRating")]
		[Field("supplierQualityRating", false, "0", Int32.MaxValue)]
		public decimal? SupplierQualityRating;

		[JsonProperty("freightCarrierMode")]
		[Field("freightCarrierMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("nbrEmployees")]
		[Field("nbrEmployees", false, "0", Int32.MaxValue)]
		public int? NbrEmployees;

		[JsonProperty("fixedPhone")]
		[Field("fixedPhone", false, null, Int32.MaxValue)]
		public string? FixedPhone;

		[JsonProperty("salePartnerPriceList")]
		[Field("salePartnerPriceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PartnerPriceList? SalePartnerPriceList;

		[JsonProperty("specificTaxNote")]
		[Field("specificTaxNote", false, null, Int32.MaxValue)]
		public string? SpecificTaxNote;

		[JsonProperty("blockingList")]
		[Field("blockingList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Blocking>? BlockingList;

		[JsonProperty("firstName")]
		[Field("firstName", false, null, Int32.MaxValue)]
		public string? FirstName;

		[JsonProperty("rejectCounter")]
		[Field("rejectCounter", false, "0", Int32.MaxValue)]
		public int? RejectCounter;

		[JsonProperty("simpleFullName")]
		[Field("simpleFullName", false, null, Int32.MaxValue)]
		public string? SimpleFullName;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("outPaymentMode")]
		[Field("outPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? OutPaymentMode;

		[JsonProperty("partnerAttrs")]
		[Field("partnerAttrs", false, null, Int32.MaxValue)]
		public string? PartnerAttrs;

		[JsonProperty("invoiceSendingFormatSelect")]
		[Field("invoiceSendingFormatSelect", false, null, Int32.MaxValue)]
		public string? InvoiceSendingFormatSelect;

		[JsonProperty("isContact")]
		[Field("isContact", false, "False", Int32.MaxValue)]
		public bool? IsContact;

		[JsonProperty("paymentDelay")]
		[Field("paymentDelay", false, "0", Int32.MaxValue)]
		public decimal? PaymentDelay;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("activeUmr")]
		[Field("activeUmr", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Umr? ActiveUmr;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("freightCarrierModeList")]
		[Field("freightCarrierModeList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.FreightCarrierMode>? FreightCarrierModeList;

		[JsonProperty("inPaymentMode")]
		[Field("inPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? InPaymentMode;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("purchaseOrderInformation")]
		[Field("purchaseOrderInformation", false, null, Int32.MaxValue)]
		public string? PurchaseOrderInformation;

		[JsonProperty("sellerCode")]
		[Field("sellerCode", false, null, Int32.MaxValue)]
		public string? SellerCode;

		[JsonProperty("freightCarrierCustomerAccountNumberList")]
		[Field("freightCarrierCustomerAccountNumberList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.FreightCarrierCustomerAccountNumber>? FreightCarrierCustomerAccountNumberList;

		[JsonProperty("isFactor")]
		[Field("isFactor", false, "False", Int32.MaxValue)]
		public bool? IsFactor;

		[JsonProperty("registrationCode")]
		[Field("registrationCode", false, null, Int32.MaxValue)]
		public string? RegistrationCode;

		[JsonProperty("companySet")]
		[Field("companySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

		[JsonProperty("department")]
		[Field("department", false, null, Int32.MaxValue)]
		public string? Department;

		[JsonProperty("saleOrderInformation")]
		[Field("saleOrderInformation", false, null, Int32.MaxValue)]
		public string? SaleOrderInformation;

		[JsonProperty("deliveryDelay")]
		[Field("deliveryDelay", false, "0", Int32.MaxValue)]
		public int? DeliveryDelay;

		[JsonProperty("supplierCatalogList")]
		[Field("supplierCatalogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.SupplierCatalog>? SupplierCatalogList;

		[JsonProperty("paymentCondition")]
		[Field("paymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[JsonProperty("contactAttrs")]
		[Field("contactAttrs", false, null, Int32.MaxValue)]
		public string? ContactAttrs;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("shipmentMode")]
		[Field("shipmentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[JsonProperty("bankDetailsList")]
		[Field("bankDetailsList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetailsList;

		[JsonProperty("isCustomer")]
		[Field("isCustomer", false, "False", Int32.MaxValue)]
		public bool? IsCustomer;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
