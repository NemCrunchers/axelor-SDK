using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.MenuBuilder")]
	public class MenuBuilder : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("moduleToCheck")]
		[Field("moduleToCheck", false, null, Int32.MaxValue)]
		public string? ModuleToCheck;

		[JsonProperty("hidden")]
		[Field("hidden", false, "False", Int32.MaxValue)]
		public bool? Hidden;

		[JsonProperty("actionBuilder")]
		[Field("actionBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("icon")]
		[Field("icon", false, null, Int32.MaxValue)]
		public string? Icon;

		[JsonProperty("link")]
		[Field("link", false, null, Int32.MaxValue)]
		public string? Link;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("parentMenu")]
		[Field("parentMenu", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? ParentMenu;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("showAction")]
		[Field("showAction", false, "False", Int32.MaxValue)]
		public bool? ShowAction;

		[JsonProperty("top")]
		[Field("top", false, "False", Int32.MaxValue)]
		public bool? Top;

		[JsonProperty("conditionToCheck")]
		[Field("conditionToCheck", false, null, 1024)]
		public string? ConditionToCheck;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("tag")]
		[Field("tag", false, null, Int32.MaxValue)]
		public string? Tag;

		[JsonProperty("iconBackground")]
		[Field("iconBackground", false, null, Int32.MaxValue)]
		public string? IconBackground;

		[JsonProperty("order")]
		[Field("order", false, "0", Int32.MaxValue)]
		public int? Order;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("tagGet")]
		[Field("tagGet", false, null, Int32.MaxValue)]
		public string? TagGet;

		[JsonProperty("metaMenu")]
		[Field("metaMenu", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? MetaMenu;

		[JsonProperty("tagStyle")]
		[Field("tagStyle", false, null, Int32.MaxValue)]
		public string? TagStyle;

		[JsonProperty("mobile")]
		[Field("mobile", false, "False", Int32.MaxValue)]
		public bool? Mobile;

		[JsonProperty("groups")]
		[Field("groups", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[JsonProperty("metaModule")]
		[Field("metaModule", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModule? MetaModule;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("left")]
		[Field("left", false, "True", Int32.MaxValue)]
		public bool? Left;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("tagCount")]
		[Field("tagCount", false, "False", Int32.MaxValue)]
		public bool? TagCount;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
