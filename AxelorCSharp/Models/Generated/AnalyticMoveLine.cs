using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AnalyticMoveLine")]
	public class AnalyticMoveLine : AxelorModel
	{
		[Field("analyticJournal")]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("analyticAxis")]
		public Axelor.Apps.Account.Db.AnalyticAxis? AnalyticAxis;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("invoiceLine")]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[Field("id")]
		public long? Id;

		[Field("expenseLine")]
		public Axelor.Apps.Hr.Db.ExpenseLine? ExpenseLine;

		[Field("saleOrderLine")]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("moveLine")]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[Field("accountType")]
		public Axelor.Apps.Account.Db.AccountType? AccountType;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("purchaseOrderLine")]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("analyticAccount")]
		public Axelor.Apps.Account.Db.AnalyticAccount? AnalyticAccount;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
