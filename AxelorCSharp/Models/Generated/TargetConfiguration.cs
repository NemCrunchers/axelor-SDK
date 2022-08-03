using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.TargetConfiguration")]
	public class TargetConfiguration : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("opportunityAmountWon")]
		[Field("opportunityAmountWon", false, "0", Int32.MaxValue)]
		public decimal? OpportunityAmountWon;

		[JsonProperty("toDate")]
		[Field("toDate", true, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("opportunityCreatedWon")]
		[Field("opportunityCreatedWon", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedWon;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("opportunityCreatedNumber")]
		[Field("opportunityCreatedNumber", false, "0", Int32.MaxValue)]
		public int? OpportunityCreatedNumber;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("callEmittedNumber")]
		[Field("callEmittedNumber", false, "0", Int32.MaxValue)]
		public int? CallEmittedNumber;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", true, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("meetingNumber")]
		[Field("meetingNumber", false, "0", Int32.MaxValue)]
		public int? MeetingNumber;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("periodTypeSelect")]
		[Field("periodTypeSelect", false, "0", Int32.MaxValue)]
		public int? PeriodTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
