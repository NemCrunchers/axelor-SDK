using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.IrrecoverableReportLine")]
	public class IrrecoverableReportLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("label")]
		public string? Label;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("reportLineSeq")]
		public int? ReportLineSeq;

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

		[Field("irrecoverableInvoiceLine")]
		public Axelor.Apps.Account.Db.IrrecoverableInvoiceLine? IrrecoverableInvoiceLine;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("irrecoverablePaymentScheduleLineLine")]
		public Axelor.Apps.Account.Db.IrrecoverablePaymentScheduleLineLine? IrrecoverablePaymentScheduleLineLine;

	}
}
