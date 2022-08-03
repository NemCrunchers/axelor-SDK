using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Reconcile")]
	public class Reconcile : AxelorModel
	{
		[JsonProperty("debitMoveLine")]
		[Field("debitMoveLine", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? DebitMoveLine;

		[JsonProperty("amount")]
		[Field("amount", false, "0.0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("mustBeZeroBalanceOk")]
		[Field("mustBeZeroBalanceOk", false, "False", Int32.MaxValue)]
		public bool? MustBeZeroBalanceOk;

		[JsonProperty("reconciliationDate")]
		[Field("reconciliationDate", false, null, Int32.MaxValue)]
		public DateTime? ReconciliationDate;

		[JsonProperty("canBeZeroBalanceOk")]
		[Field("canBeZeroBalanceOk", false, "False", Int32.MaxValue)]
		public bool? CanBeZeroBalanceOk;

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

		[JsonProperty("reconcileSeq")]
		[Field("reconcileSeq", false, null, Int32.MaxValue)]
		public string? ReconcileSeq;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("creditMoveLine")]
		[Field("creditMoveLine", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? CreditMoveLine;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("reconcileGroup")]
		[Field("reconcileGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.ReconcileGroup? ReconcileGroup;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
