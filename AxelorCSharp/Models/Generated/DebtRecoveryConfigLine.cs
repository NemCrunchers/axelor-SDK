using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.DebtRecoveryConfigLine")]
	public class DebtRecoveryConfigLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("accountConfig")]
		public Axelor.Apps.Account.Db.AccountConfig? AccountConfig;

		[Field("attrs")]
		public string? Attrs;

		[Field("debtRecoveryMethod")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[Field("archived")]
		public bool? Archived;

		[Field("partnerCategory")]
		public Axelor.Apps.Base.Db.PartnerCategory? PartnerCategory;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
