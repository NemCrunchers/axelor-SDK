using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ConfiguratorProdProcessLine")]
	public class ConfiguratorProdProcessLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("configuratorProdProcess")]
		[Field("configuratorProdProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ConfiguratorProdProcess? ConfiguratorProdProcess;

		[JsonProperty("minCapacityPerCycleFormula")]
		[Field("minCapacityPerCycleFormula", false, null, Int32.MaxValue)]
		public string? MinCapacityPerCycleFormula;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("maxCapacityPerCycle")]
		[Field("maxCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MaxCapacityPerCycle;

		[JsonProperty("defMinCapacityFormula")]
		[Field("defMinCapacityFormula", false, "False", Int32.MaxValue)]
		public bool? DefMinCapacityFormula;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("defDurationFormula")]
		[Field("defDurationFormula", false, "False", Int32.MaxValue)]
		public bool? DefDurationFormula;

		[JsonProperty("defMaxCapacityFormula")]
		[Field("defMaxCapacityFormula", false, "False", Int32.MaxValue)]
		public bool? DefMaxCapacityFormula;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("durationPerCycle")]
		[Field("durationPerCycle", false, "0", Int32.MaxValue)]
		public long? DurationPerCycle;

		[JsonProperty("durationPerCycleFormula")]
		[Field("durationPerCycleFormula", false, null, Int32.MaxValue)]
		public string? DurationPerCycleFormula;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("workCenter")]
		[Field("workCenter", true, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("maxCapacityPerCycleFormula")]
		[Field("maxCapacityPerCycleFormula", false, null, Int32.MaxValue)]
		public string? MaxCapacityPerCycleFormula;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("minCapacityPerCycle")]
		[Field("minCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MinCapacityPerCycle;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("outsourcing")]
		[Field("outsourcing", false, "False", Int32.MaxValue)]
		public bool? Outsourcing;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

	}
}
