using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Auth.Db
{
	[Serializable]
	[Model("com.axelor.auth.db.User")]
	public class User : AxelorModel
	{
		[JsonProperty("useSignatureForStock")]
		[Field("useSignatureForStock", false, "False", Int32.MaxValue)]
		public bool? UseSignatureForStock;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("singleTab")]
		[Field("singleTab", false, "False", Int32.MaxValue)]
		public bool? SingleTab;

		[JsonProperty("language")]
		[Field("language", false, null, Int32.MaxValue)]
		public string? Language;

		[JsonProperty("sendEmailUponPasswordChange")]
		[Field("sendEmailUponPasswordChange", false, "False", Int32.MaxValue)]
		public bool? SendEmailUponPasswordChange;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[JsonProperty("activeCompany")]
		[Field("activeCompany", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? ActiveCompany;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("iCalendar")]
		[Field("iCalendar", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ICalendar? ICalendar;

		[JsonProperty("workshopStockLocation")]
		[Field("workshopStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("noHelp")]
		[Field("noHelp", false, "False", Int32.MaxValue)]
		public bool? NoHelp;

		[JsonProperty("password")]
		[Field("password", true, null, Int32.MaxValue)]
		public string? Password;

		[JsonProperty("blocked")]
		[Field("blocked", false, "False", Int32.MaxValue)]
		public bool? Blocked;

		[JsonProperty("permissions")]
		[Field("permissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Permission>? Permissions;

		[JsonProperty("activeTeam")]
		[Field("activeTeam", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? ActiveTeam;

		[JsonProperty("emailAccountList")]
		[Field("emailAccountList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAccount>? EmailAccountList;

		[JsonProperty("today")]
		[Field("today", false, null, Int32.MaxValue)]
		public DateTime? Today;

		[JsonProperty("activateOn")]
		[Field("activateOn", false, null, Int32.MaxValue)]
		public DateTime? ActivateOn;

		[JsonProperty("calendarManagementList")]
		[Field("calendarManagementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.CalendarManagement>? CalendarManagementList;

		[JsonProperty("expiresOn")]
		[Field("expiresOn", false, null, Int32.MaxValue)]
		public DateTime? ExpiresOn;

		[JsonProperty("theme")]
		[Field("theme", false, null, Int32.MaxValue)]
		public string? Theme;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("companySet")]
		[Field("companySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

		[JsonProperty("email")]
		[Field("email", false, null, Int32.MaxValue)]
		public string? Email;

		[JsonProperty("followedMetaModelSet")]
		[Field("followedMetaModelSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaModel>? FollowedMetaModelSet;

		[JsonProperty("group")]
		[Field("group", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.Group? Group;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaPermissions")]
		[Field("metaPermissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("followersCalUserSet")]
		[Field("followersCalUserSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? FollowersCalUserSet;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("receiveEmails")]
		[Field("receiveEmails", false, "True", Int32.MaxValue)]
		public bool? ReceiveEmails;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("appPermissions")]
		[Field("appPermissions", false, null, Int32.MaxValue)]
		public string? AppPermissions;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("teamSet")]
		[Field("teamSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.Team>? TeamSet;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("electronicSignature")]
		[Field("electronicSignature", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("useSignatureForQuotations")]
		[Field("useSignatureForQuotations", false, "False", Int32.MaxValue)]
		public bool? UseSignatureForQuotations;

		[JsonProperty("homeAction")]
		[Field("homeAction", false, null, Int32.MaxValue)]
		public string? HomeAction;

	}
}
