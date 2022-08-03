using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.DebtRecoveryMethodLine")]
	public class DebtRecoveryMethodLine : AxelorModel
	{
		[JsonProperty("debtRecoveryLevel")]
		[Field("debtRecoveryLevel", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryLevel? DebtRecoveryLevel;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("debtRecoveryLevelLabel")]
		[Field("debtRecoveryLevelLabel", false, null, Int32.MaxValue)]
		public string? DebtRecoveryLevelLabel;

		[JsonProperty("minThreshold")]
		[Field("minThreshold", false, "0", Int32.MaxValue)]
		public decimal? MinThreshold;

		[JsonProperty("printingMessage")]
		[Field("printingMessage", false, null, Int32.MaxValue)]
		public string? PrintingMessage;

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

		[JsonProperty("debtRecoveryMethod")]
		[Field("debtRecoveryMethod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("standardDeadline")]
		[Field("standardDeadline", false, "0", Int32.MaxValue)]
		public int? StandardDeadline;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("messageTemplateSet")]
		[Field("messageTemplateSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.Template>? MessageTemplateSet;

		[JsonProperty("manualValidationOk")]
		[Field("manualValidationOk", false, "False", Int32.MaxValue)]
		public bool? ManualValidationOk;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
