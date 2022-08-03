using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PaymentScheduleLine")]
	public class PaymentScheduleLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("advanceMoveLine")]
		[Field("advanceMoveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? AdvanceMoveLine;

		[JsonProperty("inTaxAmountPaid")]
		[Field("inTaxAmountPaid", false, "0", Int32.MaxValue)]
		public decimal? InTaxAmountPaid;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("inTaxAmount")]
		[Field("inTaxAmount", false, "0", Int32.MaxValue)]
		public decimal? InTaxAmount;

		[JsonProperty("rejectDate")]
		[Field("rejectDate", false, null, Int32.MaxValue)]
		public DateTime? RejectDate;

		[JsonProperty("advanceOrPaymentMove")]
		[Field("advanceOrPaymentMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? AdvanceOrPaymentMove;

		[JsonProperty("paymentSchedule")]
		[Field("paymentSchedule", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentSchedule? PaymentSchedule;

		[JsonProperty("scheduleDate")]
		[Field("scheduleDate", true, null, Int32.MaxValue)]
		public DateTime? ScheduleDate;

		[JsonProperty("debitBlockingOk")]
		[Field("debitBlockingOk", false, "False", Int32.MaxValue)]
		public bool? DebitBlockingOk;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("rejectMoveLine")]
		[Field("rejectMoveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? RejectMoveLine;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("directDebitManagement")]
		[Field("directDebitManagement", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DirectDebitManagement? DirectDebitManagement;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("scheduleLineSeq")]
		[Field("scheduleLineSeq", true, "0", Int32.MaxValue)]
		public int? ScheduleLineSeq;

		[JsonProperty("amountRejected")]
		[Field("amountRejected", false, "0", Int32.MaxValue)]
		public decimal? AmountRejected;

		[JsonProperty("directDebitAmount")]
		[Field("directDebitAmount", false, "0", Int32.MaxValue)]
		public decimal? DirectDebitAmount;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("debitNumber")]
		[Field("debitNumber", false, null, Int32.MaxValue)]
		public string? DebitNumber;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("fromReject")]
		[Field("fromReject", false, "False", Int32.MaxValue)]
		public bool? FromReject;

		[JsonProperty("rejectedOk")]
		[Field("rejectedOk", false, "False", Int32.MaxValue)]
		public bool? RejectedOk;

	}
}
