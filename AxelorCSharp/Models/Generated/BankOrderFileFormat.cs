using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankOrderFileFormat")]
	public class BankOrderFileFormat : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("bankOrderFileFormatCountryList")]
		[Field("bankOrderFileFormatCountryList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankOrderFileFormatCountry>? BankOrderFileFormatCountryList;

		[JsonProperty("displayPaymentModeSelect")]
		[Field("displayPaymentModeSelect", false, "False", Int32.MaxValue)]
		public bool? DisplayPaymentModeSelect;

		[JsonProperty("feesImputationModeSelect")]
		[Field("feesImputationModeSelect", false, "0", Int32.MaxValue)]
		public int? FeesImputationModeSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("displayFurtherInformations")]
		[Field("displayFurtherInformations", false, "False", Int32.MaxValue)]
		public bool? DisplayFurtherInformations;

		[JsonProperty("allowOrderCurrDiffFromBankDetails")]
		[Field("allowOrderCurrDiffFromBankDetails", false, "False", Int32.MaxValue)]
		public bool? AllowOrderCurrDiffFromBankDetails;

		[JsonProperty("receiverCountry")]
		[Field("receiverCountry", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? ReceiverCountry;

		[JsonProperty("isMultiCurrency")]
		[Field("isMultiCurrency", false, "False", Int32.MaxValue)]
		public bool? IsMultiCurrency;

		[JsonProperty("qualifyingOfDate")]
		[Field("qualifyingOfDate", false, null, Int32.MaxValue)]
		public string? QualifyingOfDate;

		[JsonProperty("bankDetailsTypeSelect")]
		[Field("bankDetailsTypeSelect", false, null, Int32.MaxValue)]
		public string? BankDetailsTypeSelect;

		[JsonProperty("fileGenerationSupported")]
		[Field("fileGenerationSupported", false, "False", Int32.MaxValue)]
		public bool? FileGenerationSupported;

		[JsonProperty("displayBankOrderEconomicReason")]
		[Field("displayBankOrderEconomicReason", false, "False", Int32.MaxValue)]
		public bool? DisplayBankOrderEconomicReason;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("displayReceiverCountry")]
		[Field("displayReceiverCountry", false, "False", Int32.MaxValue)]
		public bool? DisplayReceiverCountry;

		[JsonProperty("bankOrderEconomicReason")]
		[Field("bankOrderEconomicReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderEconomicReason? BankOrderEconomicReason;

		[JsonProperty("displayAdditionnalInformations")]
		[Field("displayAdditionnalInformations", false, "False", Int32.MaxValue)]
		public bool? DisplayAdditionnalInformations;

		[JsonProperty("qualifyingOfAmountSelect")]
		[Field("qualifyingOfAmountSelect", false, "T", Int32.MaxValue)]
		public string? QualifyingOfAmountSelect;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("ibanOnly")]
		[Field("ibanOnly", false, "False", Int32.MaxValue)]
		public bool? IbanOnly;

		[JsonProperty("orderDebitTypeSelect")]
		[Field("orderDebitTypeSelect", false, null, Int32.MaxValue)]
		public int? OrderDebitTypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("paymentModeSelect")]
		[Field("paymentModeSelect", false, "0", Int32.MaxValue)]
		public int? PaymentModeSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("displayFeesImputationModeSelect")]
		[Field("displayFeesImputationModeSelect", false, "False", Int32.MaxValue)]
		public bool? DisplayFeesImputationModeSelect;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("orderTypeSelect")]
		[Field("orderTypeSelect", false, "0", Int32.MaxValue)]
		public int? OrderTypeSelect;

		[JsonProperty("isMultiDate")]
		[Field("isMultiDate", false, "False", Int32.MaxValue)]
		public bool? IsMultiDate;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("displayReceiverAddress")]
		[Field("displayReceiverAddress", false, "False", Int32.MaxValue)]
		public bool? DisplayReceiverAddress;

		[JsonProperty("orderFileFormatSelect")]
		[Field("orderFileFormatSelect", false, null, Int32.MaxValue)]
		public string? OrderFileFormatSelect;

	}
}
