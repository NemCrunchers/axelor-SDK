using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AccountManagement")]
	public class AccountManagement : AxelorModel
	{
		[JsonProperty("productFamily")]
		[Field("productFamily", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("journal")]
		[Field("journal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("purchaseTax")]
		[Field("purchaseTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? PurchaseTax;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("purchaseAccount")]
		[Field("purchaseAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? PurchaseAccount;

		[JsonProperty("tax")]
		[Field("tax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? Tax;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[JsonProperty("cashAccount")]
		[Field("cashAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? CashAccount;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("purchFixedAssetsAccount")]
		[Field("purchFixedAssetsAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? PurchFixedAssetsAccount;

		[JsonProperty("saleAccount")]
		[Field("saleAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? SaleAccount;

		[JsonProperty("saleTax")]
		[Field("saleTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? SaleTax;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("fixedAssetCategory")]
		[Field("fixedAssetCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

	}
}
