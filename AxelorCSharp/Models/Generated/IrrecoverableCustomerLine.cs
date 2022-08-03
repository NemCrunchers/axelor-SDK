using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.IrrecoverableCustomerLine")]
	public class IrrecoverableCustomerLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("irrecoverable")]
		[Field("irrecoverable", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Irrecoverable? Irrecoverable;

		[JsonProperty("irrecoverableInvoiceLineList")]
		[Field("irrecoverableInvoiceLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.IrrecoverableInvoiceLine>? IrrecoverableInvoiceLineList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("paymentScheduleLineSet")]
		[Field("paymentScheduleLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("irrecoverablePaymentScheduleLineLineList")]
		[Field("irrecoverablePaymentScheduleLineLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.IrrecoverablePaymentScheduleLineLine>? IrrecoverablePaymentScheduleLineLineList;

	}
}
