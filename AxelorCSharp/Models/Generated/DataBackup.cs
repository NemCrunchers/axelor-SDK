using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.DataBackup")]
	public class DataBackup : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("fetchLimit")]
		[Field("fetchLimit", false, "0", Int32.MaxValue)]
		public int? FetchLimit;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("backupMetaFile")]
		[Field("backupMetaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? BackupMetaFile;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("logMetaFile")]
		[Field("logMetaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? LogMetaFile;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("backupDate")]
		[Field("backupDate", false, null, Int32.MaxValue)]
		public DateTime? BackupDate;

		[JsonProperty("restoreDate")]
		[Field("restoreDate", false, null, Int32.MaxValue)]
		public DateTime? RestoreDate;

	}
}
