using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Reconcile")]
	public class Reconcile : AxelorModel
	{
		[Field("debitMoveLine")]
		public Axelor.Apps.Account.Db.MoveLine? DebitMoveLine;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("mustBeZeroBalanceOk")]
		public bool? MustBeZeroBalanceOk;

		[Field("canBeZeroBalanceOk")]
		public bool? CanBeZeroBalanceOk;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("reconcileSeq")]
		public string? ReconcileSeq;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("creditMoveLine")]
		public Axelor.Apps.Account.Db.MoveLine? CreditMoveLine;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("reconcileGroup")]
		public Axelor.Apps.Account.Db.ReconcileGroup? ReconcileGroup;

		[Field("id")]
		public long? Id;

	}
}
