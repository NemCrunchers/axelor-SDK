using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InvoiceBatch")]
	public class InvoiceBatch : AxelorModel
	{
		[Field("invoiceSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fromStatusSelect")]
		public int? FromStatusSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("toStatusSelect")]
		public int? ToStatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("onSelectOk")]
		public bool? OnSelectOk;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("actionSelect")]
		public int? ActionSelect;

	}
}
