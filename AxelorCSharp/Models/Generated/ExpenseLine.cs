using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.ExpenseLine")]
	public class ExpenseLine : AxelorModel
	{
		[JsonProperty("toInvoice")]
		[Field("toInvoice", false, "False", Int32.MaxValue)]
		public bool? ToInvoice;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("distance")]
		[Field("distance", false, "0", Int32.MaxValue)]
		public decimal? Distance;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("analyticMoveLineList")]
		[Field("analyticMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AnalyticMoveLine>? AnalyticMoveLineList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("kilometricExpense")]
		[Field("kilometricExpense", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Expense? KilometricExpense;

		[JsonProperty("totalTax")]
		[Field("totalTax", false, "0", Int32.MaxValue)]
		public decimal? TotalTax;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("justificationMetaFile")]
		[Field("justificationMetaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? JustificationMetaFile;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("generalExpense")]
		[Field("generalExpense", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Expense? GeneralExpense;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("toCity")]
		[Field("toCity", false, null, Int32.MaxValue)]
		public string? ToCity;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("expense")]
		[Field("expense", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Expense? Expense;

		[JsonProperty("untaxedAmount")]
		[Field("untaxedAmount", false, "0", Int32.MaxValue)]
		public decimal? UntaxedAmount;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("expenseDate")]
		[Field("expenseDate", true, null, Int32.MaxValue)]
		public DateTime? ExpenseDate;

		[JsonProperty("totalAmount")]
		[Field("totalAmount", true, "0", Int32.MaxValue)]
		public decimal? TotalAmount;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("fromCity")]
		[Field("fromCity", false, null, Int32.MaxValue)]
		public string? FromCity;

		[JsonProperty("kilometricAllowParam")]
		[Field("kilometricAllowParam", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.KilometricAllowParam? KilometricAllowParam;

		[JsonProperty("kilometricTypeSelect")]
		[Field("kilometricTypeSelect", false, "0", Int32.MaxValue)]
		public int? KilometricTypeSelect;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("expenseProduct")]
		[Field("expenseProduct", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? ExpenseProduct;

	}
}
