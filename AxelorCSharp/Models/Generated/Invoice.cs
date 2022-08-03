using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Invoice")]
	public class Invoice : AxelorModel
	{
		[JsonProperty("standardInvoice")]
		[Field("standardInvoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? StandardInvoice;

		[JsonProperty("partnerAccount")]
		[Field("partnerAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? PartnerAccount;

		[JsonProperty("partnerTaxNbr")]
		[Field("partnerTaxNbr", false, null, Int32.MaxValue)]
		public string? PartnerTaxNbr;

		[JsonProperty("invoicesCopySelect")]
		[Field("invoicesCopySelect", false, "1", Int32.MaxValue)]
		public int? InvoicesCopySelect;

		[JsonProperty("debtRecoveryBlockingReason")]
		[Field("debtRecoveryBlockingReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.StopReason? DebtRecoveryBlockingReason;

		[JsonProperty("amountRemaining")]
		[Field("amountRemaining", false, "0", Int32.MaxValue)]
		public decimal? AmountRemaining;

		[JsonProperty("invoiceLineTaxList")]
		[Field("invoiceLineTaxList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.InvoiceLineTax>? InvoiceLineTaxList;

		[JsonProperty("paymentSchedule")]
		[Field("paymentSchedule", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentSchedule? PaymentSchedule;

		[JsonProperty("debitBlockingOk")]
		[Field("debitBlockingOk", false, "False", Int32.MaxValue)]
		public bool? DebitBlockingOk;

		[JsonProperty("operationTypeSelect")]
		[Field("operationTypeSelect", true, "0", Int32.MaxValue)]
		public int? OperationTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("doubtfulCustomerOk")]
		[Field("doubtfulCustomerOk", false, "False", Int32.MaxValue)]
		public bool? DoubtfulCustomerOk;

		[JsonProperty("invoiceMessageTemplate")]
		[Field("invoiceMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[JsonProperty("contract")]
		[Field("contract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.Contract? Contract;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("externalReference")]
		[Field("externalReference", false, null, Int32.MaxValue)]
		public string? ExternalReference;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("companyTaxTotal")]
		[Field("companyTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyTaxTotal;

		[JsonProperty("advancePaymentInvoiceSet")]
		[Field("advancePaymentInvoiceSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? AdvancePaymentInvoiceSet;

		[JsonProperty("createdByInterco")]
		[Field("createdByInterco", false, "False", Int32.MaxValue)]
		public bool? CreatedByInterco;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("subscriptionToDate")]
		[Field("subscriptionToDate", false, null, Int32.MaxValue)]
		public DateTime? SubscriptionToDate;

		[JsonProperty("journal")]
		[Field("journal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("amountPaid")]
		[Field("amountPaid", false, "0", Int32.MaxValue)]
		public decimal? AmountPaid;

		[JsonProperty("displayTimesheetOnPrinting")]
		[Field("displayTimesheetOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTimesheetOnPrinting;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("companyInTaxTotalRemaining")]
		[Field("companyInTaxTotalRemaining", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotalRemaining;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("oldMove")]
		[Field("oldMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? OldMove;

		[JsonProperty("originDate")]
		[Field("originDate", false, null, Int32.MaxValue)]
		public DateTime? OriginDate;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[JsonProperty("debitBlockingToDate")]
		[Field("debitBlockingToDate", false, null, Int32.MaxValue)]
		public DateTime? DebitBlockingToDate;

		[JsonProperty("rejectMoveLine")]
		[Field("rejectMoveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? RejectMoveLine;

		[JsonProperty("tradingName")]
		[Field("tradingName", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[JsonProperty("address")]
		[Field("address", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? Address;

		[JsonProperty("refundInvoiceList")]
		[Field("refundInvoiceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? RefundInvoiceList;

		[JsonProperty("invoiceLineList")]
		[Field("invoiceLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.InvoiceLine>? InvoiceLineList;

		[JsonProperty("estimatedPaymentDate")]
		[Field("estimatedPaymentDate", false, null, Int32.MaxValue)]
		public DateTime? EstimatedPaymentDate;

		[JsonProperty("hideDiscount")]
		[Field("hideDiscount", false, "False", Int32.MaxValue)]
		public bool? HideDiscount;

		[JsonProperty("directDebitManagement")]
		[Field("directDebitManagement", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DirectDebitManagement? DirectDebitManagement;

		[JsonProperty("originalInvoice")]
		[Field("originalInvoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? OriginalInvoice;

		[JsonProperty("debtRecoveryBlockingOk")]
		[Field("debtRecoveryBlockingOk", false, "False", Int32.MaxValue)]
		public bool? DebtRecoveryBlockingOk;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("invoiceAutomaticMail")]
		[Field("invoiceAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? InvoiceAutomaticMail;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("companyInTaxTotal")]
		[Field("companyInTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotal;

		[JsonProperty("addressStr")]
		[Field("addressStr", false, null, Int32.MaxValue)]
		public string? AddressStr;

		[JsonProperty("amountRejected")]
		[Field("amountRejected", false, "0", Int32.MaxValue)]
		public decimal? AmountRejected;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("specificNotes")]
		[Field("specificNotes", false, null, Int32.MaxValue)]
		public string? SpecificNotes;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("validatedDate")]
		[Field("validatedDate", false, null, Int32.MaxValue)]
		public DateTime? ValidatedDate;

		[JsonProperty("invoiceId")]
		[Field("invoiceId", false, null, Int32.MaxValue)]
		public string? InvoiceId;

		[JsonProperty("supplierInvoiceNb")]
		[Field("supplierInvoiceNb", false, null, Int32.MaxValue)]
		public string? SupplierInvoiceNb;

		[JsonProperty("operationSubTypeSelect")]
		[Field("operationSubTypeSelect", true, "1", Int32.MaxValue)]
		public int? OperationSubTypeSelect;

		[JsonProperty("companyExTaxTotal")]
		[Field("companyExTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxTotal;

		[JsonProperty("dueDate")]
		[Field("dueDate", false, null, Int32.MaxValue)]
		public DateTime? DueDate;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("debitBlockingByUser")]
		[Field("debitBlockingByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? DebitBlockingByUser;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("alreadyPrintedOk")]
		[Field("alreadyPrintedOk", false, "True", Int32.MaxValue)]
		public bool? AlreadyPrintedOk;

		[JsonProperty("irrecoverableStatusSelect")]
		[Field("irrecoverableStatusSelect", false, "0", Int32.MaxValue)]
		public int? IrrecoverableStatusSelect;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("debtRecoveryBlockingByUser")]
		[Field("debtRecoveryBlockingByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? DebtRecoveryBlockingByUser;

		[JsonProperty("debitNumber")]
		[Field("debitNumber", false, null, Int32.MaxValue)]
		public string? DebitNumber;

		[JsonProperty("canceledPaymentSchedule")]
		[Field("canceledPaymentSchedule", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentSchedule? CanceledPaymentSchedule;

		[JsonProperty("managementObject")]
		[Field("managementObject", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.ManagementObject? ManagementObject;

		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("validatedByUser")]
		[Field("validatedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedByUser;

		[JsonProperty("debitBlockingReason")]
		[Field("debitBlockingReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.StopReason? DebitBlockingReason;

		[JsonProperty("inAti")]
		[Field("inAti", false, "False", Int32.MaxValue)]
		public bool? InAti;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("priceList")]
		[Field("priceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[JsonProperty("schedulePaymentOk")]
		[Field("schedulePaymentOk", false, "False", Int32.MaxValue)]
		public bool? SchedulePaymentOk;

		[JsonProperty("ventilatedByUser")]
		[Field("ventilatedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? VentilatedByUser;

		[JsonProperty("printingSettings")]
		[Field("printingSettings", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[JsonProperty("printedPDF")]
		[Field("printedPDF", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? PrintedPDF;

		[JsonProperty("rejectDate")]
		[Field("rejectDate", false, null, Int32.MaxValue)]
		public DateTime? RejectDate;

		[JsonProperty("invoicePaymentList")]
		[Field("invoicePaymentList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.InvoicePayment>? InvoicePaymentList;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("paymentMove")]
		[Field("paymentMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? PaymentMove;

		[JsonProperty("move")]
		[Field("move", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? Move;

		[JsonProperty("paymentCondition")]
		[Field("paymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("subscriptionFromDate")]
		[Field("subscriptionFromDate", false, null, Int32.MaxValue)]
		public DateTime? SubscriptionFromDate;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("internalReference")]
		[Field("internalReference", false, null, Int32.MaxValue)]
		public string? InternalReference;

		[JsonProperty("usherPassageOk")]
		[Field("usherPassageOk", false, "False", Int32.MaxValue)]
		public bool? UsherPassageOk;

		[JsonProperty("invoiceDate")]
		[Field("invoiceDate", false, null, Int32.MaxValue)]
		public DateTime? InvoiceDate;

		[JsonProperty("directDebitAmount")]
		[Field("directDebitAmount", false, "0", Int32.MaxValue)]
		public decimal? DirectDebitAmount;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("displayExpenseOnPrinting")]
		[Field("displayExpenseOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayExpenseOnPrinting;

		[JsonProperty("purchaseOrder")]
		[Field("purchaseOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[JsonProperty("ventilatedDate")]
		[Field("ventilatedDate", false, null, Int32.MaxValue)]
		public DateTime? VentilatedDate;

		[JsonProperty("hasPendingPayments")]
		[Field("hasPendingPayments", false, "False", Int32.MaxValue)]
		public bool? HasPendingPayments;

		[JsonProperty("debtRecoveryBlockingToDate")]
		[Field("debtRecoveryBlockingToDate", false, null, Int32.MaxValue)]
		public DateTime? DebtRecoveryBlockingToDate;

		[JsonProperty("interco")]
		[Field("interco", false, "False", Int32.MaxValue)]
		public bool? Interco;

	}
}
