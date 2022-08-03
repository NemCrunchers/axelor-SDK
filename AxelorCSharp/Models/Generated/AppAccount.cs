using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppAccount")]
	public class AppAccount : AxelorModel
	{
		[JsonProperty("chequeInterbankCode")]
		[Field("chequeInterbankCode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCode? ChequeInterbankCode;

		[JsonProperty("manageAdvancePaymentInvoice")]
		[Field("manageAdvancePaymentInvoice", false, "True", Int32.MaxValue)]
		public bool? ManageAdvancePaymentInvoice;

		[JsonProperty("partnerBalConfigSelect")]
		[Field("partnerBalConfigSelect", false, "1", Int32.MaxValue)]
		public int? PartnerBalConfigSelect;

		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("manageAnalyticAccounting")]
		[Field("manageAnalyticAccounting", false, "False", Int32.MaxValue)]
		public bool? ManageAnalyticAccounting;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("paymentVouchersOnInvoice")]
		[Field("paymentVouchersOnInvoice", false, "False", Int32.MaxValue)]
		public bool? PaymentVouchersOnInvoice;

		[JsonProperty("payerQualityConfigLineList")]
		[Field("payerQualityConfigLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PayerQualityConfigLine>? PayerQualityConfigLineList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("analyticDistributionTypeSelect")]
		[Field("analyticDistributionTypeSelect", false, "1", Int32.MaxValue)]
		public int? AnalyticDistributionTypeSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("printReportOnVentilation")]
		[Field("printReportOnVentilation", false, "True", Int32.MaxValue)]
		public bool? PrintReportOnVentilation;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("manageFactors")]
		[Field("manageFactors", false, "False", Int32.MaxValue)]
		public bool? ManageFactors;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("transferAndDirectDebitInterbankCode")]
		[Field("transferAndDirectDebitInterbankCode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCode? TransferAndDirectDebitInterbankCode;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("manageCustomerCredit")]
		[Field("manageCustomerCredit", false, "False", Int32.MaxValue)]
		public bool? ManageCustomerCredit;

	}
}
