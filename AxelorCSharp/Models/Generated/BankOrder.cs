using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankOrder")]
	public class BankOrder : AxelorModel
	{
		[Field("nbOfLines")]
		public int? NbOfLines;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("senderBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? SenderBankDetails;

		[Field("confirmationDateTime")]
		public DateTime? ConfirmationDateTime;

		[Field("senderCompany")]
		public Axelor.Apps.Base.Db.Company? SenderCompany;

		[Field("fileGenerationDateTime")]
		public DateTime? FileGenerationDateTime;

		[Field("signatoryEbicsUser")]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? SignatoryEbicsUser;

		[Field("sendingDateTime")]
		public DateTime? SendingDateTime;

		[Field("partnerTypeSelect")]
		public int? PartnerTypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("signedMetaFile")]
		public Axelor.Meta.Db.MetaFile? SignedMetaFile;

		[Field("isMultiCurrency")]
		public bool? IsMultiCurrency;

		[Field("companyCurrency")]
		public Axelor.Apps.Base.Db.Currency? CompanyCurrency;

		[Field("validationDateTime")]
		public DateTime? ValidationDateTime;

		[Field("id")]
		public long? Id;

		[Field("signatoryUser")]
		public Axelor.Auth.Db.User? SignatoryUser;

		[Field("bankOrderCurrency")]
		public Axelor.Apps.Base.Db.Currency? BankOrderCurrency;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("batch")]
		public Axelor.Apps.Base.Db.Batch? Batch;

		[Field("senderReference")]
		public string? SenderReference;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("rejectStatusSelect")]
		public int? RejectStatusSelect;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("bankOrderFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("senderLabel")]
		public string? SenderLabel;

		[Field("bankOrderSeq")]
		public string? BankOrderSeq;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("generatedMetaFile")]
		public Axelor.Meta.Db.MetaFile? GeneratedMetaFile;

		[Field("orderTypeSelect")]
		public int? OrderTypeSelect;

		[Field("testMode")]
		public bool? TestMode;

		[Field("isMultiDate")]
		public bool? IsMultiDate;

	}
}
