using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaHelp")]
	public class MetaHelp : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("language")]
		[Field("language", true, null, Int32.MaxValue)]
		public string? Language;

		[JsonProperty("menu")]
		[Field("menu", false, null, Int32.MaxValue)]
		public string? Menu;

		[JsonProperty("type")]
		[Field("type", false, null, Int32.MaxValue)]
		public string? Type;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("help")]
		[Field("help", true, null, 1024)]
		public string? Help;

		[JsonProperty("view")]
		[Field("view", false, null, Int32.MaxValue)]
		public string? View;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("field")]
		[Field("field", false, null, Int32.MaxValue)]
		public string? Field;

		[JsonProperty("model")]
		[Field("model", false, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("style")]
		[Field("style", false, null, Int32.MaxValue)]
		public string? Style;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
