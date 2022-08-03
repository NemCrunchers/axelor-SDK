using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.Opportunity")]
	public class Opportunity : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("lostReason")]
		[Field("lostReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.LostReason? LostReason;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("memo")]
		[Field("memo", false, null, Int32.MaxValue)]
		public string? Memo;

		[JsonProperty("salesStageSelect")]
		[Field("salesStageSelect", false, "0", Int32.MaxValue)]
		public int? SalesStageSelect;

		[JsonProperty("source")]
		[Field("source", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Source? Source;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("expectedCloseDate")]
		[Field("expectedCloseDate", false, null, Int32.MaxValue)]
		public DateTime? ExpectedCloseDate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("lostReasonStr")]
		[Field("lostReasonStr", false, null, Int32.MaxValue)]
		public string? LostReasonStr;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("tradingName")]
		[Field("tradingName", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[JsonProperty("amount")]
		[Field("amount", false, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("probability")]
		[Field("probability", false, "0", Int32.MaxValue)]
		public decimal? Probability;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("lead")]
		[Field("lead", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("opportunityType")]
		[Field("opportunityType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.OpportunityType? OpportunityType;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("worstCase")]
		[Field("worstCase", false, null, Int32.MaxValue)]
		public string? WorstCase;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("nextStep")]
		[Field("nextStep", false, null, Int32.MaxValue)]
		public string? NextStep;

		[JsonProperty("bestCase")]
		[Field("bestCase", false, null, Int32.MaxValue)]
		public string? BestCase;

		[JsonProperty("orderByState")]
		[Field("orderByState", false, "0", Int32.MaxValue)]
		public int? OrderByState;

		[JsonProperty("saleOrderList")]
		[Field("saleOrderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrder>? SaleOrderList;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
