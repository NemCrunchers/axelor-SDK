using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.Expense")]
	public class Expense : AxelorModel
	{
		[JsonProperty("advanceAmount")]
		[Field("advanceAmount", false, "0", Int32.MaxValue)]
		public decimal? AdvanceAmount;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("paymentStatusSelect")]
		[Field("paymentStatusSelect", false, "0", Int32.MaxValue)]
		public int? PaymentStatusSelect;

		[JsonProperty("payrollPreparation")]
		[Field("payrollPreparation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[JsonProperty("validationDate")]
		[Field("validationDate", false, null, Int32.MaxValue)]
		public DateTime? ValidationDate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("paymentAmount")]
		[Field("paymentAmount", false, "0", Int32.MaxValue)]
		public decimal? PaymentAmount;

		[JsonProperty("withdrawnCash")]
		[Field("withdrawnCash", false, "0", Int32.MaxValue)]
		public decimal? WithdrawnCash;

		[JsonProperty("ventilated")]
		[Field("ventilated", false, "False", Int32.MaxValue)]
		public bool? Ventilated;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("companyCbSelect")]
		[Field("companyCbSelect", false, "1", Int32.MaxValue)]
		public int? CompanyCbSelect;

		[JsonProperty("sentDate")]
		[Field("sentDate", false, null, Int32.MaxValue)]
		public DateTime? SentDate;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("generalExpenseLineList")]
		[Field("generalExpenseLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.ExpenseLine>? GeneralExpenseLineList;

		[JsonProperty("moveDate")]
		[Field("moveDate", false, null, Int32.MaxValue)]
		public DateTime? MoveDate;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("move")]
		[Field("move", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? Move;

		[JsonProperty("period")]
		[Field("period", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("bankOrder")]
		[Field("bankOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("personalExpenseAmount")]
		[Field("personalExpenseAmount", false, "0", Int32.MaxValue)]
		public decimal? PersonalExpenseAmount;

		[JsonProperty("multipleUsers")]
		[Field("multipleUsers", false, "False", Int32.MaxValue)]
		public bool? MultipleUsers;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("refusalDate")]
		[Field("refusalDate", false, null, Int32.MaxValue)]
		public DateTime? RefusalDate;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("groundForRefusal")]
		[Field("groundForRefusal", false, null, Int32.MaxValue)]
		public string? GroundForRefusal;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("refusedBy")]
		[Field("refusedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? RefusedBy;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("kilometricExpenseLineList")]
		[Field("kilometricExpenseLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.ExpenseLine>? KilometricExpenseLineList;

		[JsonProperty("employeeAdvanceUsageList")]
		[Field("employeeAdvanceUsageList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.EmployeeAdvanceUsage>? EmployeeAdvanceUsageList;

		[JsonProperty("expenseSeq")]
		[Field("expenseSeq", false, null, Int32.MaxValue)]
		public string? ExpenseSeq;

		[JsonProperty("validatedBy")]
		[Field("validatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedBy;

		[JsonProperty("paymentDate")]
		[Field("paymentDate", false, null, Int32.MaxValue)]
		public DateTime? PaymentDate;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
