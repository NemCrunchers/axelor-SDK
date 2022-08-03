using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.EbicsRequestLog")]
	public class EbicsRequestLog : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("requestType")]
		[Field("requestType", false, null, Int32.MaxValue)]
		public string? RequestType;

		[JsonProperty("requestTraceText")]
		[Field("requestTraceText", false, null, Int32.MaxValue)]
		public string? RequestTraceText;

		[JsonProperty("ebicsUser")]
		[Field("ebicsUser", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? EbicsUser;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("responseCode")]
		[Field("responseCode", false, null, Int32.MaxValue)]
		public string? ResponseCode;

		[JsonProperty("requestTime")]
		[Field("requestTime", false, null, Int32.MaxValue)]
		public DateTime? RequestTime;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("responseTraceText")]
		[Field("responseTraceText", false, null, Int32.MaxValue)]
		public string? ResponseTraceText;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("responseFile")]
		[Field("responseFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ResponseFile;

	}
}
