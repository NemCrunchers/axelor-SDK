using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.DebtRecoveryMethodLine")]
	public class DebtRecoveryMethodLine : AxelorModel
	{
		[Field("debtRecoveryLevel")]
		public Axelor.Apps.Account.Db.DebtRecoveryLevel? DebtRecoveryLevel;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("debtRecoveryLevelLabel")]
		public string? DebtRecoveryLevelLabel;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("debtRecoveryMethod")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[Field("archived")]
		public bool? Archived;

		[Field("standardDeadline")]
		public int? StandardDeadline;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("messageTemplateSet")]
		public IEnumerable<Axelor.Apps.Message.Db.Template>? MessageTemplateSet;

		[Field("manualValidationOk")]
		public bool? ManualValidationOk;

		[Field("id")]
		public long? Id;

	}
}
