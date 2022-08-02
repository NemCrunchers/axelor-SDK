using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PaymentScheduleLine")]
	public class PaymentScheduleLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("advanceMoveLine")]
		public Axelor.Apps.Account.Db.MoveLine? AdvanceMoveLine;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("advanceOrPaymentMove")]
		public Axelor.Apps.Account.Db.Move? AdvanceOrPaymentMove;

		[Field("paymentSchedule")]
		public Axelor.Apps.Account.Db.PaymentSchedule? PaymentSchedule;

		[Field("debitBlockingOk")]
		public bool? DebitBlockingOk;

		[Field("id")]
		public long? Id;

		[Field("rejectMoveLine")]
		public Axelor.Apps.Account.Db.MoveLine? RejectMoveLine;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("directDebitManagement")]
		public Axelor.Apps.Account.Db.DirectDebitManagement? DirectDebitManagement;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("interbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[Field("scheduleLineSeq")]
		public int? ScheduleLineSeq;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("debitNumber")]
		public string? DebitNumber;

		[Field("name")]
		public string? Name;

		[Field("fromReject")]
		public bool? FromReject;

		[Field("rejectedOk")]
		public bool? RejectedOk;

	}
}
