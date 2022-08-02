using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InvoiceLineTax")]
	public class InvoiceLineTax : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("reverseCharged")]
		public bool? ReverseCharged;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

	}
}
