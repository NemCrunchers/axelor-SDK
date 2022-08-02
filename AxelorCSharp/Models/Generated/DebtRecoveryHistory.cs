using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.DebtRecoveryHistory")]
	public class DebtRecoveryHistory : AxelorModel
	{
		[Field("setToIrrecoverableOK")]
		public bool? SetToIrrecoverableOK;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("userDebtRecovery")]
		public Axelor.Auth.Db.User? UserDebtRecovery;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("unknownAddressOK")]
		public bool? UnknownAddressOK;

		[Field("debtRecoveryMethod")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("debtRecoveryMethodLine")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? DebtRecoveryMethodLine;

		[Field("debtRecovery")]
		public Axelor.Apps.Account.Db.DebtRecovery? DebtRecovery;

	}
}
