using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.MrpLine")]
	public class MrpLine : AxelorModel
	{
		[JsonProperty("maxLevel")]
		[Field("maxLevel", false, "0", Int32.MaxValue)]
		public int? MaxLevel;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("proposalGenerated")]
		[Field("proposalGenerated", true, "False", Int32.MaxValue)]
		public bool? ProposalGenerated;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("relatedToSelectName")]
		[Field("relatedToSelectName", false, null, Int32.MaxValue)]
		public string? RelatedToSelectName;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("proposalSelectId")]
		[Field("proposalSelectId", false, "0", Int32.MaxValue)]
		public long? ProposalSelectId;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("maturityDate")]
		[Field("maturityDate", false, null, Int32.MaxValue)]
		public DateTime? MaturityDate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("mrpLineType")]
		[Field("mrpLineType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Supplychain.Db.MrpLineType? MrpLineType;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("cumulativeQty")]
		[Field("cumulativeQty", false, "0", Int32.MaxValue)]
		public decimal? CumulativeQty;

		[JsonProperty("mrpLineOriginList")]
		[Field("mrpLineOriginList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Supplychain.Db.MrpLineOrigin>? MrpLineOriginList;

		[JsonProperty("mrp")]
		[Field("mrp", false, null, Int32.MaxValue)]
		public Axelor.Apps.Supplychain.Db.Mrp? Mrp;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("proposalSelect")]
		[Field("proposalSelect", false, null, Int32.MaxValue)]
		public string? ProposalSelect;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

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

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("minQty")]
		[Field("minQty", false, "0", Int32.MaxValue)]
		public decimal? MinQty;

	}
}
