using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PaymentMode")]
	public class PaymentMode : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("generateBankOrder")]
		public bool? GenerateBankOrder;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("consoBankOrderLinePerPartner")]
		public bool? ConsoBankOrderLinePerPartner;

		[Field("id")]
		public long? Id;

		[Field("bankOrderExportFolderPath")]
		public string? BankOrderExportFolderPath;

		[Field("inOutSelect")]
		public int? InOutSelect;

		[Field("validatePaymentByDepositSlipPublication")]
		public bool? ValidatePaymentByDepositSlipPublication;

		[Field("automaticTransmission")]
		public bool? AutomaticTransmission;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("autoConfirmBankOrder")]
		public bool? AutoConfirmBankOrder;

		[Field("generateMoveAutoFromBankOrder")]
		public bool? GenerateMoveAutoFromBankOrder;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("bankOrderFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("orderTypeSelect")]
		public int? OrderTypeSelect;

		[Field("name")]
		public string? Name;

	}
}
