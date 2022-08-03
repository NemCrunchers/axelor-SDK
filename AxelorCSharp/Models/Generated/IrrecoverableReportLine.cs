using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.IrrecoverableReportLine")]
	public class IrrecoverableReportLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("label")]
		[Field("label", false, null, Int32.MaxValue)]
		public string? Label;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("reportLineSeq")]
		[Field("reportLineSeq", false, "0", Int32.MaxValue)]
		public int? ReportLineSeq;

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

		[JsonProperty("irrecoverableInvoiceLine")]
		[Field("irrecoverableInvoiceLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.IrrecoverableInvoiceLine? IrrecoverableInvoiceLine;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("irrecoverablePaymentScheduleLineLine")]
		[Field("irrecoverablePaymentScheduleLineLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.IrrecoverablePaymentScheduleLineLine? IrrecoverablePaymentScheduleLineLine;

		[JsonProperty("value")]
		[Field("value", false, "0", Int32.MaxValue)]
		public decimal? Value;

	}
}
