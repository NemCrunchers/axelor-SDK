using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.MoveTemplateLine")]
	public class MoveTemplateLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("hasPartnerToDebit")]
		[Field("hasPartnerToDebit", false, "False", Int32.MaxValue)]
		public bool? HasPartnerToDebit;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("hasPartnerToCredit")]
		[Field("hasPartnerToCredit", false, "False", Int32.MaxValue)]
		public bool? HasPartnerToCredit;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("moveTemplate")]
		[Field("moveTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveTemplate? MoveTemplate;

		[JsonProperty("percentage")]
		[Field("percentage", false, "0", 100)]
		public decimal? Percentage;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("credit")]
		[Field("credit", false, "0", Int32.MaxValue)]
		public decimal? Credit;

		[JsonProperty("debit")]
		[Field("debit", false, "0", Int32.MaxValue)]
		public decimal? Debit;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isValid")]
		[Field("isValid", false, "False", Int32.MaxValue)]
		public bool? IsValid;

		[JsonProperty("tax")]
		[Field("tax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? Tax;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("debitCreditSelect")]
		[Field("debitCreditSelect", false, null, Int32.MaxValue)]
		public string? DebitCreditSelect;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("account")]
		[Field("account", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
