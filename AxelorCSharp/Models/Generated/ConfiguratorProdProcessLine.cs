using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ConfiguratorProdProcessLine")]
	public class ConfiguratorProdProcessLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("configuratorProdProcess")]
		public Axelor.Apps.Production.Db.ConfiguratorProdProcess? ConfiguratorProdProcess;

		[Field("minCapacityPerCycleFormula")]
		public string? MinCapacityPerCycleFormula;

		[Field("archived")]
		public bool? Archived;

		[Field("defMinCapacityFormula")]
		public bool? DefMinCapacityFormula;

		[Field("id")]
		public long? Id;

		[Field("defDurationFormula")]
		public bool? DefDurationFormula;

		[Field("defMaxCapacityFormula")]
		public bool? DefMaxCapacityFormula;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("durationPerCycle")]
		public long? DurationPerCycle;

		[Field("durationPerCycleFormula")]
		public string? DurationPerCycleFormula;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("version")]
		public int? Version;

		[Field("workCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[Field("attrs")]
		public string? Attrs;

		[Field("maxCapacityPerCycleFormula")]
		public string? MaxCapacityPerCycleFormula;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("outsourcing")]
		public bool? Outsourcing;

		[Field("name")]
		public string? Name;

	}
}
