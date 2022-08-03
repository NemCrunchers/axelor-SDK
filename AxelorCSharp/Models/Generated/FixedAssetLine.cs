using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.FixedAssetLine")]
	public class FixedAssetLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("depreciationDate")]
		[Field("depreciationDate", false, null, Int32.MaxValue)]
		public DateTime? DepreciationDate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("residualValue")]
		[Field("residualValue", false, "0", Int32.MaxValue)]
		public decimal? ResidualValue;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("cumulativeDepreciation")]
		[Field("cumulativeDepreciation", false, "0", Int32.MaxValue)]
		public decimal? CumulativeDepreciation;

		[JsonProperty("depreciationAccountMove")]
		[Field("depreciationAccountMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? DepreciationAccountMove;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("fixedAsset")]
		[Field("fixedAsset", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FixedAsset? FixedAsset;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("depreciation")]
		[Field("depreciation", false, "0", Int32.MaxValue)]
		public decimal? Depreciation;

	}
}
