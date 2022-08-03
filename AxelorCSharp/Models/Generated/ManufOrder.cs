using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ManufOrder")]
	public class ManufOrder : AxelorModel
	{
		[JsonProperty("wasteProdProductList")]
		[Field("wasteProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? WasteProdProductList;

		[JsonProperty("plannedStartDateT")]
		[Field("plannedStartDateT", false, null, Int32.MaxValue)]
		public DateTime? PlannedStartDateT;

		[JsonProperty("producedStockMoveLineList")]
		[Field("producedStockMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? ProducedStockMoveLineList;

		[JsonProperty("operationOrderList")]
		[Field("operationOrderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.OperationOrder>? OperationOrderList;

		[JsonProperty("workshopStockLocation")]
		[Field("workshopStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[JsonProperty("diffConsumeProdProductList")]
		[Field("diffConsumeProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? DiffConsumeProdProductList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("plannedEndDateT")]
		[Field("plannedEndDateT", false, null, Int32.MaxValue)]
		public DateTime? PlannedEndDateT;

		[JsonProperty("manufOrderSeq")]
		[Field("manufOrderSeq", false, null, Int32.MaxValue)]
		public string? ManufOrderSeq;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("wasteStockMove")]
		[Field("wasteStockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? WasteStockMove;

		[JsonProperty("billOfMaterial")]
		[Field("billOfMaterial", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "2", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("realStartDateT")]
		[Field("realStartDateT", false, null, Int32.MaxValue)]
		public DateTime? RealStartDateT;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("inStockMoveList")]
		[Field("inStockMoveList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMove>? InStockMoveList;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isPermanent")]
		[Field("isPermanent", false, "False", Int32.MaxValue)]
		public bool? IsPermanent;

		[JsonProperty("prodProcess")]
		[Field("prodProcess", true, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[JsonProperty("realEndDateT")]
		[Field("realEndDateT", false, null, Int32.MaxValue)]
		public DateTime? RealEndDateT;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("clientPartner")]
		[Field("clientPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("endTimeDifference")]
		[Field("endTimeDifference", false, "0", Int32.MaxValue)]
		public decimal? EndTimeDifference;

		[JsonProperty("toConsumeProdProductList")]
		[Field("toConsumeProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? ToConsumeProdProductList;

		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("costSheetList")]
		[Field("costSheetList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.CostSheet>? CostSheetList;

		[JsonProperty("timesheetLine")]
		[Field("timesheetLine", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? TimesheetLine;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("productionOrder")]
		[Field("productionOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProductionOrder? ProductionOrder;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("wasteProdDescription")]
		[Field("wasteProdDescription", false, null, Int32.MaxValue)]
		public string? WasteProdDescription;

		[JsonProperty("cancelReasonStr")]
		[Field("cancelReasonStr", false, null, Int32.MaxValue)]
		public string? CancelReasonStr;

		[JsonProperty("isToInvoice")]
		[Field("isToInvoice", false, "False", Int32.MaxValue)]
		public bool? IsToInvoice;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("cancelReason")]
		[Field("cancelReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[JsonProperty("outStockMoveList")]
		[Field("outStockMoveList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMove>? OutStockMoveList;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("costPrice")]
		[Field("costPrice", false, "0", Int32.MaxValue)]
		public decimal? CostPrice;

		[JsonProperty("consumedStockMoveLineList")]
		[Field("consumedStockMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? ConsumedStockMoveLineList;

		[JsonProperty("isConsProOnOperation")]
		[Field("isConsProOnOperation", false, "False", Int32.MaxValue)]
		public bool? IsConsProOnOperation;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("toProduceProdProductList")]
		[Field("toProduceProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? ToProduceProdProductList;

	}
}
