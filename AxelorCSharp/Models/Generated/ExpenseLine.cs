using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.ExpenseLine")]
	public class ExpenseLine : AxelorModel
	{
		[Field("toInvoice")]
		public bool? ToInvoice;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("kilometricExpense")]
		public Axelor.Apps.Hr.Db.Expense? KilometricExpense;

		[Field("archived")]
		public bool? Archived;

		[Field("justificationMetaFile")]
		public Axelor.Meta.Db.MetaFile? JustificationMetaFile;

		[Field("id")]
		public long? Id;

		[Field("generalExpense")]
		public Axelor.Apps.Hr.Db.Expense? GeneralExpense;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("toCity")]
		public string? ToCity;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("expense")]
		public Axelor.Apps.Hr.Db.Expense? Expense;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("fromCity")]
		public string? FromCity;

		[Field("kilometricAllowParam")]
		public Axelor.Apps.Hr.Db.KilometricAllowParam? KilometricAllowParam;

		[Field("kilometricTypeSelect")]
		public int? KilometricTypeSelect;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("expenseProduct")]
		public Axelor.Apps.Base.Db.Product? ExpenseProduct;

	}
}
