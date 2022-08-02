using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankReconciliation")]
	public class BankReconciliation : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("bankStatement")]
		public Axelor.Apps.Bankpayment.Db.BankStatement? BankStatement;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("cashAccount")]
		public Axelor.Apps.Account.Db.Account? CashAccount;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("includeOtherBankStatements")]
		public bool? IncludeOtherBankStatements;

	}
}
