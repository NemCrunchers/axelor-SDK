using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AlarmEngine")]
	public class AlarmEngine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaModel")]
		[Field("metaModel", true, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[JsonProperty("query")]
		[Field("query", false, null, Int32.MaxValue)]
		public string? Query;

		[JsonProperty("externalOk")]
		[Field("externalOk", false, "False", Int32.MaxValue)]
		public bool? ExternalOk;

		[JsonProperty("lockingOk")]
		[Field("lockingOk", false, "False", Int32.MaxValue)]
		public bool? LockingOk;

		[JsonProperty("activeOk")]
		[Field("activeOk", false, "True", Int32.MaxValue)]
		public bool? ActiveOk;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("alarmMessage")]
		[Field("alarmMessage", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.AlarmMessage? AlarmMessage;

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

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("managerTypeSelect")]
		[Field("managerTypeSelect", false, "0", Int32.MaxValue)]
		public int? ManagerTypeSelect;

	}
}
