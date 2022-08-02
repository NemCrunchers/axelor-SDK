using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.IrrecoverableCustomerLine")]
	public class IrrecoverableCustomerLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("irrecoverable")]
		public Axelor.Apps.Account.Db.Irrecoverable? Irrecoverable;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("paymentScheduleLineSet")]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentScheduleLine>? PaymentScheduleLineSet;

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

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
