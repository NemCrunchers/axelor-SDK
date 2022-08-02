using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AlarmEngineBatch")]
	public class AlarmEngineBatch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("alarmEngineSet")]
		public IEnumerable<Axelor.Apps.Base.Db.AlarmEngine>? AlarmEngineSet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("metaModelSet")]
		public IEnumerable<Axelor.Meta.Db.MetaModel>? MetaModelSet;

		[Field("id")]
		public long? Id;

	}
}
