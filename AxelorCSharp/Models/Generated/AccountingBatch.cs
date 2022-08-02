using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountingBatch")]
	public class AccountingBatch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("reimbursementExportTypeSelect")]
		public int? ReimbursementExportTypeSelect;

		[Field("code")]
		public string? Code;

		[Field("updateCustAccountOk")]
		public bool? UpdateCustAccountOk;

		[Field("reimbursementTypeSelect")]
		public int? ReimbursementTypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("directDebitDataTypeSelect")]
		public int? DirectDebitDataTypeSelect;

		[Field("moveLineExportTypeSelect")]
		public int? MoveLineExportTypeSelect;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("customerReimbursementTypeSelect")]
		public int? CustomerReimbursementTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("actionSelect")]
		public int? ActionSelect;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("debtRecoveryTypeSelect")]
		public int? DebtRecoveryTypeSelect;

		[Field("updateDueCustAccountOk")]
		public bool? UpdateDueCustAccountOk;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("creditTransferTypeSelect")]
		public int? CreditTransferTypeSelect;

		[Field("includeOtherBankAccounts")]
		public bool? IncludeOtherBankAccounts;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("updateDueDebtRecoveryCustAccountOk")]
		public bool? UpdateDueDebtRecoveryCustAccountOk;

	}
}
