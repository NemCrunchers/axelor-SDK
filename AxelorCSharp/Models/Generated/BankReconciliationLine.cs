using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankReconciliationLine")]
	public class BankReconciliationLine : AxelorModel
	{
		[JsonProperty("effectDate")]
		[Field("effectDate", true, null, Int32.MaxValue)]
		public DateTime? EffectDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("bankStatementLine")]
		[Field("bankStatementLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankStatementLine? BankStatementLine;

		[JsonProperty("moveLine")]
		[Field("moveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankReconciliation")]
		[Field("bankReconciliation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankReconciliation? BankReconciliation;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("isPosted")]
		[Field("isPosted", false, "False", Int32.MaxValue)]
		public bool? IsPosted;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("credit")]
		[Field("credit", false, "0", Int32.MaxValue)]
		public decimal? Credit;

		[JsonProperty("debit")]
		[Field("debit", false, "0", Int32.MaxValue)]
		public decimal? Debit;

		[JsonProperty("account")]
		[Field("account", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
