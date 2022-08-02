using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountingReport")]
	public class AccountingReport : AxelorModel
	{
		[Field("analyticJournal")]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("exportTypeSelect")]
		public string? ExportTypeSelect;

		[Field("year")]
		public Axelor.Apps.Base.Db.Year? Year;

		[Field("global")]
		public bool? Global;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("ref")]
		public string? Ref;

		[Field("journal")]
		public Axelor.Apps.Account.Db.Journal? Journal;

		[Field("publicationDateTime")]
		public DateTime? PublicationDateTime;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("globalByPartner")]
		public bool? GlobalByPartner;

		[Field("id")]
		public long? Id;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("accountSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? AccountSet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("globalByDate")]
		public bool? GlobalByDate;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("detailed")]
		public bool? Detailed;

	}
}
