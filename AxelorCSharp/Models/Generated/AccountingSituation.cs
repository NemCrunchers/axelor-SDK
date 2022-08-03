using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AccountingSituation")]
	public class AccountingSituation : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("usedCredit")]
		[Field("usedCredit", false, "0", Int32.MaxValue)]
		public decimal? UsedCredit;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("acceptedCredit")]
		[Field("acceptedCredit", false, "0", Int32.MaxValue)]
		public decimal? AcceptedCredit;

		[JsonProperty("employeeAccount")]
		[Field("employeeAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? EmployeeAccount;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("balanceDueCustAccount")]
		[Field("balanceDueCustAccount", false, "0", Int32.MaxValue)]
		public decimal? BalanceDueCustAccount;

		[JsonProperty("companyInBankDetails")]
		[Field("companyInBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyInBankDetails;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("supplierAccount")]
		[Field("supplierAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? SupplierAccount;

		[JsonProperty("invoiceMessageTemplate")]
		[Field("invoiceMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("reportedBalanceLineList")]
		[Field("reportedBalanceLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.ReportedBalanceLine>? ReportedBalanceLineList;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("balanceCustAccount")]
		[Field("balanceCustAccount", false, "0", Int32.MaxValue)]
		public decimal? BalanceCustAccount;

		[JsonProperty("invoiceAutomaticMail")]
		[Field("invoiceAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? InvoiceAutomaticMail;

		[JsonProperty("companyOutBankDetails")]
		[Field("companyOutBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyOutBankDetails;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("customerAccount")]
		[Field("customerAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? CustomerAccount;

		[JsonProperty("custAccountMustBeUpdateOk")]
		[Field("custAccountMustBeUpdateOk", false, "False", Int32.MaxValue)]
		public bool? CustAccountMustBeUpdateOk;

		[JsonProperty("balanceDueDebtRecoveryCustAccount")]
		[Field("balanceDueDebtRecoveryCustAccount", false, "0", Int32.MaxValue)]
		public decimal? BalanceDueDebtRecoveryCustAccount;

		[JsonProperty("debtRecovery")]
		[Field("debtRecovery", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecovery? DebtRecovery;

	}
}
