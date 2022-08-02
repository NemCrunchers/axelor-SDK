using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Irrecoverable")]
	public class Irrecoverable : AxelorModel
	{
		[Field("dateTime")]
		public DateTime? DateTime;

		[Field("invoiceSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("exportTypeSelect")]
		public string? ExportTypeSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("paymentScheduleLineSet")]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("moveSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Move>? MoveSet;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
