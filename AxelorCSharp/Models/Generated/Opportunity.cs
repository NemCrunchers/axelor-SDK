using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.Opportunity")]
	public class Opportunity : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("lostReason")]
		public Axelor.Apps.Crm.Db.LostReason? LostReason;

		[Field("salesStageSelect")]
		public int? SalesStageSelect;

		[Field("source")]
		public Axelor.Apps.Base.Db.Source? Source;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("tradingName")]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("lead")]
		public Axelor.Apps.Crm.Db.Lead? Lead;

		[Field("attrs")]
		public string? Attrs;

		[Field("opportunityType")]
		public Axelor.Apps.Crm.Db.OpportunityType? OpportunityType;

		[Field("importId")]
		public string? ImportId;

		[Field("worstCase")]
		public string? WorstCase;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("nextStep")]
		public string? NextStep;

		[Field("bestCase")]
		public string? BestCase;

		[Field("orderByState")]
		public int? OrderByState;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
