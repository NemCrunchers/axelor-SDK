using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankReconciliation")]
	public class BankReconciliation : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("computedBalance")]
		[Field("computedBalance", false, "0", Int32.MaxValue)]
		public decimal? ComputedBalance;

		[JsonProperty("endingBalance")]
		[Field("endingBalance", false, "0", Int32.MaxValue)]
		public decimal? EndingBalance;

		[JsonProperty("bankStatement")]
		[Field("bankStatement", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankStatement? BankStatement;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("journal")]
		[Field("journal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("totalPaid")]
		[Field("totalPaid", false, "0", Int32.MaxValue)]
		public decimal? TotalPaid;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("startingBalance")]
		[Field("startingBalance", false, "0", Int32.MaxValue)]
		public decimal? StartingBalance;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("cashAccount")]
		[Field("cashAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? CashAccount;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("bankReconciliationLineList")]
		[Field("bankReconciliationLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankReconciliationLine>? BankReconciliationLineList;

		[JsonProperty("totalCashed")]
		[Field("totalCashed", false, "0", Int32.MaxValue)]
		public decimal? TotalCashed;

		[JsonProperty("accountBalance")]
		[Field("accountBalance", false, "0", Int32.MaxValue)]
		public decimal? AccountBalance;

		[JsonProperty("includeOtherBankStatements")]
		[Field("includeOtherBankStatements", false, "False", Int32.MaxValue)]
		public bool? IncludeOtherBankStatements;

	}
}
