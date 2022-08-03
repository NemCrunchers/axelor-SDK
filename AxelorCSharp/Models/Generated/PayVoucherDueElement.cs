using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PayVoucherDueElement")]
	public class PayVoucherDueElement : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("moveLine")]
		[Field("moveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[JsonProperty("paymentVoucher")]
		[Field("paymentVoucher", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

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

		[JsonProperty("dueAmount")]
		[Field("dueAmount", false, "0", Int32.MaxValue)]
		public decimal? DueAmount;

		[JsonProperty("amountRemaining")]
		[Field("amountRemaining", false, "0", Int32.MaxValue)]
		public decimal? AmountRemaining;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("paidAmount")]
		[Field("paidAmount", false, "0", Int32.MaxValue)]
		public decimal? PaidAmount;

	}
}
