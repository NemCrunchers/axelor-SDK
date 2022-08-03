using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.FixedAssetCategory")]
	public class FixedAssetCategory : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("periodicityInMonth")]
		[Field("periodicityInMonth", false, "12", Int32.MaxValue)]
		public int? PeriodicityInMonth;

		[JsonProperty("chargeAccount")]
		[Field("chargeAccount", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ChargeAccount;

		[JsonProperty("isProrataTemporis")]
		[Field("isProrataTemporis", false, "False", Int32.MaxValue)]
		public bool? IsProrataTemporis;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("degressiveCoef")]
		[Field("degressiveCoef", false, "0", Int32.MaxValue)]
		public decimal? DegressiveCoef;

		[JsonProperty("durationInMonth")]
		[Field("durationInMonth", false, "0", Int32.MaxValue)]
		public int? DurationInMonth;

		[JsonProperty("fixedAssetType")]
		[Field("fixedAssetType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FixedAssetType? FixedAssetType;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("journal")]
		[Field("journal", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("computationMethodSelect")]
		[Field("computationMethodSelect", false, null, Int32.MaxValue)]
		public string? ComputationMethodSelect;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isValidateFixedAsset")]
		[Field("isValidateFixedAsset", false, "False", Int32.MaxValue)]
		public bool? IsValidateFixedAsset;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("numberOfDepreciation")]
		[Field("numberOfDepreciation", false, "1", Int32.MaxValue)]
		public int? NumberOfDepreciation;

		[JsonProperty("depreciationAccount")]
		[Field("depreciationAccount", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? DepreciationAccount;

	}
}
