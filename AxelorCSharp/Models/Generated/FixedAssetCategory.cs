using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.FixedAssetCategory")]
	public class FixedAssetCategory : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("periodicityInMonth")]
		public int? PeriodicityInMonth;

		[Field("chargeAccount")]
		public Axelor.Apps.Account.Db.Account? ChargeAccount;

		[Field("isProrataTemporis")]
		public bool? IsProrataTemporis;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("durationInMonth")]
		public int? DurationInMonth;

		[Field("fixedAssetType")]
		public Axelor.Apps.Account.Db.FixedAssetType? FixedAssetType;

		[Field("importId")]
		public string? ImportId;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("computationMethodSelect")]
		public string? ComputationMethodSelect;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isValidateFixedAsset")]
		public bool? IsValidateFixedAsset;

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("numberOfDepreciation")]
		public int? NumberOfDepreciation;

		[Field("depreciationAccount")]
		public Axelor.Apps.Account.Db.Account? DepreciationAccount;

	}
}
