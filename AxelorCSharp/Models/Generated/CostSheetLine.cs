using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.CostSheetLine")]
	public class CostSheetLine : AxelorModel
	{
		[JsonProperty("bomLevel")]
		[Field("bomLevel", false, "0", Int32.MaxValue)]
		public int? BomLevel;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("unitCostPrice")]
		[Field("unitCostPrice", false, "0", Int32.MaxValue)]
		public decimal? UnitCostPrice;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("costSheetGroup")]
		[Field("costSheetGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[JsonProperty("typeSelectIcon")]
		[Field("typeSelectIcon", false, "0", Int32.MaxValue)]
		public int? TypeSelectIcon;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("parentCostSheetLine")]
		[Field("parentCostSheetLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetLine? ParentCostSheetLine;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("costPrice")]
		[Field("costPrice", false, "0", Int32.MaxValue)]
		public decimal? CostPrice;

		[JsonProperty("costSheet")]
		[Field("costSheet", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheet? CostSheet;

		[JsonProperty("costSheetLineList")]
		[Field("costSheetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.CostSheetLine>? CostSheetLineList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("workCenter")]
		[Field("workCenter", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("consumptionQty")]
		[Field("consumptionQty", false, "0", Int32.MaxValue)]
		public decimal? ConsumptionQty;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("ratio")]
		[Field("ratio", false, "0", Int32.MaxValue)]
		public decimal? Ratio;

	}
}
