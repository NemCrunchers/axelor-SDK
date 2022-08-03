using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaSelectItem")]
	public class MetaSelectItem : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("select")]
		[Field("select", true, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaSelect? Select;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("data")]
		[Field("data", false, null, 1024)]
		public string? Data;

		[JsonProperty("hidden")]
		[Field("hidden", false, "False", Int32.MaxValue)]
		public bool? Hidden;

		[JsonProperty("icon")]
		[Field("icon", false, null, Int32.MaxValue)]
		public string? Icon;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

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

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("value")]
		[Field("value", true, null, Int32.MaxValue)]
		public string? Value;

		[JsonProperty("order")]
		[Field("order", false, "0", Int32.MaxValue)]
		public int? Order;

	}
}
