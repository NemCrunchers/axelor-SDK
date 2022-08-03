using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.ProductVariantConfig")]
	public class ProductVariantConfig : AxelorModel
	{
		[JsonProperty("productVariantValue2Set")]
		[Field("productVariantValue2Set", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue2Set;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("productVariantValue4Set")]
		[Field("productVariantValue4Set", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue4Set;

		[JsonProperty("productVariantValue3Set")]
		[Field("productVariantValue3Set", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue3Set;

		[JsonProperty("productVariantValue1Set")]
		[Field("productVariantValue1Set", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductVariantValue>? ProductVariantValue1Set;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
