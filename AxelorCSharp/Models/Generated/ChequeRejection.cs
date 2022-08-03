using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.ChequeRejection")]
	public class ChequeRejection : AxelorModel
	{
		[JsonProperty("dateTime")]
		[Field("dateTime", false, null, Int32.MaxValue)]
		public DateTime? DateTime;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("move")]
		[Field("move", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? Move;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("paymentVoucher")]
		[Field("paymentVoucher", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

		[JsonProperty("description")]
		[Field("description", false, "Cheque rejection", Int32.MaxValue)]
		public string? Description;

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

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("amountRejected")]
		[Field("amountRejected", false, "0", Int32.MaxValue)]
		public decimal? AmountRejected;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("rejectionDate")]
		[Field("rejectionDate", true, null, Int32.MaxValue)]
		public DateTime? RejectionDate;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
