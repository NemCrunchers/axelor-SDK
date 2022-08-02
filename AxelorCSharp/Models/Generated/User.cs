using Axelor.SDK;

namespace Axelor.Auth.Db
{
	[Model("com.axelor.auth.db.User")]
	public class User : AxelorModel
	{
		[Field("useSignatureForStock")]
		public bool? UseSignatureForStock;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("singleTab")]
		public bool? SingleTab;

		[Field("language")]
		public string? Language;

		[Field("sendEmailUponPasswordChange")]
		public bool? SendEmailUponPasswordChange;

		[Field("activeCompany")]
		public Axelor.Apps.Base.Db.Company? ActiveCompany;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("iCalendar")]
		public Axelor.Apps.Base.Db.ICalendar? ICalendar;

		[Field("workshopStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[Field("archived")]
		public bool? Archived;

		[Field("noHelp")]
		public bool? NoHelp;

		[Field("password")]
		public string? Password;

		[Field("blocked")]
		public bool? Blocked;

		[Field("permissions")]
		public IEnumerable<Axelor.Auth.Db.Permission>? Permissions;

		[Field("activeTeam")]
		public Axelor.Team.Db.Team? ActiveTeam;

		[Field("today")]
		public DateTime? Today;

		[Field("theme")]
		public string? Theme;

		[Field("id")]
		public long? Id;

		[Field("companySet")]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

		[Field("email")]
		public string? Email;

		[Field("followedMetaModelSet")]
		public IEnumerable<Axelor.Meta.Db.MetaModel>? FollowedMetaModelSet;

		[Field("group")]
		public Axelor.Auth.Db.Group? Group;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaPermissions")]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[Field("fullName")]
		public string? FullName;

		[Field("followersCalUserSet")]
		public IEnumerable<Axelor.Auth.Db.User>? FollowersCalUserSet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("receiveEmails")]
		public bool? ReceiveEmails;

		[Field("version")]
		public int? Version;

		[Field("appPermissions")]
		public string? AppPermissions;

		[Field("importId")]
		public string? ImportId;

		[Field("teamSet")]
		public IEnumerable<Axelor.Team.Db.Team>? TeamSet;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("electronicSignature")]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[Field("name")]
		public string? Name;

		[Field("useSignatureForQuotations")]
		public bool? UseSignatureForQuotations;

		[Field("homeAction")]
		public string? HomeAction;

	}
}
