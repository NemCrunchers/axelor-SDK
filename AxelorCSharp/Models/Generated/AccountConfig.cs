using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AccountConfig")]
	public class AccountConfig : AxelorModel
	{
		[JsonProperty("hasChartImported")]
		[Field("hasChartImported", false, "False", Int32.MaxValue)]
		public bool? HasChartImported;

		[JsonProperty("suppInvSequence")]
		[Field("suppInvSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? SuppInvSequence;

		[JsonProperty("defPaymentCondition")]
		[Field("defPaymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? DefPaymentCondition;

		[JsonProperty("irrecoverableStandardRateTax")]
		[Field("irrecoverableStandardRateTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? IrrecoverableStandardRateTax;

		[JsonProperty("cashPositionVariationAccount")]
		[Field("cashPositionVariationAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? CashPositionVariationAccount;

		[JsonProperty("factorDebitAccount")]
		[Field("factorDebitAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? FactorDebitAccount;

		[JsonProperty("displayTaxDetailOnPrinting")]
		[Field("displayTaxDetailOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTaxDetailOnPrinting;

		[JsonProperty("autoReconcileOnPayment")]
		[Field("autoReconcileOnPayment", false, "False", Int32.MaxValue)]
		public bool? AutoReconcileOnPayment;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("expenseJournal")]
		[Field("expenseJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? ExpenseJournal;

		[JsonProperty("purchaseJournalType")]
		[Field("purchaseJournalType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.JournalType? PurchaseJournalType;

		[JsonProperty("supplierAccount")]
		[Field("supplierAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? SupplierAccount;

		[JsonProperty("invoiceMessageTemplate")]
		[Field("invoiceMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[JsonProperty("cashJournalType")]
		[Field("cashJournalType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.JournalType? CashJournalType;

		[JsonProperty("forecastedInvSuppAccount")]
		[Field("forecastedInvSuppAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ForecastedInvSuppAccount;

		[JsonProperty("employeeAccountSequence")]
		[Field("employeeAccountSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? EmployeeAccountSequence;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("tempReimbImportFolderPathCFONB")]
		[Field("tempReimbImportFolderPathCFONB", false, null, Int32.MaxValue)]
		public string? TempReimbImportFolderPathCFONB;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("irrecoverableAccount")]
		[Field("irrecoverableAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? IrrecoverableAccount;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("invoiceClientBox")]
		[Field("invoiceClientBox", false, null, Int32.MaxValue)]
		public string? InvoiceClientBox;

		[JsonProperty("supplierPurchaseJournal")]
		[Field("supplierPurchaseJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? SupplierPurchaseJournal;

		[JsonProperty("displayDelAddrOnPrinting")]
		[Field("displayDelAddrOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayDelAddrOnPrinting;

		[JsonProperty("manualMiscOpeJournal")]
		[Field("manualMiscOpeJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? ManualMiscOpeJournal;

		[JsonProperty("paymentScheduleRejectNumLimit")]
		[Field("paymentScheduleRejectNumLimit", false, "0", Int32.MaxValue)]
		public int? PaymentScheduleRejectNumLimit;

		[JsonProperty("customerAccount")]
		[Field("customerAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? CustomerAccount;

		[JsonProperty("rejectionPaymentMode")]
		[Field("rejectionPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? RejectionPaymentMode;

		[JsonProperty("payboxConfig")]
		[Field("payboxConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PayboxConfig? PayboxConfig;

		[JsonProperty("rejectImportPathAndFileName")]
		[Field("rejectImportPathAndFileName", false, null, Int32.MaxValue)]
		public string? RejectImportPathAndFileName;

		[JsonProperty("creditNoteJournalType")]
		[Field("creditNoteJournalType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.JournalType? CreditNoteJournalType;

		[JsonProperty("debtRecoveryConfigLineList")]
		[Field("debtRecoveryConfigLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.DebtRecoveryConfigLine>? DebtRecoveryConfigLineList;

		[JsonProperty("advancePaymentProduct")]
		[Field("advancePaymentProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? AdvancePaymentProduct;

		[JsonProperty("profitAccount")]
		[Field("profitAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ProfitAccount;

		[JsonProperty("lowerThresholdReimbursement")]
		[Field("lowerThresholdReimbursement", false, "0", Int32.MaxValue)]
		public decimal? LowerThresholdReimbursement;

		[JsonProperty("paymentScheduleExportFolderPathCFONB")]
		[Field("paymentScheduleExportFolderPathCFONB", false, null, Int32.MaxValue)]
		public string? PaymentScheduleExportFolderPathCFONB;

		[JsonProperty("supplierCreditNoteJournal")]
		[Field("supplierCreditNoteJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? SupplierCreditNoteJournal;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("reimbursementExportFolderPathCFONB")]
		[Field("reimbursementExportFolderPathCFONB", false, null, Int32.MaxValue)]
		public string? ReimbursementExportFolderPathCFONB;

		[JsonProperty("reimbursementImportFolderPathCFONB")]
		[Field("reimbursementImportFolderPathCFONB", false, null, Int32.MaxValue)]
		public string? ReimbursementImportFolderPathCFONB;

		[JsonProperty("saleJournalType")]
		[Field("saleJournalType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.JournalType? SaleJournalType;

		[JsonProperty("tempImportPathAndFileName")]
		[Field("tempImportPathAndFileName", false, null, Int32.MaxValue)]
		public string? TempImportPathAndFileName;

		[JsonProperty("rejectPaymentScheduleTemplate")]
		[Field("rejectPaymentScheduleTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RejectPaymentScheduleTemplate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("custInvSequence")]
		[Field("custInvSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? CustInvSequence;

		[JsonProperty("displayTimesheetOnPrinting")]
		[Field("displayTimesheetOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTimesheetOnPrinting;

		[JsonProperty("standardRateTax")]
		[Field("standardRateTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? StandardRateTax;

		[JsonProperty("allowRemovalValidatedMove")]
		[Field("allowRemovalValidatedMove", false, "False", Int32.MaxValue)]
		public bool? AllowRemovalValidatedMove;

		[JsonProperty("irrecoverableReasonPassage")]
		[Field("irrecoverableReasonPassage", false, "Manual shift into irrecoverable receivables", Int32.MaxValue)]
		public string? IrrecoverableReasonPassage;

		[JsonProperty("reimbursementExportFolderPath")]
		[Field("reimbursementExportFolderPath", false, null, Int32.MaxValue)]
		public string? ReimbursementExportFolderPath;

		[JsonProperty("factorPartner")]
		[Field("factorPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? FactorPartner;

		[JsonProperty("irrecoverableJournal")]
		[Field("irrecoverableJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? IrrecoverableJournal;

		[JsonProperty("autoMiscOpeJournal")]
		[Field("autoMiscOpeJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? AutoMiscOpeJournal;

		[JsonProperty("cfonbConfig")]
		[Field("cfonbConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.CfonbConfig? CfonbConfig;

		[JsonProperty("customerCreditNoteJournal")]
		[Field("customerCreditNoteJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? CustomerCreditNoteJournal;

		[JsonProperty("displayProductCodeOnPrinting")]
		[Field("displayProductCodeOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayProductCodeOnPrinting;

		[JsonProperty("generateMoveForAdvancePayment")]
		[Field("generateMoveForAdvancePayment", false, "True", Int32.MaxValue)]
		public bool? GenerateMoveForAdvancePayment;

		[JsonProperty("saleInvoiceLegalNote")]
		[Field("saleInvoiceLegalNote", false, null, Int32.MaxValue)]
		public string? SaleInvoiceLegalNote;

		[JsonProperty("invoiceAutomaticMail")]
		[Field("invoiceAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? InvoiceAutomaticMail;

		[JsonProperty("reimbursementJournal")]
		[Field("reimbursementJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? ReimbursementJournal;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("generateMoveForInvoicePayment")]
		[Field("generateMoveForInvoicePayment", false, "True", Int32.MaxValue)]
		public bool? GenerateMoveForInvoicePayment;

		[JsonProperty("accountingDaybook")]
		[Field("accountingDaybook", false, "False", Int32.MaxValue)]
		public bool? AccountingDaybook;

		[JsonProperty("threeMonthDebtPassReason")]
		[Field("threeMonthDebtPassReason", false, "Receivables over 3 months", Int32.MaxValue)]
		public string? ThreeMonthDebtPassReason;

		[JsonProperty("custRefSequence")]
		[Field("custRefSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? CustRefSequence;

		[JsonProperty("exportFileName")]
		[Field("exportFileName", false, null, Int32.MaxValue)]
		public string? ExportFileName;

		[JsonProperty("employeeAccountPrefix")]
		[Field("employeeAccountPrefix", false, null, Int32.MaxValue)]
		public string? EmployeeAccountPrefix;

		[JsonProperty("exportPath")]
		[Field("exportPath", false, null, Int32.MaxValue)]
		public string? ExportPath;

		[JsonProperty("customerAccountSequence")]
		[Field("customerAccountSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? CustomerAccountSequence;

		[JsonProperty("customerAccountPrefix")]
		[Field("customerAccountPrefix", false, null, Int32.MaxValue)]
		public string? CustomerAccountPrefix;

		[JsonProperty("clearanceAccountSet")]
		[Field("clearanceAccountSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? ClearanceAccountSet;

		[JsonProperty("employeeAccount")]
		[Field("employeeAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? EmployeeAccount;

		[JsonProperty("expenseTaxAccount")]
		[Field("expenseTaxAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ExpenseTaxAccount;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("partnerAccountGenerationModeSelect")]
		[Field("partnerAccountGenerationModeSelect", false, "0", Int32.MaxValue)]
		public int? PartnerAccountGenerationModeSelect;

		[JsonProperty("sixMonthDebtMonthNumber")]
		[Field("sixMonthDebtMonthNumber", false, "6", Int32.MaxValue)]
		public int? SixMonthDebtMonthNumber;

		[JsonProperty("rejectJournal")]
		[Field("rejectJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? RejectJournal;

		[JsonProperty("accountClearanceJournal")]
		[Field("accountClearanceJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? AccountClearanceJournal;

		[JsonProperty("factorCreditAccount")]
		[Field("factorCreditAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? FactorCreditAccount;

		[JsonProperty("forecastedInvCustAccount")]
		[Field("forecastedInvCustAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ForecastedInvCustAccount;

		[JsonProperty("outPaymentMode")]
		[Field("outPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? OutPaymentMode;

		[JsonProperty("mailTransitTime")]
		[Field("mailTransitTime", false, "0", Int32.MaxValue)]
		public int? MailTransitTime;

		[JsonProperty("invoicingProduct")]
		[Field("invoicingProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? InvoicingProduct;

		[JsonProperty("allowCancelVentilatedInvoice")]
		[Field("allowCancelVentilatedInvoice", false, "False", Int32.MaxValue)]
		public bool? AllowCancelVentilatedInvoice;

		[JsonProperty("supplierAccountPrefix")]
		[Field("supplierAccountPrefix", false, null, Int32.MaxValue)]
		public string? SupplierAccountPrefix;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("thresholdDistanceFromRegulation")]
		[Field("thresholdDistanceFromRegulation", false, "0", Int32.MaxValue)]
		public decimal? ThresholdDistanceFromRegulation;

		[JsonProperty("sixMonthDebtPassReason")]
		[Field("sixMonthDebtPassReason", false, "Receivables over 6 months", Int32.MaxValue)]
		public string? SixMonthDebtPassReason;

		[JsonProperty("reimbursementAccount")]
		[Field("reimbursementAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ReimbursementAccount;

		[JsonProperty("upperThresholdReimbursement")]
		[Field("upperThresholdReimbursement", false, "0", Int32.MaxValue)]
		public decimal? UpperThresholdReimbursement;

		[JsonProperty("payingBackTax")]
		[Field("payingBackTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? PayingBackTax;

		[JsonProperty("accountChart")]
		[Field("accountChart", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountChart? AccountChart;

		[JsonProperty("inPaymentMode")]
		[Field("inPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? InPaymentMode;

		[JsonProperty("invoiceInAtiSelect")]
		[Field("invoiceInAtiSelect", false, "1", Int32.MaxValue)]
		public int? InvoiceInAtiSelect;

		[JsonProperty("termsAndConditions")]
		[Field("termsAndConditions", false, null, Int32.MaxValue)]
		public string? TermsAndConditions;

		[JsonProperty("doubtfulCustomerAccount")]
		[Field("doubtfulCustomerAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? DoubtfulCustomerAccount;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("advancePaymentAccount")]
		[Field("advancePaymentAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? AdvancePaymentAccount;

		[JsonProperty("displayPartnerSeqOnPrinting")]
		[Field("displayPartnerSeqOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayPartnerSeqOnPrinting;

		[JsonProperty("autoReconcileOnInvoice")]
		[Field("autoReconcileOnInvoice", false, "False", Int32.MaxValue)]
		public bool? AutoReconcileOnInvoice;

		[JsonProperty("threeMonthDebtMontsNumber")]
		[Field("threeMonthDebtMontsNumber", false, "3", Int32.MaxValue)]
		public int? ThreeMonthDebtMontsNumber;

		[JsonProperty("reimbursementTemplate")]
		[Field("reimbursementTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? ReimbursementTemplate;

		[JsonProperty("fixedAssetCatReqOnInvoice")]
		[Field("fixedAssetCatReqOnInvoice", false, "False", Int32.MaxValue)]
		public bool? FixedAssetCatReqOnInvoice;

		[JsonProperty("suppRefSequence")]
		[Field("suppRefSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? SuppRefSequence;

		[JsonProperty("customerSalesJournal")]
		[Field("customerSalesJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? CustomerSalesJournal;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("displayExpenseOnPrinting")]
		[Field("displayExpenseOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayExpenseOnPrinting;

		[JsonProperty("directDebitPaymentMode")]
		[Field("directDebitPaymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? DirectDebitPaymentMode;

		[JsonProperty("invoiceRejectNumLimit")]
		[Field("invoiceRejectNumLimit", false, "0", Int32.MaxValue)]
		public int? InvoiceRejectNumLimit;

		[JsonProperty("supplierAccountSequence")]
		[Field("supplierAccountSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? SupplierAccountSequence;

	}
}
