using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AccountingReport")]
	public class AccountingReport : AxelorModel
	{
		[JsonProperty("analyticJournal")]
		[Field("analyticJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[JsonProperty("date")]
		[Field("date", true, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("exportTypeSelect")]
		[Field("exportTypeSelect", false, null, Int32.MaxValue)]
		public string? ExportTypeSelect;

		[JsonProperty("year")]
		[Field("year", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Year? Year;

		[JsonProperty("global")]
		[Field("global", false, "False", Int32.MaxValue)]
		public bool? Global;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("ref")]
		[Field("ref", false, null, Int32.MaxValue)]
		public string? Ref;

		[JsonProperty("journal")]
		[Field("journal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[JsonProperty("balance")]
		[Field("balance", false, "0", Int32.MaxValue)]
		public decimal? Balance;

		[JsonProperty("publicationDateTime")]
		[Field("publicationDateTime", false, null, Int32.MaxValue)]
		public DateTime? PublicationDateTime;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("globalByPartner")]
		[Field("globalByPartner", false, "False", Int32.MaxValue)]
		public bool? GlobalByPartner;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[JsonProperty("period")]
		[Field("period", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("totalCredit")]
		[Field("totalCredit", false, "0", Int32.MaxValue)]
		public decimal? TotalCredit;

		[JsonProperty("accountSet")]
		[Field("accountSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? AccountSet;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("dateFrom")]
		[Field("dateFrom", false, null, Int32.MaxValue)]
		public DateTime? DateFrom;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("globalByDate")]
		[Field("globalByDate", false, "False", Int32.MaxValue)]
		public bool? GlobalByDate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("detailed")]
		[Field("detailed", false, "False", Int32.MaxValue)]
		public bool? Detailed;

		[JsonProperty("dateTo")]
		[Field("dateTo", false, null, Int32.MaxValue)]
		public DateTime? DateTo;

		[JsonProperty("totalDebit")]
		[Field("totalDebit", false, "0", Int32.MaxValue)]
		public decimal? TotalDebit;

	}
}
