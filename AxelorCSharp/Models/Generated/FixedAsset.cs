using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.FixedAsset")]
	public class FixedAsset : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("durationInMonth")]
		public int? DurationInMonth;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("computationMethodSelect")]
		public string? ComputationMethodSelect;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("invoiceLine")]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("periodicityInMonth")]
		public int? PeriodicityInMonth;

		[Field("purchaseAccount")]
		public Axelor.Apps.Account.Db.Account? PurchaseAccount;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("fixedAssetCategory")]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

		[Field("numberOfDepreciation")]
		public int? NumberOfDepreciation;

	}
}
