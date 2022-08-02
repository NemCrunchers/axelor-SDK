using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.WorkCenter")]
	public class WorkCenter : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("parentWorkCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? ParentWorkCenter;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("costSheetGroup")]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[Field("operationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? OperationOrder;

		[Field("id")]
		public long? Id;

		[Field("isRevaluationAtActualPrices")]
		public bool? IsRevaluationAtActualPrices;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("durationPerCycle")]
		public long? DurationPerCycle;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("workCenterTypeSelect")]
		public int? WorkCenterTypeSelect;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("costTypeSelect")]
		public int? CostTypeSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("machine")]
		public Axelor.Apps.Production.Db.Machine? Machine;

		[Field("name")]
		public string? Name;

	}
}
