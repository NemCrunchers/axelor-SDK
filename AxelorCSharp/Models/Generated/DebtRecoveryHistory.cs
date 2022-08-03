using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.DebtRecoveryHistory")]
	public class DebtRecoveryHistory : AxelorModel
	{
		[JsonProperty("setToIrrecoverableOK")]
		[Field("setToIrrecoverableOK", false, "False", Int32.MaxValue)]
		public bool? SetToIrrecoverableOK;

		[JsonProperty("balanceDueDebtRecovery")]
		[Field("balanceDueDebtRecovery", false, "0", Int32.MaxValue)]
		public decimal? BalanceDueDebtRecovery;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("userDebtRecovery")]
		[Field("userDebtRecovery", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UserDebtRecovery;

		[JsonProperty("balanceDue")]
		[Field("balanceDue", false, "0", Int32.MaxValue)]
		public decimal? BalanceDue;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("debtRecoveryDate")]
		[Field("debtRecoveryDate", false, null, Int32.MaxValue)]
		public DateTime? DebtRecoveryDate;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("unknownAddressOK")]
		[Field("unknownAddressOK", false, "False", Int32.MaxValue)]
		public bool? UnknownAddressOK;

		[JsonProperty("debtRecoveryMethod")]
		[Field("debtRecoveryMethod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("referenceDate")]
		[Field("referenceDate", false, null, Int32.MaxValue)]
		public DateTime? ReferenceDate;

		[JsonProperty("debtRecoveryMethodLine")]
		[Field("debtRecoveryMethodLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? DebtRecoveryMethodLine;

		[JsonProperty("debtRecovery")]
		[Field("debtRecovery", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecovery? DebtRecovery;

	}
}
