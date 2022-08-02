using Axelor.SDK;

namespace Axelor.Apps.Businessproject.Db
{
	[Model("com.axelor.apps.businessproject.db.InvoicingProject")]
	public class InvoicingProject : AxelorModel
	{
		[Field("teamTaskSet")]
		public IEnumerable<Axelor.Team.Db.TeamTask>? TeamTaskSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("projectSetPrioritySelect")]
		public int? ProjectSetPrioritySelect;

		[Field("purchaseOrderLineSetPrioritySelect")]
		public int? PurchaseOrderLineSetPrioritySelect;

		[Field("logTimesSetPrioritySelect")]
		public int? LogTimesSetPrioritySelect;

		[Field("saleOrderLineSet")]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineSet;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("logTimesSet")]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? LogTimesSet;

		[Field("expenseLineSet")]
		public IEnumerable<Axelor.Apps.Hr.Db.ExpenseLine>? ExpenseLineSet;

		[Field("id")]
		public long? Id;

		[Field("projectSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? ProjectSet;

		[Field("manufOrderSet")]
		public IEnumerable<Axelor.Apps.Production.Db.ManufOrder>? ManufOrderSet;

		[Field("teamTaskSetPrioritySelect")]
		public int? TeamTaskSetPrioritySelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("expenseLineSetPrioritySelect")]
		public int? ExpenseLineSetPrioritySelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("purchaseOrderLineSet")]
		public IEnumerable<Axelor.Apps.Purchase.Db.PurchaseOrderLine>? PurchaseOrderLineSet;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("saleOrderLineSetPrioritySelect")]
		public int? SaleOrderLineSetPrioritySelect;

	}
}
