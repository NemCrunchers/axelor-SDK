using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ImportConfiguration")]
	public class ImportConfiguration : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("typeSelect")]
		public string? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("bindMetaFile")]
		public Axelor.Meta.Db.MetaFile? BindMetaFile;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("dataMetaFile")]
		public Axelor.Meta.Db.MetaFile? DataMetaFile;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
