using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Move")]
	public class Move : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("accountingOk")]
		public bool? AccountingOk;

		[Field("paymentVoucher")]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("ignoreInDebtRecoveryOk")]
		public bool? IgnoreInDebtRecoveryOk;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("companyCurrency")]
		public Axelor.Apps.Base.Db.Currency? CompanyCurrency;

		[Field("stockMove")]
		public Axelor.Apps.Stock.Db.StockMove? StockMove;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("rejectOk")]
		public bool? RejectOk;

		[Field("adjustingMove")]
		public bool? AdjustingMove;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("getInfoFromFirstMoveLineOk")]
		public bool? GetInfoFromFirstMoveLineOk;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("companyCurrencyCode")]
		public string? CompanyCurrencyCode;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("ignoreInAccountingOk")]
		public bool? IgnoreInAccountingOk;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("exportNumber")]
		public string? ExportNumber;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("technicalOriginSelect")]
		public int? TechnicalOriginSelect;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("currencyCode")]
		public string? CurrencyCode;

		[Field("accountingReport")]
		public Axelor.Apps.Account.Db.AccountingReport? AccountingReport;

	}
}
