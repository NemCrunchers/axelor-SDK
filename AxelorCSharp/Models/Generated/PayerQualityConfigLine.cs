using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PayerQualityConfigLine")]
	public class PayerQualityConfigLine : AxelorModel
	{
		[Field("debtRecoveryLevel")]
		public Axelor.Apps.Account.Db.DebtRecoveryLevel? DebtRecoveryLevel;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("description")]
		public string? Description;

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

		[Field("name")]
		public string? Name;

		[Field("rejectType")]
		public string? RejectType;

		[Field("id")]
		public long? Id;

		[Field("incidentTypeSelect")]
		public int? IncidentTypeSelect;

	}
}
