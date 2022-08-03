using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Businessproject.Db
{
	[Serializable]
	[Model("com.axelor.apps.businessproject.db.InvoicingProject")]
	public class InvoicingProject : AxelorModel
	{
		[JsonProperty("teamTaskSet")]
		[Field("teamTaskSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.TeamTask>? TeamTaskSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("projectSetPrioritySelect")]
		[Field("projectSetPrioritySelect", false, "5", Int32.MaxValue)]
		public int? ProjectSetPrioritySelect;

		[JsonProperty("purchaseOrderLineSetPrioritySelect")]
		[Field("purchaseOrderLineSetPrioritySelect", false, "2", Int32.MaxValue)]
		public int? PurchaseOrderLineSetPrioritySelect;

		[JsonProperty("logTimesSetPrioritySelect")]
		[Field("logTimesSetPrioritySelect", false, "3", Int32.MaxValue)]
		public int? LogTimesSetPrioritySelect;

		[JsonProperty("saleOrderLineSet")]
		[Field("saleOrderLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineSet;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("logTimesSet")]
		[Field("logTimesSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? LogTimesSet;

		[JsonProperty("expenseLineSet")]
		[Field("expenseLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.ExpenseLine>? ExpenseLineSet;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("projectSet")]
		[Field("projectSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? ProjectSet;

		[JsonProperty("manufOrderSet")]
		[Field("manufOrderSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ManufOrder>? ManufOrderSet;

		[JsonProperty("teamTaskSetPrioritySelect")]
		[Field("teamTaskSetPrioritySelect", false, "6", Int32.MaxValue)]
		public int? TeamTaskSetPrioritySelect;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("deadlineDate")]
		[Field("deadlineDate", false, null, Int32.MaxValue)]
		public DateTime? DeadlineDate;

		[JsonProperty("expenseLineSetPrioritySelect")]
		[Field("expenseLineSetPrioritySelect", false, "4", Int32.MaxValue)]
		public int? ExpenseLineSetPrioritySelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("purchaseOrderLineSet")]
		[Field("purchaseOrderLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.PurchaseOrderLine>? PurchaseOrderLineSet;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("saleOrderLineSetPrioritySelect")]
		[Field("saleOrderLineSetPrioritySelect", false, "1", Int32.MaxValue)]
		public int? SaleOrderLineSetPrioritySelect;

	}
}
