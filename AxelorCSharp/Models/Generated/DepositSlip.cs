using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.DepositSlip")]
	public class DepositSlip : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("paymentModeTypeSelect")]
		[Field("paymentModeTypeSelect", true, "0", Int32.MaxValue)]
		public int? PaymentModeTypeSelect;

		[JsonProperty("paymentVoucherList")]
		[Field("paymentVoucherList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PaymentVoucher>? PaymentVoucherList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("chequeCount")]
		[Field("chequeCount", false, "0", Int32.MaxValue)]
		public int? ChequeCount;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("totalAmount")]
		[Field("totalAmount", false, "0", Int32.MaxValue)]
		public decimal? TotalAmount;

		[JsonProperty("depositDate")]
		[Field("depositDate", true, null, Int32.MaxValue)]
		public DateTime? DepositDate;

		[JsonProperty("depositNumber")]
		[Field("depositNumber", false, null, Int32.MaxValue)]
		public string? DepositNumber;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("publicationDate")]
		[Field("publicationDate", false, null, Int32.MaxValue)]
		public DateTime? PublicationDate;

	}
}
