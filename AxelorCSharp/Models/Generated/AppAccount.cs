using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppAccount")]
	public class AppAccount : AxelorModel
	{
		[Field("chequeInterbankCode")]
		public Axelor.Apps.Account.Db.InterbankCode? ChequeInterbankCode;

		[Field("manageAdvancePaymentInvoice")]
		public bool? ManageAdvancePaymentInvoice;

		[Field("partnerBalConfigSelect")]
		public int? PartnerBalConfigSelect;

		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("manageAnalyticAccounting")]
		public bool? ManageAnalyticAccounting;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("paymentVouchersOnInvoice")]
		public bool? PaymentVouchersOnInvoice;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("analyticDistributionTypeSelect")]
		public int? AnalyticDistributionTypeSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("printReportOnVentilation")]
		public bool? PrintReportOnVentilation;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("manageFactors")]
		public bool? ManageFactors;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("transferAndDirectDebitInterbankCode")]
		public Axelor.Apps.Account.Db.InterbankCode? TransferAndDirectDebitInterbankCode;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("manageCustomerCredit")]
		public bool? ManageCustomerCredit;

	}
}
