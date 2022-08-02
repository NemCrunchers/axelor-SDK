using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.TempBomTree")]
	public class TempBomTree : AxelorModel
	{
		[Field("bom")]
		public Axelor.Apps.Production.Db.BillOfMaterial? Bom;

		[Field("parent")]
		public Axelor.Apps.Production.Db.TempBomTree? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

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

		[Field("parentBom")]
		public Axelor.Apps.Production.Db.BillOfMaterial? ParentBom;

		[Field("archived")]
		public bool? Archived;

		[Field("prodProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
