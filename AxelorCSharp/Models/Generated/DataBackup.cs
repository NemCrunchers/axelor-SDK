using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.DataBackup")]
	public class DataBackup : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("fetchLimit")]
		public int? FetchLimit;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("backupMetaFile")]
		public Axelor.Meta.Db.MetaFile? BackupMetaFile;

		[Field("importId")]
		public string? ImportId;

		[Field("logMetaFile")]
		public Axelor.Meta.Db.MetaFile? LogMetaFile;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("backupDate")]
		public DateTime? BackupDate;

		[Field("restoreDate")]
		public DateTime? RestoreDate;

	}
}
