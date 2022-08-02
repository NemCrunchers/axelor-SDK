using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.DebtRecovery")]
	public class DebtRecovery : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("invoiceDebtRecoverySet")]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceDebtRecoverySet;

		[Field("id")]
		public long? Id;

		[Field("setToIrrecoverableOk")]
		public bool? SetToIrrecoverableOk;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("waitDebtRecoveryMethodLine")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? WaitDebtRecoveryMethodLine;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("unknownAddressOk")]
		public bool? UnknownAddressOk;

		[Field("debtRecoveryMethod")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethod? DebtRecoveryMethod;

		[Field("importId")]
		public string? ImportId;

		[Field("paymentScheduleLineDebtRecoverySet")]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineDebtRecoverySet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("deceasedPartnerOk")]
		public bool? DeceasedPartnerOk;

		[Field("debtRecoveryMethodLine")]
		public Axelor.Apps.Account.Db.DebtRecoveryMethodLine? DebtRecoveryMethodLine;

	}
}
