using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.CostSheet")]
	public class CostSheet : AxelorModel
	{
		[JsonProperty("manufOrderProducedRatio")]
		[Field("manufOrderProducedRatio", false, "0", Int32.MaxValue)]
		public decimal? ManufOrderProducedRatio;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("billOfMaterial")]
		[Field("billOfMaterial", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[JsonProperty("costPrice")]
		[Field("costPrice", false, "0", Int32.MaxValue)]
		public decimal? CostPrice;

		[JsonProperty("costSheetLineList")]
		[Field("costSheetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.CostSheetLine>? CostSheetLineList;

		[JsonProperty("manufOrder")]
		[Field("manufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("calculationDate")]
		[Field("calculationDate", false, null, Int32.MaxValue)]
		public DateTime? CalculationDate;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("calculationTypeSelect")]
		[Field("calculationTypeSelect", false, "0", Int32.MaxValue)]
		public int? CalculationTypeSelect;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
