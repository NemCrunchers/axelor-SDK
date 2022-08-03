using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Move")]
	public class Move : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", false, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("accountingOk")]
		[Field("accountingOk", false, "False", Int32.MaxValue)]
		public bool? AccountingOk;

		[JsonProperty("paymentVoucher")]
		[Field("paymentVoucher", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentVoucher? PaymentVoucher;

		[JsonProperty("validationDate")]
		[Field("validationDate", false, null, Int32.MaxValue)]
		public DateTime? ValidationDate;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("ignoreInDebtRecoveryOk")]
		[Field("ignoreInDebtRecoveryOk", false, "False", Int32.MaxValue)]
		public bool? IgnoreInDebtRecoveryOk;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("journal")]
		[Field("journal", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("companyCurrency")]
		[Field("companyCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? CompanyCurrency;

		[JsonProperty("stockMove")]
		[Field("stockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? StockMove;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("rejectOk")]
		[Field("rejectOk", false, "False", Int32.MaxValue)]
		public bool? RejectOk;

		[JsonProperty("adjustingMove")]
		[Field("adjustingMove", false, "False", Int32.MaxValue)]
		public bool? AdjustingMove;

		[JsonProperty("period")]
		[Field("period", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("getInfoFromFirstMoveLineOk")]
		[Field("getInfoFromFirstMoveLineOk", false, "True", Int32.MaxValue)]
		public bool? GetInfoFromFirstMoveLineOk;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("companyCurrencyCode")]
		[Field("companyCurrencyCode", false, null, Int32.MaxValue)]
		public string? CompanyCurrencyCode;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("ignoreInAccountingOk")]
		[Field("ignoreInAccountingOk", false, "False", Int32.MaxValue)]
		public bool? IgnoreInAccountingOk;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("exportDate")]
		[Field("exportDate", false, null, Int32.MaxValue)]
		public DateTime? ExportDate;

		[JsonProperty("exportNumber")]
		[Field("exportNumber", false, null, Int32.MaxValue)]
		public string? ExportNumber;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("moveLineList")]
		[Field("moveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.MoveLine>? MoveLineList;

		[JsonProperty("technicalOriginSelect")]
		[Field("technicalOriginSelect", true, "0", Int32.MaxValue)]
		public int? TechnicalOriginSelect;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("currencyCode")]
		[Field("currencyCode", false, null, Int32.MaxValue)]
		public string? CurrencyCode;

		[JsonProperty("accountingReport")]
		[Field("accountingReport", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountingReport? AccountingReport;

	}
}
