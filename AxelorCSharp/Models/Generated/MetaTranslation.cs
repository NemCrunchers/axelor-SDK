using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaTranslation")]
	public class MetaTranslation : AxelorModel
	{
		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("language")]
		[Field("language", true, null, Int32.MaxValue)]
		public string? Language;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("message")]
		[Field("message", false, null, 1024)]
		public string? Message;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("key")]
		[Field("key", true, null, 1024)]
		public string? Key;

	}
}
