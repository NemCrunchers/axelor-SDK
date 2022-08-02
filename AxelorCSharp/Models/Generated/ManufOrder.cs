using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ManufOrder")]
	public class ManufOrder : AxelorModel
	{
		[Field("plannedStartDateT")]
		public DateTime? PlannedStartDateT;

		[Field("workshopStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[Field("id")]
		public long? Id;

		[Field("plannedEndDateT")]
		public DateTime? PlannedEndDateT;

		[Field("manufOrderSeq")]
		public string? ManufOrderSeq;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("wasteStockMove")]
		public Axelor.Apps.Stock.Db.StockMove? WasteStockMove;

		[Field("billOfMaterial")]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[Field("prioritySelect")]
		public int? PrioritySelect;

		[Field("realStartDateT")]
		public DateTime? RealStartDateT;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("isPermanent")]
		public bool? IsPermanent;

		[Field("prodProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[Field("realEndDateT")]
		public DateTime? RealEndDateT;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("clientPartner")]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("productionOrder")]
		public Axelor.Apps.Production.Db.ProductionOrder? ProductionOrder;

		[Field("archived")]
		public bool? Archived;

		[Field("isToInvoice")]
		public bool? IsToInvoice;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("cancelReason")]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("isConsProOnOperation")]
		public bool? IsConsProOnOperation;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
