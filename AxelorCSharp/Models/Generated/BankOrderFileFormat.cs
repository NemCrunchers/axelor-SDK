using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankOrderFileFormat")]
	public class BankOrderFileFormat : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("displayPaymentModeSelect")]
		public bool? DisplayPaymentModeSelect;

		[Field("feesImputationModeSelect")]
		public int? FeesImputationModeSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("displayFurtherInformations")]
		public bool? DisplayFurtherInformations;

		[Field("allowOrderCurrDiffFromBankDetails")]
		public bool? AllowOrderCurrDiffFromBankDetails;

		[Field("receiverCountry")]
		public Axelor.Apps.Base.Db.Country? ReceiverCountry;

		[Field("isMultiCurrency")]
		public bool? IsMultiCurrency;

		[Field("qualifyingOfDate")]
		public string? QualifyingOfDate;

		[Field("bankDetailsTypeSelect")]
		public string? BankDetailsTypeSelect;

		[Field("fileGenerationSupported")]
		public bool? FileGenerationSupported;

		[Field("displayBankOrderEconomicReason")]
		public bool? DisplayBankOrderEconomicReason;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("displayReceiverCountry")]
		public bool? DisplayReceiverCountry;

		[Field("bankOrderEconomicReason")]
		public Axelor.Apps.Bankpayment.Db.BankOrderEconomicReason? BankOrderEconomicReason;

		[Field("displayAdditionnalInformations")]
		public bool? DisplayAdditionnalInformations;

		[Field("qualifyingOfAmountSelect")]
		public string? QualifyingOfAmountSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("ibanOnly")]
		public bool? IbanOnly;

		[Field("orderDebitTypeSelect")]
		public int? OrderDebitTypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("paymentModeSelect")]
		public int? PaymentModeSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("displayFeesImputationModeSelect")]
		public bool? DisplayFeesImputationModeSelect;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("orderTypeSelect")]
		public int? OrderTypeSelect;

		[Field("isMultiDate")]
		public bool? IsMultiDate;

		[Field("name")]
		public string? Name;

		[Field("displayReceiverAddress")]
		public bool? DisplayReceiverAddress;

		[Field("orderFileFormatSelect")]
		public string? OrderFileFormatSelect;

	}
}
