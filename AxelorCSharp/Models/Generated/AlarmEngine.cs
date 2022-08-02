using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AlarmEngine")]
	public class AlarmEngine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaModel")]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[Field("externalOk")]
		public bool? ExternalOk;

		[Field("lockingOk")]
		public bool? LockingOk;

		[Field("activeOk")]
		public bool? ActiveOk;

		[Field("alarmMessage")]
		public Axelor.Apps.Base.Db.AlarmMessage? AlarmMessage;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("managerTypeSelect")]
		public int? ManagerTypeSelect;

	}
}
