using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Invoice")]
	public class Invoice : AxelorModel
	{
		[Field("standardInvoice")]
		public Axelor.Apps.Account.Db.Invoice? StandardInvoice;

		[Field("partnerAccount")]
		public Axelor.Apps.Account.Db.Account? PartnerAccount;

		[Field("partnerTaxNbr")]
		public string? PartnerTaxNbr;

		[Field("invoicesCopySelect")]
		public int? InvoicesCopySelect;

		[Field("debtRecoveryBlockingReason")]
		public Axelor.Apps.Base.Db.StopReason? DebtRecoveryBlockingReason;

		[Field("paymentSchedule")]
		public Axelor.Apps.Account.Db.PaymentSchedule? PaymentSchedule;

		[Field("debitBlockingOk")]
		public bool? DebitBlockingOk;

		[Field("operationTypeSelect")]
		public int? OperationTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("doubtfulCustomerOk")]
		public bool? DoubtfulCustomerOk;

		[Field("invoiceMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[Field("contract")]
		public Axelor.Apps.Contract.Db.Contract? Contract;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("externalReference")]
		public string? ExternalReference;

		[Field("interbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[Field("advancePaymentInvoiceSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? AdvancePaymentInvoiceSet;

		[Field("createdByInterco")]
		public bool? CreatedByInterco;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("displayTimesheetOnPrinting")]
		public bool? DisplayTimesheetOnPrinting;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("oldMove")]
		public Axelor.Apps.Account.Db.Move? OldMove;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[Field("rejectMoveLine")]
		public Axelor.Apps.Account.Db.MoveLine? RejectMoveLine;

		[Field("tradingName")]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[Field("address")]
		public Axelor.Apps.Base.Db.Address? Address;

		[Field("hideDiscount")]
		public bool? HideDiscount;

		[Field("directDebitManagement")]
		public Axelor.Apps.Account.Db.DirectDebitManagement? DirectDebitManagement;

		[Field("originalInvoice")]
		public Axelor.Apps.Account.Db.Invoice? OriginalInvoice;

		[Field("debtRecoveryBlockingOk")]
		public bool? DebtRecoveryBlockingOk;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("invoiceAutomaticMail")]
		public bool? InvoiceAutomaticMail;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("invoiceId")]
		public string? InvoiceId;

		[Field("supplierInvoiceNb")]
		public string? SupplierInvoiceNb;

		[Field("operationSubTypeSelect")]
		public int? OperationSubTypeSelect;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("debitBlockingByUser")]
		public Axelor.Auth.Db.User? DebitBlockingByUser;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("alreadyPrintedOk")]
		public bool? AlreadyPrintedOk;

		[Field("irrecoverableStatusSelect")]
		public int? IrrecoverableStatusSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("debtRecoveryBlockingByUser")]
		public Axelor.Auth.Db.User? DebtRecoveryBlockingByUser;

		[Field("debitNumber")]
		public string? DebitNumber;

		[Field("canceledPaymentSchedule")]
		public Axelor.Apps.Account.Db.PaymentSchedule? CanceledPaymentSchedule;

		[Field("managementObject")]
		public Axelor.Apps.Account.Db.ManagementObject? ManagementObject;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("validatedByUser")]
		public Axelor.Auth.Db.User? ValidatedByUser;

		[Field("debitBlockingReason")]
		public Axelor.Apps.Base.Db.StopReason? DebitBlockingReason;

		[Field("inAti")]
		public bool? InAti;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("priceList")]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[Field("schedulePaymentOk")]
		public bool? SchedulePaymentOk;

		[Field("ventilatedByUser")]
		public Axelor.Auth.Db.User? VentilatedByUser;

		[Field("printingSettings")]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[Field("printedPDF")]
		public Axelor.Meta.Db.MetaFile? PrintedPDF;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("paymentMove")]
		public Axelor.Apps.Account.Db.Move? PaymentMove;

		[Field("move")]
		public Axelor.Apps.Account.Db.Move? Move;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("internalReference")]
		public string? InternalReference;

		[Field("usherPassageOk")]
		public bool? UsherPassageOk;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("displayExpenseOnPrinting")]
		public bool? DisplayExpenseOnPrinting;

		[Field("purchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[Field("hasPendingPayments")]
		public bool? HasPendingPayments;

		[Field("interco")]
		public bool? Interco;

	}
}
