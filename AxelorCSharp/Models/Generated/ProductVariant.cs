using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.ProductVariant")]
	public class ProductVariant : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("productVariantAttr3")]
		[Field("productVariantAttr3", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr3;

		[JsonProperty("productVariantAttr4")]
		[Field("productVariantAttr4", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr4;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("productVariantAttr1")]
		[Field("productVariantAttr1", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr1;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("productVariantAttr2")]
		[Field("productVariantAttr2", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantAttr? ProductVariantAttr2;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("productVariantValue1")]
		[Field("productVariantValue1", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue1;

		[JsonProperty("usedForStock")]
		[Field("usedForStock", false, "False", Int32.MaxValue)]
		public bool? UsedForStock;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productVariantValue2")]
		[Field("productVariantValue2", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue2;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("productVariantValue3")]
		[Field("productVariantValue3", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue3;

		[JsonProperty("productVariantValue4")]
		[Field("productVariantValue4", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantValue? ProductVariantValue4;

	}
}
