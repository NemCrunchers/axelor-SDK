using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountManagement")]
	public class AccountManagement : AxelorModel
	{
		[Field("productFamily")]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("purchaseTax")]
		public Axelor.Apps.Account.Db.Tax? PurchaseTax;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("purchaseAccount")]
		public Axelor.Apps.Account.Db.Account? PurchaseAccount;

		[Field("tax")]
		public Axelor.Apps.Account.Db.Tax? Tax;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[Field("cashAccount")]
		public Axelor.Apps.Account.Db.Account? CashAccount;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("purchFixedAssetsAccount")]
		public Axelor.Apps.Account.Db.Account? PurchFixedAssetsAccount;

		[Field("saleAccount")]
		public Axelor.Apps.Account.Db.Account? SaleAccount;

		[Field("saleTax")]
		public Axelor.Apps.Account.Db.Tax? SaleTax;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("fixedAssetCategory")]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

	}
}
