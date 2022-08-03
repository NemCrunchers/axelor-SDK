using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Project.Db
{
	[Serializable]
	[Model("com.axelor.apps.project.db.Resource")]
	public class Resource : AxelorModel
	{
		[JsonProperty("batchNo")]
		[Field("batchNo", false, null, Int32.MaxValue)]
		public string? BatchNo;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("resourceImage")]
		[Field("resourceImage", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ResourceImage;

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

		[JsonProperty("resourceType")]
		[Field("resourceType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.ResourceType? ResourceType;

	}
}
