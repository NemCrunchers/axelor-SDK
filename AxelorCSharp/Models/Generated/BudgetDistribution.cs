using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.BudgetDistribution")]
	public class BudgetDistribution : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("purchaseOrderLine")]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoiceLine")]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[Field("id")]
		public long? Id;

		[Field("budget")]
		public Axelor.Apps.Account.Db.Budget? Budget;

	}
}
