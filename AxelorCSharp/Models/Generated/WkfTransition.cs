using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.WkfTransition")]
	public class WkfTransition : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("alertTypeSelect")]
		[Field("alertTypeSelect", false, "0", Int32.MaxValue)]
		public int? AlertTypeSelect;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("buttonTitle")]
		[Field("buttonTitle", false, null, Int32.MaxValue)]
		public string? ButtonTitle;

		[JsonProperty("source")]
		[Field("source", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.WkfNode? Source;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("alertMsg")]
		[Field("alertMsg", false, null, Int32.MaxValue)]
		public string? AlertMsg;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("target")]
		[Field("target", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.WkfNode? Target;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("isButton")]
		[Field("isButton", false, "False", Int32.MaxValue)]
		public bool? IsButton;

		[JsonProperty("wkf")]
		[Field("wkf", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.Wkf? Wkf;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("successMsg")]
		[Field("successMsg", false, null, Int32.MaxValue)]
		public string? SuccessMsg;

		[JsonProperty("conditions")]
		[Field("conditions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.Filter>? Conditions;

		[JsonProperty("xmlId")]
		[Field("xmlId", false, null, Int32.MaxValue)]
		public string? XmlId;

		[JsonProperty("roleSet")]
		[Field("roleSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

	}
}
