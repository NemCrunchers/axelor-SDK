using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ProductCategory")]
	public class ProductCategory : AxelorModel
	{
		[Field("productFamily")]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

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

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("parentProductCategory")]
		public Axelor.Apps.Base.Db.ProductCategory? ParentProductCategory;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
