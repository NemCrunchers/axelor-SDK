using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InvoicePayment")]
	public class InvoicePayment : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("chequeNumber")]
		public string? ChequeNumber;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("delayReason")]
		public string? DelayReason;

		[Field("id")]
		public long? Id;

		[Field("move")]
		public Axelor.Apps.Account.Db.Move? Move;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("bankOrder")]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[Field("imputedBy")]
		public Axelor.Apps.Account.Db.InvoicePayment? ImputedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("reconcile")]
		public Axelor.Apps.Account.Db.Reconcile? Reconcile;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("invoicePaymentRef")]
		public string? InvoicePaymentRef;

	}
}
