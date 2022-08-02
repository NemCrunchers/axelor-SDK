using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PayVoucherElementToPay")]
	public class PayVoucherElementToPay : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("moveLine")]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[Field("paymentVoucher")]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("moveLineGenerated")]
		public Axelor.Apps.Account.Db.MoveLine? MoveLineGenerated;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

	}
}
