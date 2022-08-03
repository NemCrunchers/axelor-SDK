using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.Target")]
	public class Target : AxelorModel
	{
		[JsonProperty("opportunityAmountWonTarget")]
		[Field("opportunityAmountWonTarget", false, "0", Int32.MaxValue)]
		public decimal? OpportunityAmountWonTarget;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("meetingNumberTarget")]
		[Field("meetingNumberTarget", false, "0", Int32.MaxValue)]
		public int? MeetingNumberTarget;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("opportunityCreatedWon")]
		[Field("opportunityCreatedWon", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedWon;

		[JsonProperty("opportunityCreatedNumber")]
		[Field("opportunityCreatedNumber", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedNumber;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("callEmittedNumberTarget")]
		[Field("callEmittedNumberTarget", false, "0", Int32.MaxValue)]
		public int? CallEmittedNumberTarget;

		[JsonProperty("periodTypeSelect")]
		[Field("periodTypeSelect", false, "0", Int32.MaxValue)]
		public int? PeriodTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("opportunityAmountWon")]
		[Field("opportunityAmountWon", false, "0", Int32.MaxValue)]
		public decimal? OpportunityAmountWon;

		[JsonProperty("opportunityCreatedWonTarget")]
		[Field("opportunityCreatedWonTarget", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedWonTarget;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("callEmittedNumber")]
		[Field("callEmittedNumber", false, "0", Int32.MaxValue)]
		public int? CallEmittedNumber;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("meetingNumber")]
		[Field("meetingNumber", false, "0", Int32.MaxValue)]
		public int? MeetingNumber;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("opportunityCreatedNumberTarget")]
		[Field("opportunityCreatedNumberTarget", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedNumberTarget;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
