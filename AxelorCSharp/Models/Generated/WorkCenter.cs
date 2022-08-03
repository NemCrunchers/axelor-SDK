using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.WorkCenter")]
	public class WorkCenter : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("parentWorkCenter")]
		[Field("parentWorkCenter", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? ParentWorkCenter;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("costSheetGroup")]
		[Field("costSheetGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[JsonProperty("maxCapacityPerCycle")]
		[Field("maxCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MaxCapacityPerCycle;

		[JsonProperty("operationOrder")]
		[Field("operationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? OperationOrder;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isRevaluationAtActualPrices")]
		[Field("isRevaluationAtActualPrices", false, "False", Int32.MaxValue)]
		public bool? IsRevaluationAtActualPrices;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("durationPerCycle")]
		[Field("durationPerCycle", false, "0", Int32.MaxValue)]
		public long? DurationPerCycle;

		[JsonProperty("costAmount")]
		[Field("costAmount", false, "0", Int32.MaxValue)]
		public decimal? CostAmount;

		[JsonProperty("prodHumanResourceList")]
		[Field("prodHumanResourceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdHumanResource>? ProdHumanResourceList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("workCenterTypeSelect")]
		[Field("workCenterTypeSelect", false, "0", Int32.MaxValue)]
		public int? WorkCenterTypeSelect;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("workCenterList")]
		[Field("workCenterList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.WorkCenter>? WorkCenterList;

		[JsonProperty("costTypeSelect")]
		[Field("costTypeSelect", false, "0", Int32.MaxValue)]
		public int? CostTypeSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("minCapacityPerCycle")]
		[Field("minCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MinCapacityPerCycle;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("machine")]
		[Field("machine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.Machine? Machine;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

	}
}
