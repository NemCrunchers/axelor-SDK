using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountEquiv")]
	public class AccountEquiv : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("toAccount")]
		public Axelor.Apps.Account.Db.Account? ToAccount;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fromAccount")]
		public Axelor.Apps.Account.Db.Account? FromAccount;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("fiscalPosition")]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

	}
}
