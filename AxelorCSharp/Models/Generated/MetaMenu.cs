using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaMenu")]
	public class MetaMenu : AxelorModel
	{
		[Field("parent")]
		public Axelor.Meta.Db.MetaMenu? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("moduleToCheck")]
		public string? ModuleToCheck;

		[Field("hidden")]
		public bool? Hidden;

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

		[Field("archived")]
		public bool? Archived;

		[Field("top")]
		public bool? Top;

		[Field("action")]
		public Axelor.Meta.Db.MetaAction? Action;

		[Field("conditionToCheck")]
		public string? ConditionToCheck;

		[Field("id")]
		public long? Id;

		[Field("tag")]
		public string? Tag;

		[Field("xmlId")]
		public string? XmlId;

		[Field("iconBackground")]
		public string? IconBackground;

		[Field("order")]
		public int? Order;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("tagGet")]
		public string? TagGet;

		[Field("module")]
		public string? Module;

		[Field("tagStyle")]
		public string? TagStyle;

		[Field("mobile")]
		public bool? Mobile;

		[Field("groups")]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("version")]
		public int? Version;

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

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
