using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppMobile")]
	public class AppMobile : AxelorModel
	{
		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("isSaleAppEnable")]
		public bool? IsSaleAppEnable;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("productSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[Field("archived")]
		public bool? Archived;

		[Field("isTimesheetAppEnable")]
		public bool? IsTimesheetAppEnable;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("isCrmAppEnable")]
		public bool? IsCrmAppEnable;

		[Field("id")]
		public long? Id;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("projectSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? ProjectSet;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("leadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[Field("partnerContactSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerContactSet;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("isLeaveAppEnable")]
		public bool? IsLeaveAppEnable;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("isExpenseAppEnable")]
		public bool? IsExpenseAppEnable;

	}
}
