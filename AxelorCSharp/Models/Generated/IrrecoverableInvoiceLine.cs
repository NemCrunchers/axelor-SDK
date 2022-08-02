using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.IrrecoverableInvoiceLine")]
	public class IrrecoverableInvoiceLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("irrecoverableCustomerLine")]
		public Axelor.Apps.Account.Db.IrrecoverableCustomerLine? IrrecoverableCustomerLine;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

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

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("invoiceLineSeq")]
		public int? InvoiceLineSeq;

	}
}
