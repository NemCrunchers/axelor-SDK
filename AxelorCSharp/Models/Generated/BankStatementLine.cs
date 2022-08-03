using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankStatementLine")]
	public class BankStatementLine : AxelorModel
	{
		[JsonProperty("operationDate")]
		[Field("operationDate", false, null, Int32.MaxValue)]
		public DateTime? OperationDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("origin")]
		[Field("origin", false, null, Int32.MaxValue)]
		public string? Origin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("bankStatement")]
		[Field("bankStatement", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankStatement? BankStatement;

		[JsonProperty("rejectInterbankCodeLine")]
		[Field("rejectInterbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? RejectInterbankCodeLine;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("operationInterbankCodeLine")]
		[Field("operationInterbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? OperationInterbankCodeLine;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("credit")]
		[Field("credit", false, "0", Int32.MaxValue)]
		public decimal? Credit;

		[JsonProperty("debit")]
		[Field("debit", false, "0", Int32.MaxValue)]
		public decimal? Debit;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("amountRemainToReconcile")]
		[Field("amountRemainToReconcile", false, "0", Int32.MaxValue)]
		public decimal? AmountRemainToReconcile;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("valueDate")]
		[Field("valueDate", false, null, Int32.MaxValue)]
		public DateTime? ValueDate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
