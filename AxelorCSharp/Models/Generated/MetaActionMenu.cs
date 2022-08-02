using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaActionMenu")]
	public class MetaActionMenu : AxelorModel
	{
		[Field("parent")]
		public Axelor.Meta.Db.MetaActionMenu? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("hidden")]
		public bool? Hidden;

		[Field("module")]
		public string? Module;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("action")]
		public Axelor.Meta.Db.MetaAction? Action;

		[Field("id")]
		public long? Id;

		[Field("category")]
		public string? Category;

		[Field("xmlId")]
		public string? XmlId;

		[Field("order")]
		public int? Order;

	}
}
