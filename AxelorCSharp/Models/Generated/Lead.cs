using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.Lead")]
	public class Lead : AxelorModel
	{
		[JsonProperty("officeName")]
		[Field("officeName", false, null, Int32.MaxValue)]
		public string? OfficeName;

		[JsonProperty("eventList")]
		[Field("eventList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Event>? EventList;

		[JsonProperty("contactDate")]
		[Field("contactDate", false, null, Int32.MaxValue)]
		public DateTime? ContactDate;

		[JsonProperty("jobTitle")]
		[Field("jobTitle", false, null, Int32.MaxValue)]
		public string? JobTitle;

		[JsonProperty("estimatedBudget")]
		[Field("estimatedBudget", false, "0", Int32.MaxValue)]
		public decimal? EstimatedBudget;

		[JsonProperty("opportunitiesList")]
		[Field("opportunitiesList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Opportunity>? OpportunitiesList;

		[JsonProperty("source")]
		[Field("source", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Source? Source;

		[JsonProperty("titleSelect")]
		[Field("titleSelect", false, null, Int32.MaxValue)]
		public string? TitleSelect;

		[JsonProperty("isDoNotCall")]
		[Field("isDoNotCall", false, "False", Int32.MaxValue)]
		public bool? IsDoNotCall;

		[JsonProperty("isDoNotSendEmail")]
		[Field("isDoNotSendEmail", false, "False", Int32.MaxValue)]
		public bool? IsDoNotSendEmail;

		[JsonProperty("emailAddress")]
		[Field("emailAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAddress? EmailAddress;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("sourceDescription")]
		[Field("sourceDescription", false, null, Int32.MaxValue)]
		public string? SourceDescription;

		[JsonProperty("fax")]
		[Field("fax", false, null, Int32.MaxValue)]
		public string? Fax;

		[JsonProperty("primaryCountry")]
		[Field("primaryCountry", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? PrimaryCountry;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fixedPhone")]
		[Field("fixedPhone", false, null, Int32.MaxValue)]
		public string? FixedPhone;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("firstName")]
		[Field("firstName", false, null, Int32.MaxValue)]
		public string? FirstName;

		[JsonProperty("mobilePhone")]
		[Field("mobilePhone", false, null, Int32.MaxValue)]
		public string? MobilePhone;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("primaryAddress")]
		[Field("primaryAddress", false, null, Int32.MaxValue)]
		public string? PrimaryAddress;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("primaryState")]
		[Field("primaryState", false, null, Int32.MaxValue)]
		public string? PrimaryState;

		[JsonProperty("industrySector")]
		[Field("industrySector", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.IndustrySector? IndustrySector;

		[JsonProperty("lostReason")]
		[Field("lostReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.LostReason? LostReason;

		[JsonProperty("primaryPostalCode")]
		[Field("primaryPostalCode", false, null, Int32.MaxValue)]
		public string? PrimaryPostalCode;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("primaryCity")]
		[Field("primaryCity", false, null, Int32.MaxValue)]
		public string? PrimaryCity;

		[JsonProperty("webSite")]
		[Field("webSite", false, null, Int32.MaxValue)]
		public string? WebSite;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("lostReasonStr")]
		[Field("lostReasonStr", false, null, Int32.MaxValue)]
		public string? LostReasonStr;

		[JsonProperty("department")]
		[Field("department", false, null, Int32.MaxValue)]
		public string? Department;

		[JsonProperty("enterpriseName")]
		[Field("enterpriseName", false, null, Int32.MaxValue)]
		public string? EnterpriseName;

		[JsonProperty("isRecycled")]
		[Field("isRecycled", false, "False", Int32.MaxValue)]
		public bool? IsRecycled;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", true, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("statusDescription")]
		[Field("statusDescription", false, null, Int32.MaxValue)]
		public string? StatusDescription;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("referredBy")]
		[Field("referredBy", false, null, Int32.MaxValue)]
		public string? ReferredBy;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
