using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaJsonModel")]
	public class MetaJsonModel : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("menuIcon")]
		public string? MenuIcon;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("menuBackground")]
		public string? MenuBackground;

		[Field("nameField")]
		public string? NameField;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("onNew")]
		public string? OnNew;

		[Field("archived")]
		public bool? Archived;

		[Field("menuTop")]
		public bool? MenuTop;

		[Field("action")]
		public Axelor.Meta.Db.MetaAction? Action;

		[Field("id")]
		public long? Id;

		[Field("onSave")]
		public string? OnSave;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("menuParent")]
		public Axelor.Meta.Db.MetaMenu? MenuParent;

		[Field("menuTitle")]
		public string? MenuTitle;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("menu")]
		public Axelor.Meta.Db.MetaMenu? Menu;

		[Field("showProcessTracking")]
		public bool? ShowProcessTracking;

		[Field("version")]
		public int? Version;

		[Field("menuOrder")]
		public int? MenuOrder;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("formView")]
		public Axelor.Meta.Db.MetaView? FormView;

		[Field("name")]
		public string? Name;

		[Field("gridView")]
		public Axelor.Meta.Db.MetaView? GridView;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
