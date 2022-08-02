using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ProductVariantConfig")]
	public class ProductVariantConfig : AxelorModel
	{
		[Field("productVariantValue2Set")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue2Set;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("productVariantValue4Set")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue4Set;

		[Field("productVariantValue3Set")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue3Set;

		[Field("productVariantValue1Set")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue1Set;

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

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
