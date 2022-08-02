using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PaymentVoucher")]
	public class PaymentVoucher : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("defaultEmailOk")]
		public bool? DefaultEmailOk;

		[Field("chequeNumber")]
		public string? ChequeNumber;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("ref")]
		public string? Ref;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("operationTypeSelect")]
		public int? OperationTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("chequeOwner")]
		public string? ChequeOwner;

		[Field("email")]
		public string? Email;

		[Field("bankCardTransactionNumber")]
		public string? BankCardTransactionNumber;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("moveLine")]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[Field("payboxPaidOk")]
		public bool? PayboxPaidOk;

		[Field("generatedMove")]
		public Axelor.Apps.Account.Db.Move? GeneratedMove;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("hasAutoInput")]
		public bool? HasAutoInput;

		[Field("attrs")]
		public string? Attrs;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("receiptNo")]
		public string? ReceiptNo;

		[Field("toSaveEmailOk")]
		public bool? ToSaveEmailOk;

		[Field("depositSlip")]
		public Axelor.Apps.Account.Db.DepositSlip? DepositSlip;

		[Field("chequeBank")]
		public string? ChequeBank;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
