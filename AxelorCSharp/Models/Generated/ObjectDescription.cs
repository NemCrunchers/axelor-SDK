using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ObjectDescription")]
	public class ObjectDescription : AxelorModel
	{
		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("prodProcessLine")]
		public Axelor.Apps.Production.Db.ProdProcessLine? ProdProcessLine;

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

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
