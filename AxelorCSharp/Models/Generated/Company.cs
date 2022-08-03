using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Company")]
	public class Company : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Parent;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("notes")]
		[Field("notes", false, null, Int32.MaxValue)]
		public string? Notes;

		[JsonProperty("hrConfig")]
		[Field("hrConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.HRConfig? HrConfig;

		[JsonProperty("supplierPaymentDelay")]
		[Field("supplierPaymentDelay", false, "0", Int32.MaxValue)]
		public decimal? SupplierPaymentDelay;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("saleConfig")]
		[Field("saleConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleConfig? SaleConfig;

		[JsonProperty("bankDetailsSet")]
		[Field("bankDetailsSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetailsSet;

		[JsonProperty("tradingNameSet")]
		[Field("tradingNameSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.TradingName>? TradingNameSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankPaymentConfig")]
		[Field("bankPaymentConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankPaymentConfig? BankPaymentConfig;

		[JsonProperty("printingSettings")]
		[Field("printingSettings", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[JsonProperty("productionConfig")]
		[Field("productionConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProductionConfig? ProductionConfig;

		[JsonProperty("logo")]
		[Field("logo", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Logo;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("stockConfig")]
		[Field("stockConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockConfig? StockConfig;

		[JsonProperty("address")]
		[Field("address", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? Address;

		[JsonProperty("defaultBankDetails")]
		[Field("defaultBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? DefaultBankDetails;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("orderBloquedMessage")]
		[Field("orderBloquedMessage", false, null, Int32.MaxValue)]
		public string? OrderBloquedMessage;

		[JsonProperty("crmConfig")]
		[Field("crmConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.CrmConfig? CrmConfig;

		[JsonProperty("defaultPartnerTypeSelect")]
		[Field("defaultPartnerTypeSelect", false, "1", Int32.MaxValue)]
		public int? DefaultPartnerTypeSelect;

		[JsonProperty("publicHolidayEventsPlanning")]
		[Field("publicHolidayEventsPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("weeklyPlanning")]
		[Field("weeklyPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("tradingNamePrintingSettingsList")]
		[Field("tradingNamePrintingSettingsList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.TradingNamePrintingSettings>? TradingNamePrintingSettingsList;

		[JsonProperty("accountConfig")]
		[Field("accountConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountConfig? AccountConfig;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("customerPaymentDelay")]
		[Field("customerPaymentDelay", false, "0", Int32.MaxValue)]
		public decimal? CustomerPaymentDelay;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("purchaseConfig")]
		[Field("purchaseConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseConfig? PurchaseConfig;

		[JsonProperty("companyDepartmentList")]
		[Field("companyDepartmentList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.CompanyDepartment>? CompanyDepartmentList;

		[JsonProperty("supplyChainConfig")]
		[Field("supplyChainConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Supplychain.Db.SupplyChainConfig? SupplyChainConfig;

	}
}
