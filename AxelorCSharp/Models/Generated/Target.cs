using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.Target")]
	public class Target : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("meetingNumberTarget")]
		public int? MeetingNumberTarget;

		[Field("code")]
		public string? Code;

		[Field("opportunityCreatedWon")]
		public int? OpportunityCreatedWon;

		[Field("opportunityCreatedNumber")]
		public int? OpportunityCreatedNumber;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("callEmittedNumberTarget")]
		public int? CallEmittedNumberTarget;

		[Field("periodTypeSelect")]
		public int? PeriodTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("opportunityCreatedWonTarget")]
		public int? OpportunityCreatedWonTarget;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("callEmittedNumber")]
		public int? CallEmittedNumber;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("meetingNumber")]
		public int? MeetingNumber;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("opportunityCreatedNumberTarget")]
		public int? OpportunityCreatedNumberTarget;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
