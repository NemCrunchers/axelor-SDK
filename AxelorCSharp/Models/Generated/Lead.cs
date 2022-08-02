using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.Lead")]
	public class Lead : AxelorModel
	{
		[Field("officeName")]
		public string? OfficeName;

		[Field("jobTitle")]
		public string? JobTitle;

		[Field("source")]
		public Axelor.Apps.Base.Db.Source? Source;

		[Field("titleSelect")]
		public string? TitleSelect;

		[Field("isDoNotCall")]
		public bool? IsDoNotCall;

		[Field("isDoNotSendEmail")]
		public bool? IsDoNotSendEmail;

		[Field("id")]
		public long? Id;

		[Field("fax")]
		public string? Fax;

		[Field("primaryCountry")]
		public Axelor.Apps.Base.Db.Country? PrimaryCountry;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fixedPhone")]
		public string? FixedPhone;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("firstName")]
		public string? FirstName;

		[Field("mobilePhone")]
		public string? MobilePhone;

		[Field("name")]
		public string? Name;

		[Field("primaryAddress")]
		public string? PrimaryAddress;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("primaryState")]
		public string? PrimaryState;

		[Field("industrySector")]
		public Axelor.Apps.Base.Db.IndustrySector? IndustrySector;

		[Field("lostReason")]
		public Axelor.Apps.Crm.Db.LostReason? LostReason;

		[Field("primaryPostalCode")]
		public string? PrimaryPostalCode;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("primaryCity")]
		public string? PrimaryCity;

		[Field("webSite")]
		public string? WebSite;

		[Field("archived")]
		public bool? Archived;

		[Field("department")]
		public string? Department;

		[Field("enterpriseName")]
		public string? EnterpriseName;

		[Field("isRecycled")]
		public bool? IsRecycled;

		[Field("fullName")]
		public string? FullName;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("referredBy")]
		public string? ReferredBy;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
