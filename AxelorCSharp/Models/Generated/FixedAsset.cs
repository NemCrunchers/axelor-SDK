using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.FixedAsset")]
	public class FixedAsset : AxelorModel
	{
		[JsonProperty("acquisitionDate")]
		[Field("acquisitionDate", false, null, Int32.MaxValue)]
		public DateTime? AcquisitionDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("residualValue")]
		[Field("residualValue", false, "0", Int32.MaxValue)]
		public decimal? ResidualValue;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("durationInMonth")]
		[Field("durationInMonth", false, "0", Int32.MaxValue)]
		public int? DurationInMonth;

		[JsonProperty("journal")]
		[Field("journal", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("computationMethodSelect")]
		[Field("computationMethodSelect", false, null, Int32.MaxValue)]
		public string? ComputationMethodSelect;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("invoiceLine")]
		[Field("invoiceLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("firstDepreciationDate")]
		[Field("firstDepreciationDate", false, null, Int32.MaxValue)]
		public DateTime? FirstDepreciationDate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("periodicityInMonth")]
		[Field("periodicityInMonth", false, "12", Int32.MaxValue)]
		public int? PeriodicityInMonth;

		[JsonProperty("purchaseAccount")]
		[Field("purchaseAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? PurchaseAccount;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("disposalValue")]
		[Field("disposalValue", false, "0", Int32.MaxValue)]
		public decimal? DisposalValue;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("degressiveCoef")]
		[Field("degressiveCoef", false, "0", Int32.MaxValue)]
		public decimal? DegressiveCoef;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("fixedAssetLineList")]
		[Field("fixedAssetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.FixedAssetLine>? FixedAssetLineList;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("grossValue")]
		[Field("grossValue", false, "0", Int32.MaxValue)]
		public decimal? GrossValue;

		[JsonProperty("disposalDate")]
		[Field("disposalDate", false, null, Int32.MaxValue)]
		public DateTime? DisposalDate;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("fixedAssetCategory")]
		[Field("fixedAssetCategory", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

		[JsonProperty("numberOfDepreciation")]
		[Field("numberOfDepreciation", false, "1", Int32.MaxValue)]
		public int? NumberOfDepreciation;

	}
}
