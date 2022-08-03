using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AccountingBatch")]
	public class AccountingBatch : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("reimbursementExportTypeSelect")]
		[Field("reimbursementExportTypeSelect", false, "0", Int32.MaxValue)]
		public int? ReimbursementExportTypeSelect;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("updateCustAccountOk")]
		[Field("updateCustAccountOk", false, "False", Int32.MaxValue)]
		public bool? UpdateCustAccountOk;

		[JsonProperty("dueDate")]
		[Field("dueDate", false, null, Int32.MaxValue)]
		public DateTime? DueDate;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("reimbursementTypeSelect")]
		[Field("reimbursementTypeSelect", false, "0", Int32.MaxValue)]
		public int? ReimbursementTypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("directDebitDataTypeSelect")]
		[Field("directDebitDataTypeSelect", false, "1", Int32.MaxValue)]
		public int? DirectDebitDataTypeSelect;

		[JsonProperty("moveLineExportTypeSelect")]
		[Field("moveLineExportTypeSelect", false, "0", Int32.MaxValue)]
		public int? MoveLineExportTypeSelect;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("customerReimbursementTypeSelect")]
		[Field("customerReimbursementTypeSelect", true, "1", Int32.MaxValue)]
		public int? CustomerReimbursementTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("batchList")]
		[Field("batchList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[JsonProperty("actionSelect")]
		[Field("actionSelect", true, "0", Int32.MaxValue)]
		public int? ActionSelect;

		[JsonProperty("period")]
		[Field("period", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("debtRecoveryTypeSelect")]
		[Field("debtRecoveryTypeSelect", false, "0", Int32.MaxValue)]
		public int? DebtRecoveryTypeSelect;

		[JsonProperty("updateDueCustAccountOk")]
		[Field("updateDueCustAccountOk", false, "False", Int32.MaxValue)]
		public bool? UpdateDueCustAccountOk;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("creditTransferTypeSelect")]
		[Field("creditTransferTypeSelect", false, "0", Int32.MaxValue)]
		public int? CreditTransferTypeSelect;

		[JsonProperty("includeOtherBankAccounts")]
		[Field("includeOtherBankAccounts", false, "False", Int32.MaxValue)]
		public bool? IncludeOtherBankAccounts;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("updateDueDebtRecoveryCustAccountOk")]
		[Field("updateDueDebtRecoveryCustAccountOk", false, "False", Int32.MaxValue)]
		public bool? UpdateDueDebtRecoveryCustAccountOk;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
