using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AnalyticMoveLine")]
	public class AnalyticMoveLine : AxelorModel
	{
		[JsonProperty("analyticJournal")]
		[Field("analyticJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[JsonProperty("date")]
		[Field("date", false, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("analyticAxis")]
		[Field("analyticAxis", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticAxis? AnalyticAxis;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "1", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("percentage")]
		[Field("percentage", false, "0", Int32.MaxValue)]
		public decimal? Percentage;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("invoiceLine")]
		[Field("invoiceLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("originalPieceAmount")]
		[Field("originalPieceAmount", false, "0", Int32.MaxValue)]
		public decimal? OriginalPieceAmount;

		[JsonProperty("expenseLine")]
		[Field("expenseLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.ExpenseLine? ExpenseLine;

		[JsonProperty("amount")]
		[Field("amount", false, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("saleOrderLine")]
		[Field("saleOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("moveLine")]
		[Field("moveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[JsonProperty("accountType")]
		[Field("accountType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountType? AccountType;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("purchaseOrderLine")]
		[Field("purchaseOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("analyticAccount")]
		[Field("analyticAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticAccount? AnalyticAccount;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("account")]
		[Field("account", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
