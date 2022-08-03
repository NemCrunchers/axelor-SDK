using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.DebtRecovery")]
	public class DebtRecovery : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("debtRecoveryHistoryList")]
		[Field("debtRecoveryHistoryList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.DebtRecoveryHistory>? DebtRecoveryHistoryList;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("invoiceDebtRecoverySet")]
		[Field("invoiceDebtRecoverySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceDebtRecoverySet;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("setToIrrecoverableOk")]
		[Field("setToIrrecoverableOk", false, "False", Int32.MaxValue)]
		public bool? SetToIrrecoverableOk;

		[JsonProperty("balanceDueDebtRecovery")]
		[Field("balanceDueDebtRecovery", false, "0", Int32.MaxValue)]
		public decimal? BalanceDueDebtRecovery;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("balanceDue")]
		[Field("balanceDue", false, "0", Int32.MaxValue)]
		public decimal? BalanceDue;

		[JsonProperty("waitDebtRecoveryMethodLine")]
		[Field("waitDebtRecoveryMethodLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? WaitDebtRecoveryMethodLine;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("debtRecoveryDate")]
		[Field("debtRecoveryDate", false, null, Int32.MaxValue)]
		public DateTime? DebtRecoveryDate;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("unknownAddressOk")]
		[Field("unknownAddressOk", false, "False", Int32.MaxValue)]
		public bool? UnknownAddressOk;

		[JsonProperty("debtRecoveryMethod")]
		[Field("debtRecoveryMethod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("paymentScheduleLineDebtRecoverySet")]
		[Field("paymentScheduleLineDebtRecoverySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineDebtRecoverySet;

		[JsonProperty("accountingSituation")]
		[Field("accountingSituation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountingSituation? AccountingSituation;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("deceasedPartnerOk")]
		[Field("deceasedPartnerOk", false, "False", Int32.MaxValue)]
		public bool? DeceasedPartnerOk;

		[JsonProperty("referenceDate")]
		[Field("referenceDate", false, null, Int32.MaxValue)]
		public DateTime? ReferenceDate;

		[JsonProperty("debtRecoveryMethodLine")]
		[Field("debtRecoveryMethodLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? DebtRecoveryMethodLine;

	}
}
