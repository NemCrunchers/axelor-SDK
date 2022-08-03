using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.MrpLineType")]
	public class MrpLineType : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("elementSelect")]
		[Field("elementSelect", false, "0", Int32.MaxValue)]
		public int? ElementSelect;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("label")]
		[Field("label", false, null, Int32.MaxValue)]
		public string? Label;

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

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, null, Int32.MaxValue)]
		public string? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("includeElementWithoutDate")]
		[Field("includeElementWithoutDate", false, "False", Int32.MaxValue)]
		public bool? IncludeElementWithoutDate;

	}
}
