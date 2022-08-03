using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.DirectDebitManagement")]
	public class DirectDebitManagement : AxelorModel
	{
		[JsonProperty("invoiceSet")]
		[Field("invoiceSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("paymentScheduleLineList")]
		[Field("paymentScheduleLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineList;

		[JsonProperty("debitNumber")]
		[Field("debitNumber", false, null, Int32.MaxValue)]
		public string? DebitNumber;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
