using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaSequence")]
	public class MetaSequence : AxelorModel
	{
		[JsonProperty("next")]
		[Field("next", true, "1", Int32.MaxValue)]
		public long? Next;

		[JsonProperty("padding")]
		[Field("padding", true, "0", Int32.MaxValue)]
		public int? Padding;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("initial")]
		[Field("initial", true, "0", Int32.MaxValue)]
		public long? Initial;

		[JsonProperty("prefix")]
		[Field("prefix", false, null, Int32.MaxValue)]
		public string? Prefix;

		[JsonProperty("increment")]
		[Field("increment", true, "1", Int32.MaxValue)]
		public int? Increment;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("suffix")]
		[Field("suffix", false, null, Int32.MaxValue)]
		public string? Suffix;

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

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
