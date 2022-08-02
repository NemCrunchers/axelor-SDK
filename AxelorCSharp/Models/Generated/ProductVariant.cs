using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ProductVariant")]
	public class ProductVariant : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("productVariantAttr3")]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr3;

		[Field("productVariantAttr4")]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr4;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("productVariantAttr1")]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr1;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("productVariantAttr2")]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr2;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("productVariantValue1")]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue1;

		[Field("usedForStock")]
		public bool? UsedForStock;

		[Field("importId")]
		public string? ImportId;

		[Field("productVariantValue2")]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue2;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("productVariantValue3")]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue3;

		[Field("productVariantValue4")]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue4;

	}
}
