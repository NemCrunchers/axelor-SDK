using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.OperationOrder")]
	public class OperationOrder : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("prodProcessLine")]
		[Field("prodProcessLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcessLine? ProdProcessLine;

		[JsonProperty("plannedStartDateT")]
		[Field("plannedStartDateT", false, null, Int32.MaxValue)]
		public DateTime? PlannedStartDateT;

		[JsonProperty("operationOrderDurationList")]
		[Field("operationOrderDurationList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.OperationOrderDuration>? OperationOrderDurationList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("diffConsumeProdProductList")]
		[Field("diffConsumeProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? DiffConsumeProdProductList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("isToInvoice")]
		[Field("isToInvoice", false, "False", Int32.MaxValue)]
		public bool? IsToInvoice;

		[JsonProperty("plannedDuration")]
		[Field("plannedDuration", false, "0", Int32.MaxValue)]
		public long? PlannedDuration;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("plannedEndDateT")]
		[Field("plannedEndDateT", false, null, Int32.MaxValue)]
		public DateTime? PlannedEndDateT;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("timesheetLineList")]
		[Field("timesheetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? TimesheetLineList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("manufOrder")]
		[Field("manufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[JsonProperty("prodHumanResourceList")]
		[Field("prodHumanResourceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdHumanResource>? ProdHumanResourceList;

		[JsonProperty("operationName")]
		[Field("operationName", false, null, Int32.MaxValue)]
		public string? OperationName;

		[JsonProperty("realStartDateT")]
		[Field("realStartDateT", false, null, Int32.MaxValue)]
		public DateTime? RealStartDateT;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("consumedStockMoveLineList")]
		[Field("consumedStockMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? ConsumedStockMoveLineList;

		[JsonProperty("inStockMoveList")]
		[Field("inStockMoveList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMove>? InStockMoveList;

		[JsonProperty("isWithDifference")]
		[Field("isWithDifference", false, null, Int32.MaxValue)]
		public bool? IsWithDifference;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("workCenter")]
		[Field("workCenter", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("barCode")]
		[Field("barCode", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? BarCode;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("realEndDateT")]
		[Field("realEndDateT", false, null, Int32.MaxValue)]
		public DateTime? RealEndDateT;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("realDuration")]
		[Field("realDuration", false, "0", Int32.MaxValue)]
		public long? RealDuration;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("toConsumeProdProductList")]
		[Field("toConsumeProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? ToConsumeProdProductList;

		[JsonProperty("machineWorkCenter")]
		[Field("machineWorkCenter", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? MachineWorkCenter;

	}
}
