using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Exception.Db
{
	[Serializable]
	[Model("com.axelor.exception.db.TraceBack")]
	public class TraceBack : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", true, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("exception")]
		[Field("exception", true, null, Int32.MaxValue)]
		public string? Exception;

		[JsonProperty("categorySelect")]
		[Field("categorySelect", false, "0", Int32.MaxValue)]
		public int? CategorySelect;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("origin")]
		[Field("origin", false, null, Int32.MaxValue)]
		public string? Origin;

		[JsonProperty("cause")]
		[Field("cause", false, null, Int32.MaxValue)]
		public string? Cause;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("batchId")]
		[Field("batchId", false, "0", Int32.MaxValue)]
		public long? BatchId;

		[JsonProperty("error")]
		[Field("error", false, null, Int32.MaxValue)]
		public string? Error;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("ref")]
		[Field("ref", false, null, Int32.MaxValue)]
		public string? Ref;

		[JsonProperty("trace")]
		[Field("trace", false, null, Int32.MaxValue)]
		public string? Trace;

		[JsonProperty("internalUser")]
		[Field("internalUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? InternalUser;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("message")]
		[Field("message", false, null, Int32.MaxValue)]
		public string? Message;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("refId")]
		[Field("refId", false, null, Int32.MaxValue)]
		public long? RefId;

	}
}
