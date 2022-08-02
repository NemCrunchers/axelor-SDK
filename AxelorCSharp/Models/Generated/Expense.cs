using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.Expense")]
	public class Expense : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("paymentStatusSelect")]
		public int? PaymentStatusSelect;

		[Field("payrollPreparation")]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("ventilated")]
		public bool? Ventilated;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("companyCbSelect")]
		public int? CompanyCbSelect;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("move")]
		public Axelor.Apps.Account.Db.Move? Move;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("bankOrder")]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("multipleUsers")]
		public bool? MultipleUsers;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("refusedBy")]
		public Axelor.Auth.Db.User? RefusedBy;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("expenseSeq")]
		public string? ExpenseSeq;

		[Field("validatedBy")]
		public Axelor.Auth.Db.User? ValidatedBy;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
