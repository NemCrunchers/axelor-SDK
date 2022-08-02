using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountConfig")]
	public class AccountConfig : AxelorModel
	{
		[Field("hasChartImported")]
		public bool? HasChartImported;

		[Field("suppInvSequence")]
		public Axelor.Apps.Base.Db.Sequence? SuppInvSequence;

		[Field("defPaymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? DefPaymentCondition;

		[Field("irrecoverableStandardRateTax")]
		public Axelor.Apps.Account.Db.Tax? IrrecoverableStandardRateTax;

		[Field("cashPositionVariationAccount")]
		public Axelor.Apps.Account.Db.Account? CashPositionVariationAccount;

		[Field("factorDebitAccount")]
		public Axelor.Apps.Account.Db.Account? FactorDebitAccount;

		[Field("displayTaxDetailOnPrinting")]
		public bool? DisplayTaxDetailOnPrinting;

		[Field("autoReconcileOnPayment")]
		public bool? AutoReconcileOnPayment;

		[Field("id")]
		public long? Id;

		[Field("expenseJournal")]
		public Axelor.Apps.Account.Db.Journal? ExpenseJournal;

		[Field("purchaseJournalType")]
		public Axelor.Apps.Account.Db.JournalType? PurchaseJournalType;

		[Field("supplierAccount")]
		public Axelor.Apps.Account.Db.Account? SupplierAccount;

		[Field("invoiceMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[Field("cashJournalType")]
		public Axelor.Apps.Account.Db.JournalType? CashJournalType;

		[Field("forecastedInvSuppAccount")]
		public Axelor.Apps.Account.Db.Account? ForecastedInvSuppAccount;

		[Field("employeeAccountSequence")]
		public Axelor.Apps.Base.Db.Sequence? EmployeeAccountSequence;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("tempReimbImportFolderPathCFONB")]
		public string? TempReimbImportFolderPathCFONB;

		[Field("version")]
		public int? Version;

		[Field("irrecoverableAccount")]
		public Axelor.Apps.Account.Db.Account? IrrecoverableAccount;

		[Field("attrs")]
		public string? Attrs;

		[Field("supplierPurchaseJournal")]
		public Axelor.Apps.Account.Db.Journal? SupplierPurchaseJournal;

		[Field("displayDelAddrOnPrinting")]
		public bool? DisplayDelAddrOnPrinting;

		[Field("manualMiscOpeJournal")]
		public Axelor.Apps.Account.Db.Journal? ManualMiscOpeJournal;

		[Field("paymentScheduleRejectNumLimit")]
		public int? PaymentScheduleRejectNumLimit;

		[Field("customerAccount")]
		public Axelor.Apps.Account.Db.Account? CustomerAccount;

		[Field("rejectionPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? RejectionPaymentMode;

		[Field("payboxConfig")]
		public Axelor.Apps.Account.Db.PayboxConfig? PayboxConfig;

		[Field("rejectImportPathAndFileName")]
		public string? RejectImportPathAndFileName;

		[Field("creditNoteJournalType")]
		public Axelor.Apps.Account.Db.JournalType? CreditNoteJournalType;

		[Field("advancePaymentProduct")]
		public Axelor.Apps.Base.Db.Product? AdvancePaymentProduct;

		[Field("profitAccount")]
		public Axelor.Apps.Account.Db.Account? ProfitAccount;

		[Field("paymentScheduleExportFolderPathCFONB")]
		public string? PaymentScheduleExportFolderPathCFONB;

		[Field("supplierCreditNoteJournal")]
		public Axelor.Apps.Account.Db.Journal? SupplierCreditNoteJournal;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("reimbursementExportFolderPathCFONB")]
		public string? ReimbursementExportFolderPathCFONB;

		[Field("reimbursementImportFolderPathCFONB")]
		public string? ReimbursementImportFolderPathCFONB;

		[Field("saleJournalType")]
		public Axelor.Apps.Account.Db.JournalType? SaleJournalType;

		[Field("tempImportPathAndFileName")]
		public string? TempImportPathAndFileName;

		[Field("rejectPaymentScheduleTemplate")]
		public Axelor.Apps.Message.Db.Template? RejectPaymentScheduleTemplate;

		[Field("archived")]
		public bool? Archived;

		[Field("custInvSequence")]
		public Axelor.Apps.Base.Db.Sequence? CustInvSequence;

		[Field("displayTimesheetOnPrinting")]
		public bool? DisplayTimesheetOnPrinting;

		[Field("standardRateTax")]
		public Axelor.Apps.Account.Db.Tax? StandardRateTax;

		[Field("allowRemovalValidatedMove")]
		public bool? AllowRemovalValidatedMove;

		[Field("irrecoverableReasonPassage")]
		public string? IrrecoverableReasonPassage;

		[Field("reimbursementExportFolderPath")]
		public string? ReimbursementExportFolderPath;

		[Field("factorPartner")]
		public Axelor.Apps.Base.Db.Partner? FactorPartner;

		[Field("irrecoverableJournal")]
		public Axelor.Apps.Account.Db.Journal? IrrecoverableJournal;

		[Field("autoMiscOpeJournal")]
		public Axelor.Apps.Account.Db.Journal? AutoMiscOpeJournal;

		[Field("cfonbConfig")]
		public Axelor.Apps.Account.Db.CfonbConfig? CfonbConfig;

		[Field("customerCreditNoteJournal")]
		public Axelor.Apps.Account.Db.Journal? CustomerCreditNoteJournal;

		[Field("displayProductCodeOnPrinting")]
		public bool? DisplayProductCodeOnPrinting;

		[Field("generateMoveForAdvancePayment")]
		public bool? GenerateMoveForAdvancePayment;

		[Field("invoiceAutomaticMail")]
		public bool? InvoiceAutomaticMail;

		[Field("reimbursementJournal")]
		public Axelor.Apps.Account.Db.Journal? ReimbursementJournal;

		[Field("importId")]
		public string? ImportId;

		[Field("generateMoveForInvoicePayment")]
		public bool? GenerateMoveForInvoicePayment;

		[Field("accountingDaybook")]
		public bool? AccountingDaybook;

		[Field("threeMonthDebtPassReason")]
		public string? ThreeMonthDebtPassReason;

		[Field("custRefSequence")]
		public Axelor.Apps.Base.Db.Sequence? CustRefSequence;

		[Field("exportFileName")]
		public string? ExportFileName;

		[Field("employeeAccountPrefix")]
		public string? EmployeeAccountPrefix;

		[Field("exportPath")]
		public string? ExportPath;

		[Field("customerAccountSequence")]
		public Axelor.Apps.Base.Db.Sequence? CustomerAccountSequence;

		[Field("customerAccountPrefix")]
		public string? CustomerAccountPrefix;

		[Field("clearanceAccountSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? ClearanceAccountSet;

		[Field("employeeAccount")]
		public Axelor.Apps.Account.Db.Account? EmployeeAccount;

		[Field("expenseTaxAccount")]
		public Axelor.Apps.Account.Db.Account? ExpenseTaxAccount;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("partnerAccountGenerationModeSelect")]
		public int? PartnerAccountGenerationModeSelect;

		[Field("sixMonthDebtMonthNumber")]
		public int? SixMonthDebtMonthNumber;

		[Field("rejectJournal")]
		public Axelor.Apps.Account.Db.Journal? RejectJournal;

		[Field("accountClearanceJournal")]
		public Axelor.Apps.Account.Db.Journal? AccountClearanceJournal;

		[Field("factorCreditAccount")]
		public Axelor.Apps.Account.Db.Account? FactorCreditAccount;

		[Field("forecastedInvCustAccount")]
		public Axelor.Apps.Account.Db.Account? ForecastedInvCustAccount;

		[Field("outPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? OutPaymentMode;

		[Field("mailTransitTime")]
		public int? MailTransitTime;

		[Field("invoicingProduct")]
		public Axelor.Apps.Base.Db.Product? InvoicingProduct;

		[Field("allowCancelVentilatedInvoice")]
		public bool? AllowCancelVentilatedInvoice;

		[Field("supplierAccountPrefix")]
		public string? SupplierAccountPrefix;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("sixMonthDebtPassReason")]
		public string? SixMonthDebtPassReason;

		[Field("reimbursementAccount")]
		public Axelor.Apps.Account.Db.Account? ReimbursementAccount;

		[Field("payingBackTax")]
		public Axelor.Apps.Account.Db.Tax? PayingBackTax;

		[Field("accountChart")]
		public Axelor.Apps.Account.Db.AccountChart? AccountChart;

		[Field("inPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? InPaymentMode;

		[Field("invoiceInAtiSelect")]
		public int? InvoiceInAtiSelect;

		[Field("doubtfulCustomerAccount")]
		public Axelor.Apps.Account.Db.Account? DoubtfulCustomerAccount;

		[Field("advancePaymentAccount")]
		public Axelor.Apps.Account.Db.Account? AdvancePaymentAccount;

		[Field("displayPartnerSeqOnPrinting")]
		public bool? DisplayPartnerSeqOnPrinting;

		[Field("autoReconcileOnInvoice")]
		public bool? AutoReconcileOnInvoice;

		[Field("threeMonthDebtMontsNumber")]
		public int? ThreeMonthDebtMontsNumber;

		[Field("reimbursementTemplate")]
		public Axelor.Apps.Message.Db.Template? ReimbursementTemplate;

		[Field("fixedAssetCatReqOnInvoice")]
		public bool? FixedAssetCatReqOnInvoice;

		[Field("suppRefSequence")]
		public Axelor.Apps.Base.Db.Sequence? SuppRefSequence;

		[Field("customerSalesJournal")]
		public Axelor.Apps.Account.Db.Journal? CustomerSalesJournal;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("displayExpenseOnPrinting")]
		public bool? DisplayExpenseOnPrinting;

		[Field("directDebitPaymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? DirectDebitPaymentMode;

		[Field("invoiceRejectNumLimit")]
		public int? InvoiceRejectNumLimit;

		[Field("supplierAccountSequence")]
		public Axelor.Apps.Base.Db.Sequence? SupplierAccountSequence;

	}
}
