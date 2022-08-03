using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaMenu")]
	public class MetaMenu : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? Parent;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("moduleToCheck")]
		[Field("moduleToCheck", false, null, Int32.MaxValue)]
		public string? ModuleToCheck;

		[JsonProperty("hidden")]
		[Field("hidden", false, "False", Int32.MaxValue)]
		public bool? Hidden;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("top")]
		[Field("top", false, "False", Int32.MaxValue)]
		public bool? Top;

		[JsonProperty("action")]
		[Field("action", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaAction? Action;

		[JsonProperty("conditionToCheck")]
		[Field("conditionToCheck", false, null, 1024)]
		public string? ConditionToCheck;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("tag")]
		[Field("tag", false, null, Int32.MaxValue)]
		public string? Tag;

		[JsonProperty("xmlId")]
		[Field("xmlId", false, null, Int32.MaxValue)]
		public string? XmlId;

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

		[JsonProperty("module")]
		[Field("module", false, null, Int32.MaxValue)]
		public string? Module;

		[JsonProperty("tagStyle")]
		[Field("tagStyle", false, null, Int32.MaxValue)]
		public string? TagStyle;

		[JsonProperty("mobile")]
		[Field("mobile", false, "False", Int32.MaxValue)]
		public bool? Mobile;

		[JsonProperty("groups")]
		[Field("groups", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

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
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("tagCount")]
		[Field("tagCount", false, "False", Int32.MaxValue)]
		public bool? TagCount;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
