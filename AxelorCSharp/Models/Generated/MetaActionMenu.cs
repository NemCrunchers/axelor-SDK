using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaActionMenu")]
	public class MetaActionMenu : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaActionMenu? Parent;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("hidden")]
		[Field("hidden", false, "False", Int32.MaxValue)]
		public bool? Hidden;

		[JsonProperty("module")]
		[Field("module", false, null, Int32.MaxValue)]
		public string? Module;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("action")]
		[Field("action", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaAction? Action;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("category")]
		[Field("category", false, null, Int32.MaxValue)]
		public string? Category;

		[JsonProperty("xmlId")]
		[Field("xmlId", false, null, Int32.MaxValue)]
		public string? XmlId;

		[JsonProperty("order")]
		[Field("order", false, "0", Int32.MaxValue)]
		public int? Order;

	}
}
