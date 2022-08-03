using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaJsonModel")]
	public class MetaJsonModel : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("menuIcon")]
		[Field("menuIcon", false, null, Int32.MaxValue)]
		public string? MenuIcon;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("menuBackground")]
		[Field("menuBackground", false, null, Int32.MaxValue)]
		public string? MenuBackground;

		[JsonProperty("nameField")]
		[Field("nameField", false, null, Int32.MaxValue)]
		public string? NameField;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("onNew")]
		[Field("onNew", false, null, Int32.MaxValue)]
		public string? OnNew;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("menuTop")]
		[Field("menuTop", false, "False", Int32.MaxValue)]
		public bool? MenuTop;

		[JsonProperty("action")]
		[Field("action", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaAction? Action;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("onSave")]
		[Field("onSave", false, null, Int32.MaxValue)]
		public string? OnSave;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("menuParent")]
		[Field("menuParent", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? MenuParent;

		[JsonProperty("menuTitle")]
		[Field("menuTitle", false, null, Int32.MaxValue)]
		public string? MenuTitle;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("menu")]
		[Field("menu", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaMenu? Menu;

		[JsonProperty("showProcessTracking")]
		[Field("showProcessTracking", false, "False", Int32.MaxValue)]
		public bool? ShowProcessTracking;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("menuOrder")]
		[Field("menuOrder", false, "0", Int32.MaxValue)]
		public int? MenuOrder;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("formView")]
		[Field("formView", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaView? FormView;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("fields")]
		[Field("fields", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaJsonField>? Fields;

		[JsonProperty("gridView")]
		[Field("gridView", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaView? GridView;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
