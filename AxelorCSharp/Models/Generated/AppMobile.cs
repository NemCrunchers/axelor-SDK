using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppMobile")]
	public class AppMobile : AxelorModel
	{
		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("isSaleAppEnable")]
		[Field("isSaleAppEnable", false, "True", Int32.MaxValue)]
		public bool? IsSaleAppEnable;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("productSet")]
		[Field("productSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("isTimesheetAppEnable")]
		[Field("isTimesheetAppEnable", false, "True", Int32.MaxValue)]
		public bool? IsTimesheetAppEnable;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("isCrmAppEnable")]
		[Field("isCrmAppEnable", false, "True", Int32.MaxValue)]
		public bool? IsCrmAppEnable;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("projectSet")]
		[Field("projectSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? ProjectSet;

		[JsonProperty("offlineRecordLimit")]
		[Field("offlineRecordLimit", false, "0", Int32.MaxValue)]
		public decimal? OfflineRecordLimit;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("leadSet")]
		[Field("leadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[JsonProperty("partnerContactSet")]
		[Field("partnerContactSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerContactSet;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("isLeaveAppEnable")]
		[Field("isLeaveAppEnable", false, "True", Int32.MaxValue)]
		public bool? IsLeaveAppEnable;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("isExpenseAppEnable")]
		[Field("isExpenseAppEnable", false, "True", Int32.MaxValue)]
		public bool? IsExpenseAppEnable;

	}
}
