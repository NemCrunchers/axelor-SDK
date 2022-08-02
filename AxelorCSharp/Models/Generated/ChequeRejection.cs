using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.ChequeRejection")]
	public class ChequeRejection : AxelorModel
	{
		[Field("dateTime")]
		public DateTime? DateTime;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("move")]
		public Axelor.Apps.Account.Db.Move? Move;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("paymentVoucher")]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

		[Field("description")]
		public string? Description;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("interbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
