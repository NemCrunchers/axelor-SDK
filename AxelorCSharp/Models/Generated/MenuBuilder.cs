using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.MenuBuilder")]
	public class MenuBuilder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("moduleToCheck")]
		public string? ModuleToCheck;

		[Field("hidden")]
		public bool? Hidden;

		[Field("actionBuilder")]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("icon")]
		public string? Icon;

		[Field("link")]
		public string? Link;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("parentMenu")]
		public Axelor.Meta.Db.MetaMenu? ParentMenu;

		[Field("archived")]
		public bool? Archived;

		[Field("showAction")]
		public bool? ShowAction;

		[Field("top")]
		public bool? Top;

		[Field("conditionToCheck")]
		public string? ConditionToCheck;

		[Field("id")]
		public long? Id;

		[Field("tag")]
		public string? Tag;

		[Field("iconBackground")]
		public string? IconBackground;

		[Field("order")]
		public int? Order;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("tagGet")]
		public string? TagGet;

		[Field("metaMenu")]
		public Axelor.Meta.Db.MetaMenu? MetaMenu;

		[Field("tagStyle")]
		public string? TagStyle;

		[Field("mobile")]
		public bool? Mobile;

		[Field("groups")]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[Field("metaModule")]
		public Axelor.Meta.Db.MetaModule? MetaModule;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("left")]
		public bool? Left;

		[Field("name")]
		public string? Name;

		[Field("tagCount")]
		public bool? TagCount;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
